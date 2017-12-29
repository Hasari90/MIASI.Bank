namespace Bank.Model
{
    public abstract class InterestMechanism
    {
        public decimal InterestValue { get; set; }
        public BankAccount BankAccount { get; set; }

        public Investment Investment { get; set; }

        public InterestMechanism(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }

        public InterestMechanism(Investment investment)
        {
            Investment = investment;
        }

        public abstract void Calculate();

        public virtual void SetInterestValue(decimal percent)
        {
            if(BankAccount != null )
            InterestValue = BankAccount.Balance * percent;
            else if(Investment != null)
                InterestValue = Investment.Value * percent;
            else
                InterestValue = 0;
        }
    }
}