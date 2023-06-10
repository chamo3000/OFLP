using System;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Text;
using System.Xml.Linq;

namespace OFLP.Controller
{
    internal class PrintController
    {

        public bool CrearFactura(string datosFactura)
        {
            try
            {
                // Crear el documento PDF
                PdfDocument document = new PdfDocument();

                // Agregar una página
                PdfPage page = document.AddPage();

                // Crear un objeto XGraphics para dibujar en la página
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Crear una fuente
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

                // Escribir un texto en la página
                gfx.DrawString("¡Hola, mundo!", font, XBrushes.Black,
                    new XRect(0, 0, page.Width, page.Height),
                    XStringFormats.Center);

                // Guardar el archivo PDF en disco
                document.Save(@"H:\Salvados\Oficina LBP\Github\OFLP\PDF\archivo.pdf");

                // Cerrar el documento
                document.Close();

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

    }
}
