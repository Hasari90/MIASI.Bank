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
    public class Withdraw : IBankOperation
    {
        public BankAccount BankAccount { get; set; }
        public bool IsExecuted { get; set; }
        public decimal Amount { get; set; }

        public Withdraw(BankAccount bankAccount, decimal amount)
        {
            BankAccount = bankAccount;
            Amount = amount;
        }

        public void ExecuteOperation()
        {
            if (!IsExecuted)
                DoWithdraw();
            else
                throw new ExecutedBankOperationException();
        }

        private void DoWithdraw()
        {
            BankAccount.Balance -= Amount;
            IsExecuted = true;
        }
    }
}
