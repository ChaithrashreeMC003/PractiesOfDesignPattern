using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IScanner
    {
        void Scan(string content);
    }
    public class ScannerDevice : IScanner
    {
        public void Scan(string content)
        {
            Console.WriteLine($"Scanning: {content}");
        }
    }
}
