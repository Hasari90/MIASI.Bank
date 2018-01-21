using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bank.Model;
using Bank.Logic.BankOperations;
using Bank.Logic.Mediator;

namespace Bank.Test
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void MediatorTest_Transfer()
        {
            Mediator mediator = new Mediator();

            Model.Bank bank1 = new Model.Bank()
            {
                Name = "X",

            };
            var client = CreateClient(bank1);
            var bankAccount = CreateBankAccount(client);
            client.BankAccountList.Add(bankAccount);
            bank1.ClientList.Add(client);

            Model.Bank bank2 = new Model.Bank()
            {
                Name = "2"
            };
            client = CreateClient(bank2);
            bankAccount = CreateBankAccount(client);
            client.BankAccountList.Add(bankAccount);
            bank2.ClientList.Add(client);

            BankTransfer transfer = new BankTransfer(100, bank1.ClientList[0].BankAccountList[0], bank2.ClientList[0].BankAccountList[0], bank1)
            {
                Mediator = mediator,
            };
            transfer.ExecuteOperation();

            Assert.AreEqual(true, transfer.IsExecuted);

        }

        Client CreateClient(Model.Bank bank)
        {
            return new Client()
            {
                Bank = bank,
                Firstname = $"Test{Guid.NewGuid()}",
                Lastname = $"Test{Guid.NewGuid()}",
                Sex = Base.Enum.ESexType.Male,
                PESEL = "12312312312"
            };
        }
        BankAccount CreateBankAccount(Client client)
        {
            return new BankAccount()
            {
                Client = client,
                Balance = 1000,
                Number = Guid.NewGuid().ToString()
            };
        }

    }
}
