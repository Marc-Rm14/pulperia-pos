using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.DTOS
{
    public class ResultadoAutenticacion
    {

        public bool EsExitoso { get; set; }


        public UserSession? UserSession { get; set; }


        public TipoFallo TipoFallo { get; set; }



    }



    public enum TipoFallo 
    {
        Ninguno,
        UsuarioNoEncontrado,
        ContraseñaIncorrecta
    }
}
