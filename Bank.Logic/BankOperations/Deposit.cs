using Bank.Base.CustomException;
using Bank.Model;

namespace Bank.Logic.BankOperations
{
    public class Deposit : IBankOperation
    {
        public bool IsExecuted { get; set; }
        public BankAccount BankAccount { get; set; }
        public decimal Amount { get; set; }

        public Deposit(BankAccount bankAccount, decimal amount)
        {
            BankAccount = bankAccount;
            Amount = amount;
        }

        public void ExecuteOperation()
        {
            if (!IsExecuted)
                DoDeposit();
            else
                throw new ExecutedBankOperationException();
        }

        private void DoDeposit()
        {
            BankAccount.Balance += Amount;
            IsExecuted = true;
        }
    }
}
