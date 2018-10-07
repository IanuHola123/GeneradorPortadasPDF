/*Programa de Generacioón de documentos PDF desarrollado por Unai Juguera Jiménez 
 * para la generación de portadas para cuadernos de los centros educativos*/

//Versión: V1.0.1.2

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
            System.Console.WriteLine("Programa de Generacioón de documentos PDF desarrollado por Unai Juguera Jiménez" +
                "para la generación de portadas para cuadernos de los centros educativos");
            System.Console.WriteLine("Versión: 1.0.1.2");
            System.Console.WriteLine("Pulsa cualquier tecla para continuar");
            System.Console.ReadKey();
            System.Console.WriteLine("Escribe el nombre de tu documento. (Debe acabar en .pdf)");
            System.Console.WriteLine("Recuerda que se generará en el menú raíz de la aplicación. (De ahí que recomiendo usar la versión portable)");
            Document document = new Document();

            PdfWriter.GetInstance(document,

                          new FileStream(System.Console.ReadLine(),

                                 FileMode.OpenOrCreate));


            document.Open();
            System.Console.WriteLine("Por favor, introduce tu nombre");
            document.Add(new Paragraph(System.Console.ReadLine()));
            System.Console.WriteLine("Por favor, introduce tu centro");
            document.Add(new Paragraph(System.Console.ReadLine()));
            System.Console.WriteLine("Por favor, introduce la asignatura");
            document.Add(new Paragraph(System.Console.ReadLine()));
            System.Console.WriteLine("Por favor, introduce tu profesor/a");
            document.Add(new Paragraph(System.Console.ReadLine()));
            System.Console.WriteLine("Pulsa cualquier tecla para generar tu documento");
            System.Console.ReadKey();
            document.Close();

        }
    }
}