using Dapper;
using Pulperia.Domain.Entities;
using Pulperia.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Pulperia.Data.Repositories
{
    public class UnidadMedidaRepository : IUnidadMedidaRepository
    {
        private readonly DbContext  _dbContext;
        public UnidadMedidaRepository(DbContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public bool Insert(UnidadMedida entidad)
        {
            throw new NotImplementedException();
        }

        public UnidadMedida ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UnidadMedida> ObtenerTodos()
        {
            string sql = @"SELECT id as Id, nombre as Nombre, siglas as Siglas FROM unidades_medida";


            using(var conn = _dbContext.ObtenerConexion()) 
            {

                 return conn.Query<UnidadMedida>(sql);
            }
        
        }

        public bool Update(UnidadMedida entidad)
        {
            throw new NotImplementedException();
        }
    }
}
