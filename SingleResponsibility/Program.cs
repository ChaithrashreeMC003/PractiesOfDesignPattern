using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reportData = new ReportData();
            var formatter = new ReportFormatter();

            var data = reportData.GetReportData();
            formatter.PrintReport(data);
        }
    }
}
