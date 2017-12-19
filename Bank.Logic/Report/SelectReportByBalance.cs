using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Base.Enum;
using Bank.Base.Visitor;

namespace Bank.Logic.Report
{
    public class SelectReportByBalance : BaseReport<BankAccount>, IVisitor
    {
        public ERaportByBalanceType Type { get; set; }
        public decimal Amount { get; set; }

        public SelectReportByBalance(ERaportByBalanceType type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public void Visit(Element element)
        {
            var account = (BankAccount)element;

            if ((Type == ERaportByBalanceType.LessThan && account.Balance < Amount) ||
                (Type == ERaportByBalanceType.MoreThan && account.Balance > Amount) ||
                (Type == ERaportByBalanceType.Equal && account.Balance == Amount))
                base.ReportResult.Add(account);
        }
    }
}
