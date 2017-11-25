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
    public class BorrowMoney : IBankOperation
    {
        public BankAccount BankAccount { get; set; }
        public bool IsExecuted { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateFrom { get; set; }

        public BorrowMoney(BankAccount bankAccount, decimal amount, DateTime dateFrom)
        {
            BankAccount = bankAccount;
            Amount = amount;
        }

        public void ExecuteOperation()
        {
            if (!IsExecuted)
                DoBorrowMoney();
            else
                throw new ExecutedBankOperationException();
        }

        private void DoBorrowMoney()
        {
            Credit newCredit = new Credit()
            {
                BankAccountID = BankAccount.ID,
                DateFrom = DateFrom,
                BorrowedValue = Amount,
                /// Reszta
            };

            // TODO dodanie kredytu

            IsExecuted = true;
        }
    }
}
