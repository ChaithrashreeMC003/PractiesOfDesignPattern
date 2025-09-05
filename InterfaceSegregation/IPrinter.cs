using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IPrinter
    {
        void Print(string content);
    }
    public class PrinterDevice : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine($"Printing: {content}");
        }
    }
}
