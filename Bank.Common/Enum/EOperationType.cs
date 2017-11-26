using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Common.Enum
{
    public enum EOperationType
    {
        Withdraw,
        Deposit,
        Payment,
        AccruedInterest,
        ChangeInterestSystem,
        CreateInvestment,
        RemoveInvestment,
        TakeCredit,
        RepaymentCredit,
        CreateDebit,
        CreateRaport
    }
}
