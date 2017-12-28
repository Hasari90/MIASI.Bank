using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Model;
using Bank.Logic.InterestMechanisms;
using Bank.Logic;
using Bank.Logic.BankOperations;


namespace Bank.Test
{
    [TestClass]
    public class BankOperationLogic
    {
        [TestMethod]
        public void BankOperationLogic_BorrowMoney()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };

            BorrowMoney bm = new BorrowMoney(ba, 200, DateTime.Now);
            bm.ExecuteOperation();

            Assert.AreEqual(1, ba.CreditList.Count);
        }

        [TestMethod]
        public void BankOperationLogic_CreatDebit()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };

            CreateDebit cd = new CreateDebit(ba, 1000);
            cd.ExecuteOperation();

            Assert.AreEqual(1000, ba.MaxDebitBalance);
        }

        [TestMethod]
        public void BankOperationLogic_CreatInvestment()
        {
            BankAccountLogic logic = new BankAccountLogic();

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };

            CreateInvestment ci = new CreateInvestment(ba, 1200, DateTime.Now, DateTime.Now.AddDays(30));
            ci.ExecuteOperation();

            Assert.AreEqual(0, ba.Balance);
        }
    }
}
