using Bank.Base.CustomException;
using Bank.Logic.Decorator;
using Bank.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Test
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void DecoratorTest_WithdrawMoneyFromBankAccount()
        {

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(ba);
            logic.WithdrawMoneyFromAccount(500);
            Assert.AreEqual(500, ba.Balance);
        }

        [TestMethod]
        public void DecoratorTest_WithdrawAllMoneyFromBankAccount()
        {

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(ba);
            logic.WithdrawMoneyFromAccount(1000);
            Assert.AreEqual(0, ba.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientAccountBalanceException))]
        public void DecoratorTest_WithdrawMoneyFromBankAccountException()
        {

            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(ba);
            logic.WithdrawMoneyFromAccount(1500);
        }

        [TestMethod]
        public void DecoratorTest_WithdrawMoneyFromCredit()
        {
            Credit c = new Credit()
            {
                BorrowedValue = 1000,
            };

            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(c);
            logic.WithdrawMoneyFromAccount(500);
            Assert.AreEqual(500, c.BorrowedValue);
        }

        [TestMethod]
        public void DecoratorTest_WithdrawAllMoneyFromCredit()
        {
            Credit c = new Credit()
            {
                BorrowedValue = 1000,
            };

            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(c);
            logic.WithdrawMoneyFromAccount(1000);
            Assert.AreEqual(0, c.BorrowedValue);
        }

        [TestMethod]
        public void DecoratorTest_WithdrawMoneyFromCredit2()
        {
            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            Credit c = new Credit()
            {
                BankAccount = ba,
                BorrowedValue = 1000,
            };

            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(c);
            logic.WithdrawMoneyFromAccount(500);
            Assert.AreEqual(500, c.BorrowedValue);
            Assert.AreEqual(1000, ba.Balance);
        }

        [TestMethod]
        public void DecoratorTest_WithdrawAllMoneyFromCreditAndFromBankAccount()
        {
            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            Credit c = new Credit()
            {
                BankAccount = ba,
                BorrowedValue = 1000,
            };

            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(c);
            logic.WithdrawMoneyFromAccount(2000);
            Assert.AreEqual(0, c.BorrowedValue);
            Assert.AreEqual(0, ba.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientAccountBalanceException))]
        public void DecoratorTest_WithdrawMoneyFromCreditAndFromBankAccountException()
        {
            BankAccount ba = new BankAccount()
            {
                Balance = 1000,
            };
            Credit c = new Credit()
            {
                BankAccount = ba,
                BorrowedValue = 1000,
            };

            WithdrawMoneyDecorator logic = new WithdrawMoneyDecorator(c);
            logic.WithdrawMoneyFromAccount(2500);
        }
    }
}
