using Bank.Model;

namespace Bank.Logic.Mediator
{
    public interface IMediator
    {
        void Send(decimal amonut, BankAccount bankAccount, Model.Bank bank);
    }
}