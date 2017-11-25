using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.InterestMechanisms
{
    public class InterestForWoman : InterestMechanism
    {
        public InterestForWoman(BankAccount bankAccount) : base(bankAccount)
        {
        }

        public override void Calculate()
        {
            Client client = new Client();
            //client = 
            //bankAccount.ClientID

            if(client.Sex == Model.Enum.ESexType.Female)
                SetInterestValue(0.05m);
            else
                SetInterestValue(0.01m);

        }
    }
}
