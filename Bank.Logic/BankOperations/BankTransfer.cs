using Bank.Model.Interface;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Bank.Model;

namespace Bank.Logic.BankOperations
{
    class BankTransfer : IBankOperation
    {
        public BankAccount BankAccount { get; set; }
        public BankAccount DestinationBankAccount { get; set; }
        public Model.Bank Bank { get; set; }
        public decimal Amount { get; set; }
        public bool IsExecuted { get; set; }

        public Mediator mediator { get; set; }

        public BankTransfer(decimal amount, BankAccount bankAccount, BankAccount sendAccount, Model.Bank bank)
        {
            Amount = amount;
            BankAccount = bankAccount;
            DestinationBankAccount = sendAccount;
            Bank = bank;
        }


        public void ExecuteOperation()
        {
            BankAccount.Balance -= Amount;
            mediator.Send(Amount, DestinationBankAccount, Bank);
            IsExecuted = true;
        }


    }
}