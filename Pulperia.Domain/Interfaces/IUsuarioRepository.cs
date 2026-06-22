using Pulperia.Domain.DTOS;
using Pulperia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Interfaces
{
    public interface IUsuarioRepository
    {

        UserSession? ObtenerPorNombre(string usuario);
    }
}
