using Bank.Model;
using Bank.Logic.Mediator;
using BankAspect;

namespace Bank.Logic.BankOperations
{
    public class BankTransfer : IBankOperation
    {
        public BankAccount BankAccount { get; set; }
        public BankAccount DestinationBankAccount { get; set; }
        public Model.Bank Bank { get; set; }
        public decimal Amount { get; set; }
        public bool IsExecuted { get; set; }

        public IMediator Mediator { get; set; }

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
            Mediator.Send(Amount, DestinationBankAccount, Bank);
            IsExecuted = true;
        }


    }
}