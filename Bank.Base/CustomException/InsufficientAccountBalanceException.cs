using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Base.CustomException
{
    public class InsufficientAccountBalanceException: Exception
    {
        public InsufficientAccountBalanceException()
            :base("Niewystarczające saldo na koncie.")
        {

        }
    }
}
