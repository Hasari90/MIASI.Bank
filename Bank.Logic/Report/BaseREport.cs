using Bank.Base.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Report
{
    public class BaseReport<T> where T: Element
    {
        public BaseReport()
        {
            ReportResult = new List<T>();
        }

        public List<T> ReportResult { get; set; }
    }
}
