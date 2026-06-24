using Dapper;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using Pulperia.Domain.Interfaces;
using Pulperia.Domain.Entities;
using Pulperia.Domain.DTOS;

namespace Pulperia.Data.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DbContext _dataBase;





        public ProductoRepository(DbContext dbContext)
        {
            _dataBase = dbContext;
        }


        public bool Insert(Producto producto)
        {
            string sql = @"INSERT INTO productos 
                           (nombre, id_categoria, id_unidad_medida, precio_venta, stock_actual, stock_minimo) 
                           VALUES (@Nombre, @IdCategoria, @IdUnidadMedida, 
                            @PrecioVenta, @StockActual, @StockMinimo)";
            try
            {   
                using(var conn = _dataBase.ObtenerConexion()) 
                {
                    int filasAfectadas = conn.Execute(sql, producto);


                    return filasAfectadas > 0;


            }
                
                /*using var db = _dataBase.ObtenerConexion();

                db.Execute(sql, producto);*/
            }
            catch (SqliteException ex)
            {
                Debug.WriteLine(ex);
                return false;
            }

        }


        public Producto ObtenerPorId(int id)
        {
            string sql = @"
        SELECT 
            id AS IdProducto, 
            nombre AS NombreProducto, 
            precio_venta AS Precio, 
            stock_actual AS StockActual 
        FROM productos 
        WHERE id = @id AND esta_activo = 1";

            using (var conn = _dataBase.ObtenerConexion())
            {
                // QuerySingleOrDefault devuelve el objeto Producto o null si el ID no existe
                return conn.QuerySingleOrDefault<Producto>(sql, new { id }) ?? new Producto();
            }
        }

        public List<ProductoBusqueda> BuscarPorNombre(string textoBusqueda) 
        {
            string sql = @"
                SELECT id AS IdProducto, 
                       nombre AS Nombre, 
                       precio_venta AS PrecioVenta,
                       stock_actual AS StockTotal
                FROM productos
                WHERE nombre LIKE @patron AND esta_activo = 1
                LIMIT 10";


            using (var conn = _dataBase.ObtenerConexion()) 
            {
                var patron = $"%{textoBusqueda}%";

                return conn.Query<ProductoBusqueda>(sql, new { patron }).ToList();
            }
        }


        public List<Producto> ObtenerTodosConFiltro(string filtro = "")
        {
            using (var db = _dataBase.ObtenerConexion())
            {
                // Consultamos todos los campos de tu entidad pura Producto
                string sql = @"
                SELECT p.id AS IdProducto, 
                       p.nombre AS NombreProducto, 
                       p.id_categoria AS IdCategoria, 
                       p.id_unidad_medida AS IdUnidad, 
                       p.esta_activo AS EstaActivo, 
                       p.precio_venta AS Precio, 
                       p.stock_actual AS StockActual, 
                       p.stock_minimo AS StockMinimo, 
                       p.es_perecedero AS EsPerecedero,
                       c.nombre as CategoriaNombre
                       



                FROM productos p
                INNER JOIN categorias c ON p.id_categoria = c.id
                WHERE p.nombre LIKE @Filtro";

                var parametros = new { Filtro = $"%{filtro}%" };
                return db.Query<Producto>(sql, parametros).ToList();
            }
        }

        IEnumerable<Producto> IGenericRepository<Producto>.ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Producto>.Update(Producto entidad)
        {
            throw new NotImplementedException();
        }
    }
}
