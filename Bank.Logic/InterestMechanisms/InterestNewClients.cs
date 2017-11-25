using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.Logic.InterestMechanisms
{
    public class InterestNewClients : InterestMechanism
    {
        public InterestNewClients(BankAccount ba)
            :base(ba)
        {
                
        }

        public override void Calculate()
        {
            if(BankAccount.Balance > 10000)
                SetInterestValue(0.04m);
            else if(BankAccount.Balance <= 10000 && BankAccount.Balance > 2000)
                SetInterestValue(0.03m);
            else
                SetInterestValue(0.02m);
        }
    }
}
