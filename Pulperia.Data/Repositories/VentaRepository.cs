using Dapper;
using Pulperia.Domain.DTOS;
using System.Diagnostics;

namespace Pulperia.Data.Repositories
{
    public class VentaRepository
    {
        private readonly DbContext _dbContext;



        public VentaRepository(DbContext dbContext) 
        {
            _dbContext = dbContext;
        }


        public int ProcesarVenta(RegistrarVenta venta)
        {
            using (var conn = _dbContext.ObtenerConexion())
            {
                using (var transaccion = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlVenta = @"INSERT INTO ventas (id_usuario) 
                                    VALUES(@IdUsuario);                                    
                                    SELECT last_insert_rowid();";

                        int idNuevaVenta = conn.ExecuteScalar<int>(sqlVenta, new { IdUsuario = venta.IdUsuario }, transaccion);

                        // Procesamos cada artículo del carrito
                        foreach (var detalle in venta.Detalles)
                        {
                            
                            // NUEVA LÓGICA: Descuento automático de stock_lote en detalles_entradas
                           
                            double cantidadPorDescontar = (double)detalle.Cantidad;

                            // Buscamos los ingresos con stock_lote disponible, ordenados por vencimiento (PEPS)
                            string sqlObtenerLotes = @"
                                SELECT de.id, de.stock_lote 
                                FROM detalles_entradas de
                                INNER JOIN productos p ON de.id_producto = p.id
                                WHERE de.id_producto = @IdProducto AND de.stock_lote > 0
                                ORDER BY 
                                    CASE WHEN p.es_perecedero = 1 THEN de.fecha_vencimiento END ASC,
                                    CASE WHEN p.es_perecedero = 0 THEN de.id END ASC;";

                            // Si el producto es perecedero lo ordenamos por fecha, vence antes se va antes
                            // Si no los mas antiguo primero

                            var lotesDisponibles = conn.Query(sqlObtenerLotes, new { IdProducto = detalle.IdProducto }, transaccion);

                            foreach (var lote in lotesDisponibles)
                            {
                                if (cantidadPorDescontar <= 0) break;

                                double stockLoteActual = (double)lote.stock_lote;
                                double cantidadARestar = 0;

                                if (stockLoteActual >= cantidadPorDescontar)
                                {
                                    cantidadARestar = cantidadPorDescontar;
                                    cantidadPorDescontar = 0;
                                }
                                else
                                {
                                    cantidadARestar = stockLoteActual;
                                    cantidadPorDescontar -= stockLoteActual;
                                }

                                string sqlUpdateLote = @"UPDATE detalles_entradas 
                                                 SET stock_lote = stock_lote - @CantidadARestar 
                                                 WHERE id = @IdLote;";

                                conn.Execute(sqlUpdateLote, new { CantidadARestar = cantidadARestar, IdLote = lote.id }, transaccion);
                            }
                            

                            // A. Insertar en detalles_ventas (Tu código original intacto)
                            string sqlDetalle = @"INSERT INTO detalles_ventas (id_venta, id_producto, cantidad, precio_unitario) 
                                          VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario);";

                            conn.Execute(sqlDetalle, new
                            {
                                IdVenta = idNuevaVenta,
                                IdProducto = detalle.IdProducto,
                                Cantidad = (double)detalle.Cantidad,
                                PrecioUnitario = detalle.PrecioVentaCentavos
                            }, transaccion);

                            // B. Descontar el Stock Global en la tabla productos (Tu código original intacto)
                            string sqlStock = @"UPDATE productos 
                                        SET stock_actual = stock_actual - @Cantidad 
                                        WHERE id = @IdProducto;";

                            conn.Execute(sqlStock, new { Cantidad = (double)detalle.Cantidad, IdProducto = detalle.IdProducto }, transaccion);

                            // C. Registrar en la tabla movimientos (Tu código original intacto)
                            string sqlMovimiento = @"INSERT INTO movimientos (id_tipo_movimiento, id_usuario, id_producto, id_venta, cantidad) 
                                             VALUES (2, @IdUsuario, @IdProducto, @IdVenta, @Cantidad);";

                            conn.Execute(sqlMovimiento, new
                            {
                                IdUsuario = venta.IdUsuario,
                                IdProducto = detalle.IdProducto,
                                IdVenta = idNuevaVenta,
                                Cantidad = (double)detalle.Cantidad
                            }, transaccion);
                        }

                        transaccion.Commit();
                        return idNuevaVenta;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        Debug.WriteLine(ex.Message);
                        return 0;
                    }
                }
            }
        }

    }
}

