using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new PrinterDevice();
            IScanner scanner = new ScannerDevice();

            printer.Print("Document1");
            scanner.Scan("Document1");
        }
    }
}
