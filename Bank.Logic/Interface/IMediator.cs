namespace Bank.Model.Interface
{
    interface IMediator
    {
        void Send(decimal amonut, BankAccount bankAccount, Bank bank);
    }
}