/*Programa de Generacioón de documentos PDF desarrollado por Unai Juguera Jiménez 
 * para la generación de portadas para cuadernos de los centros educativos*/

//Versión: V1.0.0.1

using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GeneradorPDF_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Generacioón de documentos PDF desarrollado por Unai Juguera Jiménez" +
                "para la generación de portadas para cuadernos de los centros educativos");
            Console.WriteLine("Versión: 1.0.0.1");
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Escribe el nombre de tu documento. (Debe acabar en .pdf)");
            Console.WriteLine("Recuerda que se generará en el menú raíz de la aplicación. (De ahí que recomiendo usar la versión portable)");
            Document document = new Document();

            PdfWriter.GetInstance(document,

                          new FileStream(Console.ReadLine(),

                                 FileMode.OpenOrCreate));


            document.Open();
            Console.WriteLine("Por favor, introduce tu nombre");
            document.Add(new Paragraph(Console.ReadLine()));
            Console.WriteLine("Por favor, introduce tu centro");
            document.Add(new Paragraph(Console.ReadLine()));
            Console.WriteLine("Por favor, introduce la asignatura");
            document.Add(new Paragraph(Console.ReadLine()));
            Console.WriteLine("Por favor, introduce tu profesor/a");
            document.Add(new Paragraph(Console.ReadLine()));
            Console.WriteLine("Pulsa cualquier tecla para generar tu documento");
            Console.ReadKey();
            document.Close();

        }
    }
}