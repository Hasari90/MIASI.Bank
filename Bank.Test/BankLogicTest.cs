using Bank.Base.Enum;
using Bank.Logic;
using Bank.Logic.CustomException;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Test
{
    /// <summary>
    /// Summary description for BankLogicTest
    /// </summary>
    [TestClass]
    public class BankLogicTest
    {
        BankLogic bankLogic = new BankLogic();

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
            Assert.AreNotEqual(newClient, newClient2);
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

            bankLogic.CreateInterestSystem(bank, 10m, new List<EProductType>() { EProductType.BankAccount });
            bankLogic.CreateInterestSystem(bank, 11m, new List<EProductType>() { EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 12m, new List<EProductType>() { EProductType.Investment});
            bankLogic.CreateInterestSystem(bank, 13m, new List<EProductType>() { EProductType.Investment, EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 14m, new List<EProductType>() { EProductType.BankAccount, EProductType.Credit });
            bankLogic.CreateInterestSystem(bank, 15m, new List<EProductType>() { EProductType.BankAccount, EProductType.Credit, EProductType.Investment });

            Assert.IsNotNull(bank.InterestList);
            Assert.IsNotNull(!bank.InterestList.Any());
            Assert.AreEqual(3, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == EProductType.BankAccount)).Count());
            Assert.AreEqual(4, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == EProductType.Credit)).Count());
            Assert.AreEqual(3, bank.InterestList.Where(x => x.DestinationProducts.Any(y => y == EProductType.Investment)).Count());
        }
    }
}
