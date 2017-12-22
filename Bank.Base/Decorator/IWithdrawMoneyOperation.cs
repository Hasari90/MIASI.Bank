using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Base.Decorator
{
    public interface IWithdrawMoneyOperation
    {
        void WithdrawMoneyFromAccount(decimal amount);
    }
}
