using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Interface
{
    public interface IClientLogic
    {
        BankAccount CreateBankAccount(Client sourceClient);
        void CloseBankAccount(BankAccount bankAccount);
    }
}
