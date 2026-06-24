using Pulperia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Pulperia.Domain.DTOS;

namespace Pulperia.Domain.Interfaces
{
    public interface IProductoRepository
    {
        bool Insert(Producto producto);


        List<ProductoBusqueda> BuscarPorNombre(string texto);

        Producto ObtenerPorId(int id);


        List<Producto> ObtenerTodos(string filtro);
    }

}

