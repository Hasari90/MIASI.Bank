using Bank.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;
using Bank.Logic.CustomException;

namespace Bank.Logic.BankOperations
{
    public class CreateDebit : IBankOperation
    {
        public BankAccount BankAccount { get; set; }
        public bool IsExecuted { get; set; }
        public decimal Amount { get; set; }

        public CreateDebit(BankAccount bankAccount, decimal amount)
        {
            BankAccount = bankAccount;
            Amount = amount;
        }

        public void ExecuteOperation()
        {
            if (!IsExecuted)
                DoCreateDebit();
            else
                throw new ExecutedBankOperationException();
        }

        private void DoCreateDebit()
        {
            BankAccount.IsDebit = true;
            BankAccount.MaxDebitBalance = Amount;
            IsExecuted = true;
        }
    }
}
