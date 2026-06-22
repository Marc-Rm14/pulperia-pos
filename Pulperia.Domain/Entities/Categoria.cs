using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Domain.Entities
{
    public class Categoria
    {
        public string Nombre { get; set; } = string.Empty;
        public int Id { get; set; }




        public Categoria() { }

        public Categoria(string nombre, int idCategoria) 
        {
            Nombre = nombre;
            Id = idCategoria;
        }


        public override string ToString()
        {
            return $"{Id} | {Nombre}";
        }



        
    }
}
