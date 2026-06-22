using System;
using System.Collections.Generic;
using System.Text;
using Pulperia.Data.Repositories;
using Pulperia.Domain.DTOS;
using Pulperia.Domain.Interfaces;
using Pulperia.Common;

namespace Pulperia.Business.Seguridad
{
    public class ServicioAutenticacion
    {

        private readonly IUsuarioRepository _usuarioRepository;

        private readonly CriptografiaService _seguridad;


        public ServicioAutenticacion(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
            _seguridad = new CriptografiaService();

        }


        public ResultadoAutenticacion Autenticar(string nombre, string contrasena) 
        {
            var usuario = _usuarioRepository.ObtenerPorNombre(nombre);


            if (usuario == null) 
            {
                return new ResultadoAutenticacion()
                {
                    EsExitoso = false,
                    UserSession = null,
                    TipoFallo = TipoFallo.UsuarioNoEncontrado

                };
            }





            bool esvalida = _seguridad.Verificar(contrasena, usuario.ContrasenaHash);




            if (!esvalida) 
            {
                return new ResultadoAutenticacion()
                {
                    EsExitoso = false,
                    UserSession = null,
                    TipoFallo = TipoFallo.ContraseñaIncorrecta

                };
            }



            usuario.ContrasenaHash = string.Empty;

            return new ResultadoAutenticacion()
            {
                EsExitoso = true,
                UserSession = usuario,
                TipoFallo = TipoFallo.Ninguno   
            };






        }



    }
}
