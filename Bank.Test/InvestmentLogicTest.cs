using Bank.Logic;
using Bank.Logic.InterestMechanisms;
using Bank.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Test
{
    [TestClass]
    public class InvestmentLogicTest
    {
        [TestMethod]
        public void InvestmentLogic_CalculateInvestment_40000()
        {
            InvestmentLogic logic = new InvestmentLogic();

            Investment investment = new Investment()
            {
                Value = 40000,
            };

            investment.interestMechanism = new InterestForInvestment(investment);

            Assert.AreEqual(4000, logic.Calculate(investment));
        }
    }
}
