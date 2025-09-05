using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ReportData
    {
        public List<string> GetReportData()
        {
            return new List<string> { "Data1", "Data2", "Data3" };
        }
    }
}
