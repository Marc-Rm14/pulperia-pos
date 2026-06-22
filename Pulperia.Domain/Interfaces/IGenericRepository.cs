using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {

        public IEnumerable<T> ObetnerTodos();
    }
}
