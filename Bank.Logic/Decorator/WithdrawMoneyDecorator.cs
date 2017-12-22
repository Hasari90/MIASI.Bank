using Bank.Base.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Decorator
{
    public class WithdrawMoneyDecorator : IWithdrawMoneyOperation
    {
        IWithdrawMoneyOperation _model;

        public WithdrawMoneyDecorator(IWithdrawMoneyOperation model)
        {
            _model = model;
        }

        public void WithdrawMoneyFromAccount(decimal amount)
        {
            _model.WithdrawMoneyFromAccount(amount);
        }
    }
}
