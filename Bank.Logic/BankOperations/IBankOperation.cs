using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.BankOperations
{
    public interface IBankOperation
    {
        void ExecuteOperation();

        BankAccount BankAccount { get; set; }
        bool IsExecuted { get; set; }
    }
}
