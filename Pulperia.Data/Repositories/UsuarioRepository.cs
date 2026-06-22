using Dapper;
using Pulperia.Domain.Entities;
using Pulperia.Domain.DTOS;
using Pulperia.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Data.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {

        private readonly DbContext _dbContext;



        public UsuarioRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }




        public UserSession? ObtenerPorNombre(string nombre) 
        {
            using var conn = _dbContext.ObtenerConexion();


            string sql = @"SELECT u.id as Id,
                                  u.nombre as Nombre,
                                  r.nombre as RoleName,
                                  u.contrasena_hash as ContrasenaHash FROM  usuarios u
                           INNER JOIN roles r ON u.id_rol = r.id
                           WHERE u.nombre = @nombre AND u.esta_activa = 1";


            return conn.QueryFirstOrDefault<UserSession>(sql, new { nombre = nombre });




        }
    }
}

