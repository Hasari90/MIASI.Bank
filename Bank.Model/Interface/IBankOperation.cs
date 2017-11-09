using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.Interface
{
    public interface IBankOperation
    {
        void Deposit();
        void Withdraw();
        void CreateInvestment();
        void BorrowMoney(decimal moneyToBorrow);
        void CreateDebit();
    }
}
