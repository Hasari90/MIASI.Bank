using Bank.Model;
using Bank.Model.Interface;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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