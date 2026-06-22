using Pulperia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> ObtenerTodas() { return new List<Categoria>(); }

        public void ver(List<Categoria> ls) { }

        public void Insertar(Categoria categoria) { }
    }
}
