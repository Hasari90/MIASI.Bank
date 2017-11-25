using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Model;
using Bank.Logic.InterestMechanisms;
using Bank.Logic;

namespace Bank.Test
{
    [TestClass]
    public class BankAccountLogicTest
    {
        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentClient_1000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            ba.interestMechanism = new InterestNewClients(ba);


            Assert.AreEqual(20,logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentClient_10000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 11000,
            };
            ba.interestMechanism = new InterestNewClients(ba);


            Assert.AreEqual(440, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentClient_5000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 5000,
            };
            ba.interestMechanism = new InterestNewClients(ba);


            Assert.AreEqual(150, logic.Calculate(ba));
        }
    }
}
