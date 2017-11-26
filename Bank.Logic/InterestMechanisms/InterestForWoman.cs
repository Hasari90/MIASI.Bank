using Bank.Base.Enum;
using Bank.Model;

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

            if(client.Sex == ESexType.Female)
                SetInterestValue(0.05m);
            else
                SetInterestValue(0.01m);

        }
    }
}
