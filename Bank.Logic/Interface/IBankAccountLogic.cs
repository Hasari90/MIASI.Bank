using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Interface
{
    public interface IBankAccountLogic
    {
        Investment CreateInvestment();
        void DeleteInvestment(Investment investment);

        Credit CreateCredit();
        void DeleteCredit(Credit credit);
    }
}
