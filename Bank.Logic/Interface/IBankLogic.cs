using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Logic.Interface
{
    public interface IBankLogic
    {
        Client CreateClient(Model.Bank bank, string firstname, string lastname, string pesel);
        void DeleteClient(Model.Bank bank, Client client);

        void CreateInterestSystem(Model.Bank bank, decimal percent, List<Model.Enum.EProductType> productTypes);

    }
}
