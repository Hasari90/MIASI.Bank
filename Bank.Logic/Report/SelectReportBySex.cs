using System;
using System.Collections.Generic;
using Bank.Base.Enum;
using Bank.Base.Visitor;
using Bank.Model;

namespace Bank.Logic.Report
{
    public class SelectReportBySex : BaseReport<Client>, IVisitor
    {
        public SelectReportBySex(ESexType sex)
        {
            SexParameter = sex;
        }

        public ESexType SexParameter { get; set; }

        public void Visit(Element element)
        {
            var client = (Client)element;

            if (client.Sex == SexParameter)
                base.ReportResult.Add(client);
        }
    }
}
