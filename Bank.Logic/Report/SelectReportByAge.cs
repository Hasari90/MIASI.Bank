using Bank.Base.Visitor;
using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Report
{
    public class SelectReportByAge : BaseReport<Client>, IVisitor
    {
        public int AgeFromParameter { get; set; }
        public int AgeToParameter { get; set; }

        public SelectReportByAge(int ageFrom, int ageTo)
        {
            AgeFromParameter = ageFrom;
            AgeToParameter = ageTo;
        }

        public void Visit(Element element)
        {
            var client = (Client)element;

            if (client.Age >= AgeFromParameter && client.Age <= AgeToParameter)
                base.ReportResult.Add(client);
        }
    }
}
