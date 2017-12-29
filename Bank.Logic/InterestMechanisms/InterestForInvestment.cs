using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.InterestMechanisms
{
    public class InterestForInvestment : InterestMechanism
    {
        public InterestForInvestment(Investment investment) : base(investment)
        {

        }

        public override void Calculate()
        {
            SetInterestValue(0.10m);
        }
    }
}
