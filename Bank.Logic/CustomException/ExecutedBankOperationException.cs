using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.CustomException
{
    class ExecutedBankOperationException : Exception
    {
        public ExecutedBankOperationException()
            :base("Operacja bankowa już została wykonana.")
        {
        }
    }
}
