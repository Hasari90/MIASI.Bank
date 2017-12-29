using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic
{
    public class InvestmentLogic
    {
        public decimal Calculate(Model.Investment investment)
        {
            investment.interestMechanism.Calculate();
            return investment.interestMechanism.InterestValue;
        }
    }
}
