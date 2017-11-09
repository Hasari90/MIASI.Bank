using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Logic.Interface;
using Bank.Logic;
using System.Linq;
using Bank.Logic.CustomException;

namespace Bank.Test
{
    /// <summary>
    /// Summary description for BankLogicTest
    /// </summary>
    [TestClass]
    public class BankLogicTest
    {
        IBankLogic bankLogic = new BankLogic();

        [TestMethod]
        public void BankLogic_CreateClient()
        {
            var bank = new Model.Bank()
            {
                Name = "TestBank",
                ClientList = new List<Model.Client>(),
            };

            var newClient = bankLogic.CreateClient(bank, "test", "testowy", "12312312311");
            Assert.IsNotNull(newClient);
            Assert.AreEqual("test", newClient.Firstname);
            Assert.AreEqual("testowy", newClient.Lastname);
            Assert.AreEqual("12312312311", newClient.PESEL);

            var clientFromBankList = bank.ClientList.SingleOrDefault(x => x.PESEL == "12312312311");

            Assert.IsNotNull(clientFromBankList);
            Assert.AreEqual(newClient.Firstname, clientFromBankList.Firstname);
            Assert.AreEqual(newClient.Lastname, clientFromBankList.Lastname);
            Assert.AreEqual(newClient.PESEL, clientFromBankList.PESEL);

            var newClient2 = bankLogic.CreateClient(bank, "test", "testowy2", "12312312312");
            Assert.AreNotEqual(newClient.ID, newClient2.ID);
        }

        [TestMethod]
        public void BankLogic_DeleteClient()
        {
            var bank = new Model.Bank()
            {
                Name = "TestBank",
                ClientList = new List<Model.Client>(),
            };

            var newClient1 = bankLogic.CreateClient(bank, "test", "testowy", "12312312311");
            var newClient2 = bankLogic.CreateClient(bank, "test", "testowy2", "12312312312");
            Assert.IsNotNull(newClient1);
            Assert.IsNotNull(newClient2);
            Assert.AreEqual(2, bank.ClientList.Count());
            bankLogic.DeleteClient(bank, newClient2);
            Assert.AreEqual(1, bank.ClientList.Count());
            var clientFromBank = bank.ClientList.SingleOrDefault();
            Assert.AreEqual(0, clientFromBank.ID);
        }

        [TestMethod]
        [ExpectedException(typeof(ClientDoesNotExistException))]
        public void BankLogic_DeleteClientExpectedException()
        {
            var bank = new Model.Bank()
            {
                Name = "TestBank",
                ClientList = new List<Model.Client>(),
            };

            var newClient1 = bankLogic.CreateClient(bank, "test", "testowy", "12312312311");
            var newClient2 = bankLogic.CreateClient(bank, "test", "testowy2", "12312312312");
            bankLogic.DeleteClient(bank, newClient2);
            bankLogic.DeleteClient(bank, newClient2);
        }

        [TestMethod]
        public void BankLogic_CreateInterestSystem()
        {
            var bank = new Model.Bank()
            {
                Name = "TestBank",
                InterestList = new List<Model.Interest>(),
            };

            bankLogic.CreateInterestSystem(bank, 10m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.BankAccount });
            bankLogic.CreateInterestSystem(bank, 11m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 12m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.Investment});
            bankLogic.CreateInterestSystem(bank, 13m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.Investment, Model.Enum.EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 14m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.BankAccount, Model.Enum.EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 15m, new List<Model.Enum.EProductType>() { Model.Enum.EProductType.BankAccount, Model.Enum.EProductType.Credit, Model.Enum.EProductType.Investment });

            Assert.IsNotNull(bank.InterestList);
            Assert.IsNotNull(!bank.InterestList.Any());
            Assert.AreEqual(3, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == Model.Enum.EProductType.BankAccount)).Count());
            Assert.AreEqual(4, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == Model.Enum.EProductType.Credit)).Count());
            Assert.AreEqual(3, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == Model.Enum.EProductType.Investment)).Count());
        }
    }
}
