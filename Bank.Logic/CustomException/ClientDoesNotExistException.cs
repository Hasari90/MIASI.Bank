using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.CustomException
{
    public class ClientDoesNotExistException: Exception
    {
        public ClientDoesNotExistException()
            :base("Dany klient już nie istnieje w bazie.")
        {

        }
    }
}
