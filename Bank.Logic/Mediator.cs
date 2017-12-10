using Bank.Model;
using Bank.Model.Interface;
using System.Collections.Generic;

namespace Bank.Logic
{
    public class Mediator : IMediator
    {
        private List<Model.Bank> transaction = new List<Model.Bank>();

        public void Send(decimal amonut, BankAccount bankAccount, Model.Bank bank)
        {
            BankLogic bankLogic = new BankLogic();
            bankLogic.Transfer(bankAccount, amonut);
        }

        public void AddBank(Model.Bank bank)
        {
            transaction.Add(bank);
        }
    }
}