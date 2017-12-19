using Bank.Base.CustomException;
using Bank.Model;
using System;

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
                BankAccount = BankAccount,
                DateFrom = DateFrom,
                BorrowedValue = Amount,
                // Reszta
                
            };

            BankAccount.CreditList.Add(newCredit);

            IsExecuted = true;
        }
    }
}
