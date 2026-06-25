using Dapper;
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

        public IEnumerable<Categoria> ObtenerTodos()
        {
            using var db = _dataBase.ObtenerConexion();



            string sql = "SELECT id as Id, nombre as Nombre FROM categorias";

            //Le pasamos el tipo que va almacenar la lista, el cual es el mismo que va a devolver el metodo.
            return db.Query<Categoria>(sql);
        }

        public bool Insert(Categoria entidad)
        {
            using var db = _dataBase.ObtenerConexion();


            string sql = "INSERT INTO Categoria(Nombre) VALUES (@Nombre)";



            int resultado = db.Execute(sql, entidad);


            if(resultado <= 0) return false;


            return true;
        }

        public Categoria ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categoria entidad)
        {
            throw new NotImplementedException();
        }
    }
}
