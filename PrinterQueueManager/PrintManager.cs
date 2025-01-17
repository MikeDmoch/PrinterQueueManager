using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterQueueManager
{
    internal class PrintManager
    {
        private readonly Queue<ICommand> printQueue = new Queue<ICommand>();
        private readonly Stack<ICommand> undoStack = new Stack<ICommand>();

        public void Add(ICommand c)
        {
            printQueue.Enqueue(c);
            Console.WriteLine("Dodano do kolejki wydruku");
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                var command = undoStack.Pop();
                command.Undo();
            }
            else Console.WriteLine("Nie ma nic do cofania");
        }

        public void Process()
        {
            var command = printQueue.Dequeue();
            command.Execute();
            undoStack.Push(command);
        }
    }
}
