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
            Investment newInvestment = new Investment()
            {
                BankAccountID = BankAccount.ID,
                Value = Amount,
                DateFrom = DateFrom,
                DateTo = DateTo,
                // TODO InterestID
            };

            //Dodanie do bazy

            IsExecuted = true;
        }
    }
}
