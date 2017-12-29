using Bank.Base.CustomException;
using Bank.Model;
using System;

namespace Bank.Logic.BankOperations
{
    public class CreateInvestment : IBankOperation
    {
        public bool IsExecuted { get; set; }
        public BankAccount BankAccount { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public CreateInvestment(BankAccount bankAccount, decimal amount, DateTime dateFrom, DateTime dateTo)
        {
            BankAccount = bankAccount;
            Amount = amount;
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public void ExecuteOperation()
        {
            if (!IsExecuted)
                DoCreateInvestment();
            else
                throw new ExecutedBankOperationException();
        }

        private void DoCreateInvestment()
        {
            if (BankAccount.Balance >= Amount)
            {
                Investment newInvestment = new Investment()
                {
                    BankAccount = BankAccount,
                    Value = Amount,
                    DateFrom = DateFrom,
                    DateTo = DateTo
                };

                BankAccount.Balance -= Amount;
            }
            IsExecuted = true;
        }
    }
}
