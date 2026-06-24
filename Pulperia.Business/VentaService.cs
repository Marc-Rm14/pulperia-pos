using Pulperia.Data.Repositories;
using Pulperia.Domain.DTOS;
using Pulperia.Domain.Entities;
using Pulperia.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace Pulperia.Business
{
    public class VentaService
    {
        private readonly VentaRepository _ventaRepository;


        private readonly IProductoRepository _productoRepository;


        public VentaService(VentaRepository ventaRepository, IProductoRepository productoRepository)
        {
            _ventaRepository = ventaRepository;
            _productoRepository = productoRepository;
        }

        public ResultadoVenta RegistrarNuevaVenta(RegistrarVenta ventaDto)
        {
            // REGLA DE NEGOCIO 1: Validar que el DTO contenga datos (Seguridad del Backend)
            if (ventaDto == null || !ventaDto.Detalles.Any())
            {

                return new ResultadoVenta()
                {
                    EsExitosa = false,
                    MensajeError = "La venta no contiene productos para procesar.",
                    RutaPdf = ""

                };

                
            }

            // REGLA DE NEGOCIO 2: Validar stock en el servidor antes de vender
            foreach (var item in ventaDto.Detalles)
            {
                var producto = _productoRepository.ObtenerPorId(item.IdProducto);

                if ((decimal)producto.StockActual < item.Cantidad)
                {

                     return new ResultadoVenta()
                    {
                        EsExitosa = false,
                        MensajeError = $"No hay suficiente stock para el producto: {item.NombreProducto}. Stock disponible: {producto.StockActual}",
                        RutaPdf = ""
                    };
                }
            }

            // Si pasa todas las reglas de negocio, llamamos al Repositorio para que haga la Transacción SQL
            int guardadoExitoso = _ventaRepository.ProcesarVenta(ventaDto);

            if (guardadoExitoso <= 0)
            {

                

                return new ResultadoVenta()
                {
                    EsExitosa = false,
                    MensajeError = "Ocurrió un error inesperado en la base de datos al guardar la venta.",
                    RutaPdf = ""
                };
            }


            DateTime momentoVenta = DateTime.Now;
            //Si paso todas las validaciones, la venta fue exitosa

            var datosFactura = new FacturaDatos
            {
                NumeroFactura = $"FAC-{guardadoExitoso:D6}", 
                NombreCliente = "Cliente General",
                Fecha = momentoVenta,
                Items = ventaDto.Detalles
            };

            string nombreArchivo = $"Factura_{momentoVenta:yyyyMMdd_HHmmss}.pdf";

            string rutaPdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreArchivo);


            var generador = new GeneradorFacturaPdf();
            generador.GenerarDocumento(datosFactura, rutaPdf);


            return new ResultadoVenta()
            {
                EsExitosa = true,
                MensajeError = "",
                RutaPdf = rutaPdf

            };
        }
    }
}
