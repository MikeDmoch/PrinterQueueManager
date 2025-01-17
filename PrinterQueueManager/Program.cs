using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueueManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var printManager = new PrintManager();
            var doc1 = new PrintDocument(printer, "Document1.pdf");
            var doc2 = new PrintDocument(printer, "Document2.pdf");

            printManager.Add(doc1);
            printManager.Add(doc2);
            printManager.Process();
            printManager.Process();
            printManager.Undo();
            printManager.Undo();
            printManager.Undo();
        }
    }
}
