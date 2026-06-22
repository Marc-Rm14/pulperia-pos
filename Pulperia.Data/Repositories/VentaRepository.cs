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


        public bool ProcesarVenta(RegistrarVenta venta)
        {
            using (var conn = _dbContext.ObtenerConexion())
            {
                conn.Open();



                using (var transaccion = conn.BeginTransaction())
                {
                    try
                    {
                        string sqlVenta = @"INSERT INTO ventas (id_usuario) 
                                        VALUES(@IdUsuario);
                                         SELECT  last_insert_rowid();";
                        int idNuevaVenta = conn.ExecuteScalar<int>(sqlVenta, new { IdUsuario = venta.IdUsuario, }, transaccion);


                        //Ahora procesamos cada articulo del carrito

                        foreach (var detalle in venta.Detalles)
                        {
                            string sqlDetalle = @"INSERT INTO detalles_ventas (id_venta, id_producto, cantidad, precio_unitario) 
                                                  VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario);";


                            conn.Execute(sqlDetalle, new
                            {
                                IdVenta = idNuevaVenta,
                                IdProducto = detalle.IdProducto,
                                Cantidad = (double)detalle.Cantidad, // Casteo a double para SQLite
                                PrecioUnitario = detalle.PrecioVentaCentavos
                            }, transaccion);

                            // B. Descontar el Stock Global en la tabla productos
                            string sqlStock = @"UPDATE productos 
                                                SET stock_actual = stock_actual - @Cantidad 
                                                WHERE id = @IdProducto;";

                            conn.Execute(sqlStock, new { Cantidad = (double)detalle.Cantidad, IdProducto = detalle.IdProducto }, transaccion);

                            // C. Opcional: Registrar en la tabla movimientos (Kardex)
                            string sqlMovimiento = @"INSERT INTO movimientos (id_tipo_movimiento, id_usuario, id_producto, id_venta, cantidad)
                                                     VALUES (2, @IdUsuario, @IdProducto, @IdVenta, @Cantidad);"; // Asumiendo que Tipo 2 = Venta

                            conn.Execute(sqlMovimiento, new
                            {
                                IdUsuario = venta.IdUsuario,
                                IdProducto = detalle.IdProducto,
                                IdVenta = idNuevaVenta,
                                Cantidad = (double)detalle.Cantidad
                            }, transaccion);
                        }

                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        Debug.WriteLine(ex.Message);
                        return false;
                    }



                }

            }   
        }      
                  
    }
}

