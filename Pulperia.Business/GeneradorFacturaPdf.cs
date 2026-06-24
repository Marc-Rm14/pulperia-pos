using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Fonts;
using Pulperia.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pulperia.Business
{
    public class GeneradorFacturaPdf
    {
        public void GenerarDocumento(FacturaDatos datos, string rutaDestino)
        {

            GlobalFontSettings.UseWindowsFontsUnderWindows = true;

            // CREAR EL DOCUMENTO PRINCIPAL

            // 3. CREAR EL DOCUMENTO PRINCIPAL
            Document documento = new Document();
            documento.Info.Title = "Factura de Venta";

            // ... el resto de tu código (asegúrate de usar "Arial" en tus estilos)
            Style estiloNormal = documento.Styles["Normal"]!;
            estiloNormal.Font.Name = "Arial";
            estiloNormal.Font.Size = 10;

            // Estilo personalizado para el título principal
            Style estiloTitulo = documento.AddStyle("TituloFactura", "Normal");
            estiloTitulo.Font.Size = 16;
            estiloTitulo.Font.Bold = true;
            estiloTitulo.Font.Color = Colors.DarkBlue;

            // 3. AÑADIR LA SECCIÓN (Configuración de la página)
            Section seccion = documento.AddSection();
            seccion.PageSetup.PageFormat = PageFormat.A4;
            seccion.PageSetup.TopMargin = "1.5cm";
            seccion.PageSetup.BottomMargin = "1.5cm";
            seccion.PageSetup.LeftMargin = "1.5cm";
            seccion.PageSetup.RightMargin = "1.5cm";

            // 4. ENCABEZADO: DATOS DE LA EMPRESA
            Paragraph titulo = seccion.AddParagraph("FACTURA DE VENTA", "TituloFactura");
            titulo.Format.Alignment = ParagraphAlignment.Right;
            titulo.Format.SpaceAfter = "0.2cm";

            Paragraph datosEmpresa = seccion.AddParagraph();
            datosEmpresa.AddFormattedText("PULPERIA CHAMORRITO.\n", TextFormat.Bold);
            datosEmpresa.AddText("RUC: 123456789-0\n");
            datosEmpresa.AddText("Dirección Central #123\n");
            datosEmpresa.AddText("Teléfono: +505 8888-8888\n");
            datosEmpresa.Format.SpaceAfter = "1cm";

            Paragraph datosCliente = seccion.AddParagraph();

            datosCliente.AddFormattedText("CLIENTE: ", TextFormat.Bold);
            // Reemplaza 'NombreCliente' por la propiedad exacta que tengas en tu DTO (ej: datos.Cliente)
            datosCliente.AddText($"{datos.NombreCliente}\n");

            datosCliente.AddFormattedText("Nº FACTURA: ", TextFormat.Bold);
            // ¡Aquí vinculamos el número dinámico de la base de datos!
            datosCliente.AddText($"{datos.NumeroFactura}\n");

            datosCliente.AddFormattedText("FECHA: ", TextFormat.Bold);
            // Si 'Fecha' en tu DTO es DateTime, usás .ToString(), si ya es string, la pasás directo
            datosCliente.AddText((datos.Fecha + "\n"));

            datosCliente.Format.SpaceAfter = "0.8cm";

            // 6. TABLA DE DETALLES (PRODUCTOS)
            Table tabla = seccion.AddTable();
            tabla.Borders.Width = 0.5;
            tabla.Borders.Color = Colors.LightGray;

            // Definimos el ancho de cada columna (El total de la página A4 con márgenes de 1.5cm es ~18cm)
            Column colDescripcion = tabla.AddColumn("11cm"); // Columna 0
            Column colCantidad = tabla.AddColumn("2cm");    // Columna 1
            Column colPrecio = tabla.AddColumn("2.5cm");  // Columna 2
            Column colTotal = tabla.AddColumn("2.5cm");   // Columna 3

            // Alineaciones de texto en las columnas
            colCantidad.Format.Alignment = ParagraphAlignment.Center;
            colPrecio.Format.Alignment = ParagraphAlignment.Right;
            colTotal.Format.Alignment = ParagraphAlignment.Right;

            // Fila de Cabecera de la tabla
            Row filaCabecera = tabla.AddRow();
            filaCabecera.Shading.Color = Colors.LightSlateGray;
            filaCabecera.Format.Font.Bold = true;
            filaCabecera.Format.Font.Color = Colors.White;

            filaCabecera.Cells[0].AddParagraph("Descripción");
            filaCabecera.Cells[1].AddParagraph("Cant.");
            filaCabecera.Cells[2].AddParagraph("Precio Unit.");
            filaCabecera.Cells[3].AddParagraph("Total");

            // Espaciado interno para las celdas de la cabecera
            foreach (Cell celda in filaCabecera.Cells)
            {

                if (celda != null)
                {
                    ((Cell)celda).VerticalAlignment = VerticalAlignment.Center;
                }

            }




            foreach (var item in datos.Items)
            {
                Row fila = tabla.AddRow();

                fila.Cells[0].AddParagraph(item.NombreProducto);

                // "0.##" permite mostrar 1 o 1.5 o 0.5 sin ceros basura a la derecha
                fila.Cells[1].AddParagraph(item.Cantidad.ToString("0.##"));

                fila.Cells[2].AddParagraph(item.PrecioUnitario.ToString("C2"));
                fila.Cells[3].AddParagraph(item.Subtotal.ToString("C2"));
            }



            Row filaTotal = tabla.AddRow();
            filaTotal.Cells[0].Borders.Visible = false;
            filaTotal.Cells[1].Borders.Visible = false;
            filaTotal.Cells[2].AddParagraph("Total:").Format.Font.Bold = true;
            filaTotal.Cells[3].AddParagraph(datos.Total.ToString("C2")).Format.Font.Bold = true;

            // 8. RENDERIZAR Y GUARDAR EL PDF (Uso de PDFSharp)
            PdfDocumentRenderer renderizador = new PdfDocumentRenderer();
            renderizador.Document = documento;
            renderizador.RenderDocument();

            //string nombreArchivo = "Factura_Sencilla.pdf";
            renderizador.PdfDocument.Save((rutaDestino));

            // 9. MOSTRAR EL PDF AUTOMÁTICAMENTE AL USUARIO
            //Process.Start(new ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }

    }
}
