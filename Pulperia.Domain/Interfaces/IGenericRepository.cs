namespace Pulperia.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        IEnumerable<T> ObtenerTodos();

        bool Insert(T entidad);

        T ObtenerPorId(int id);

        bool Update(T entidad);
    }
}
