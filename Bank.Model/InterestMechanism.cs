using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public abstract class InterestMechanism
    {
        public decimal InterestValue { get; set; }
        public BankAccount BankAccount { get; set; }

        public InterestMechanism(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }

        public abstract void Calculate();

        public virtual void SetInterestValue(decimal percent)
        {
            InterestValue = BankAccount.Balance * percent;
        }
    }
}
