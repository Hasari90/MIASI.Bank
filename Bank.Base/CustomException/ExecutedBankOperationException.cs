using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Base.CustomException
{
    public class ExecutedBankOperationException : Exception
    {
        public ExecutedBankOperationException()
            :base("Operacja bankowa już została wykonana.")
        {
        }
    }
}
