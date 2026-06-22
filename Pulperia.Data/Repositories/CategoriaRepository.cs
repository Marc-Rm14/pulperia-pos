using Dapper;
using System.Diagnostics;
using Pulperia.Domain.Interfaces;
using Pulperia.Domain.Entities;



namespace Pulperia.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly DbContext _dataBase;


        public CategoriaRepository(DbContext dbContext) 
        {
            _dataBase = dbContext;
        }

        public List<Categoria> ObtenerTodas()
        {
            using var db = _dataBase.ObtenerConexion();



            string sql = "SELECT id, nombre FROM categorias";

            //Le pasamos el tipo que va almacenar la lista, el cual es el mismo que va a devolver el metodo.
            return db.Query<Categoria>(sql).ToList();
        }



        public void ver(List<Categoria> ls)
        {
            foreach (Categoria c in ls)
            {
                Debug.WriteLine(c.ToString());
            }

        }


        public void Insertar(Categoria categoria)
        {
            using var db = _dataBase.ObtenerConexion();


            string sql = "INSERT INTO Categoria(Nombre) VALUES (@Nombre)";



            db.Execute(sql, categoria);
        }





    }
}
