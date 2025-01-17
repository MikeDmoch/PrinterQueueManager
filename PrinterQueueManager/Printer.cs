using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueueManager
{
    internal class Printer
    {
        void Print(string document) => Console.WriteLine($"Drukowanie: {document}");
        void CancelPrint(string document) => Console.WriteLine($"Zatrzymano drukowanie: {document}");

    }
}
