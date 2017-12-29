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

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentRegularClient_100000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 100000,
            };
            ba.interestMechanism = new InterestRegularClients(ba);

            Assert.AreEqual(6000, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentRegularClient_40000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 40000,
            };
            ba.interestMechanism = new InterestRegularClients(ba);

            Assert.AreEqual(2000, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentRegularClient_5000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 5000,
            };
            ba.interestMechanism = new InterestRegularClients(ba);

            Assert.AreEqual(200, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentRegularClient_1000()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            ba.interestMechanism = new InterestRegularClients(ba);

            Assert.AreEqual(30, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentFemale_10000()
        {
            BankAccountLogic logic = new BankAccountLogic();
            Client client = new Client()
            {
                Sex = Base.Enum.ESexType.Female,
            };

            BankAccount ba = new BankAccount()
            {
                Client = client,
                Balance = 10000,
            };
            ba.interestMechanism = new InterestForWoman(ba);

            Assert.AreEqual(500, logic.Calculate(ba));
        }

        [TestMethod]
        public void BankAccountLogic_CalculateInvestmentMale_10000()
        {
            BankAccountLogic logic = new BankAccountLogic();
            Client client = new Client()
            {
                Sex = Base.Enum.ESexType.Male,
            };

            BankAccount ba = new BankAccount()
            {
                Client = client,
                Balance = 10000,
            };
            ba.interestMechanism = new InterestForWoman(ba);

            Assert.AreEqual(100, logic.Calculate(ba));
        }
    }
}
