using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ReportFormatter
    {
        public void PrintReport(List<string> data)
        {
            Console.WriteLine("Report:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
