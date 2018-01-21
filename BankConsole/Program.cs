using Bank.Logic.BankOperations;
using Bank.Logic.Mediator;
using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Bank.Model.Bank bank1 = new Bank.Model.Bank()
            {
                Name = "X",

            };
            var client = CreateClient(bank1);
            var bankAccount = CreateBankAccount(client);
            client.BankAccountList.Add(bankAccount);
            bank1.ClientList.Add(client);

            Bank.Model.Bank bank2 = new Bank.Model.Bank()
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

            BankTransfer transfer2 = new BankTransfer(300, bank1.ClientList[0].BankAccountList[0], bank2.ClientList[0].BankAccountList[0], bank1)
            {
                Mediator = mediator,
            };
            transfer2.ExecuteOperation();

            BankTransfer transfer3 = new BankTransfer(400, bank1.ClientList[0].BankAccountList[0], bank2.ClientList[0].BankAccountList[0], bank1)
            {
                Mediator = mediator,
            };
            transfer3.ExecuteOperation();

            Console.ReadKey();
        }

       static Client CreateClient(Bank.Model.Bank bank)
        {
            return new Client()
            {
                Bank = bank,
                Firstname = $"Test{Guid.NewGuid()}",
                Lastname = $"Test{Guid.NewGuid()}",
                Sex = Bank.Base.Enum.ESexType.Male,
                PESEL = "12312312312"
            };
        }
       static BankAccount CreateBankAccount(Client client)
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
