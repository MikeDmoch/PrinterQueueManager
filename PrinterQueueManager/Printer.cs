using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueueManager
{
    internal class Printer
    {
        public void Print(string document) => Console.WriteLine($"Drukowanie: {document}");
        public void CancelPrint(string document) => Console.WriteLine($"Zatrzymano drukowanie: {document}");

    }
}
