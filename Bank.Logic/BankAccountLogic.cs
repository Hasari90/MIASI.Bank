using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic
{
    public class BankAccountLogic
    {
        public decimal Calculate(Model.BankAccount bankAccount)
        {
            bankAccount.interestMechanism.Calculate();
            return bankAccount.interestMechanism.InterestValue;
        }
    }
}
