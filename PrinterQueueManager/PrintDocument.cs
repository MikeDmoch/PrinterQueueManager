using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueueManager
{
    internal class PrintDocument : ICommand
    {
        public Printer printer;
        public string document;

        public PrintDocument(Printer p, string d)
        {
            printer = p;
            document = d;
        }
        public void Execute() => this.printer.Print(document);
        public void Undo() => this.printer.CancelPrint(document);
    }
}
