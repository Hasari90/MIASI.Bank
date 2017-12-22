using Bank.Base.CustomException;
using Bank.Model;

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
