using System.Collections.Generic;
using System.Linq;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
namespace FreePDFParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any key");
            Console.ReadKey();
            PDFParser(@"C:\Users\artur\Downloads\0a831fda-601b-5c3a-885f-5b86fccdf11f_FFBJECJB-03-2023-0000027_invoice.pdf");
            Console.WriteLine("Program finished its work");
            Console.ReadKey();
        }
        private static void PDFParser(string Directory)
        {
            PdfDocument PDF = PdfDocument.Open(Directory);
            Page page = PDF.GetPage(1);
            IEnumerable<Word> words = page.GetWords();
            foreach (Word word in words)
            {
                Console.WriteLine(word.ToString());
            }

        }
    }
}