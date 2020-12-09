using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entidades;
using System.IO;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(List<Cliente> clientes, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Pulsacion");
            document.Open();
            document.Add(new Paragraph("INFORME DE PERSONAS REGISTRADAS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(clientes));
            document.Close();
        }

        private PdfPTable LlenarTabla(List<Cliente> clientes)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Edad"));
            tabla.AddCell(new Paragraph("Direccion"));
            tabla.AddCell(new Paragraph("Numero de telefono"));
            foreach (var item in clientes)
            {
                tabla.AddCell(new Paragraph(item.identificacion));
                tabla.AddCell(new Paragraph(item.nombre));
                tabla.AddCell(new Paragraph(item.edad.ToString()));
                tabla.AddCell(new Paragraph(item.direccion));
                tabla.AddCell(new Paragraph(item.numeroTelefono));
            }
            return tabla;
        }

    }
}
