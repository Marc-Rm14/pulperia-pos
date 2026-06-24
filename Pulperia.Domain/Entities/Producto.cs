using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pulperia.Domain.Entities
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public int IdCategoria { get; set; }
        public int IdUnidad { get; set; }
        public bool EstaActivo { get; set; }
        public int Precio { get; set; }
       
        public int StockMinimo {  get; set; }
        public bool EsPerecedero {  get; set; }

        public double StockActual { get; set; }


        public decimal PrecioDecimal => Precio / 100m;


        public string CategoriaNombre { get; set; }


        public Producto() { } 


        /*public Producto(int idProducto, string nombreProducto, int idCategoria, int idUnidad, bool estaActivo,
            decimal precio, decimal existencia, decimal stockMinimo, bool esPerecedero ) 
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            IdCategoria = idCategoria;
            IdUnidad = idUnidad;
            EstaActivo = estaActivo;
            Precio = precio;
            Existencia = existencia;
            StockMinimo = stockMinimo;
            EsPerecedero = esPerecedero;

        }*/



    }
}
