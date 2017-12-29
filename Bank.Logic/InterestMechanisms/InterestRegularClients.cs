using Bank.Model;

namespace Bank.Logic.InterestMechanisms
{
    public class InterestRegularClients : InterestMechanism
    {
        public InterestRegularClients(BankAccount bankAccount) : base(bankAccount)
        {
        }

        public override void Calculate()
        {
            if (BankAccount.Balance > 50000)
                SetInterestValue(0.06m);
            else if (BankAccount.Balance <= 50000 && BankAccount.Balance > 10000)
                SetInterestValue(0.05m);
            else if (BankAccount.Balance <= 10000 && BankAccount.Balance > 2000)
                SetInterestValue(0.04m);
            else
                SetInterestValue(0.03m);
        }
    }
}
