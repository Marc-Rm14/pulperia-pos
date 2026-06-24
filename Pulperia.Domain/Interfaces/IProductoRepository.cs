using Pulperia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Pulperia.Domain.DTOS;

namespace Pulperia.Domain.Interfaces
{
    public interface IProductoRepository: IGenericRepository<Producto>
    {

        

        List<ProductoBusqueda> BuscarPorNombre(string texto);



        List<Producto> ObtenerTodosConFiltro(string filtro);

        



    }

}

