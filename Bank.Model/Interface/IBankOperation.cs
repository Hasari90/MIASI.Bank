using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model.Interface
{
    public interface IBankOperation
    {
        void ExecuteOperation();

        BankAccount BankAccount { get; set; }
        bool IsExecuted { get; set; }
    }
}
