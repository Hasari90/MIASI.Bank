using Bank.Base.Enum;
using Bank.Logic.CustomException;
using Bank.Model;
using System.Collections.Generic;

namespace Bank.Logic
{
    public class BankLogic
    {
        public Client CreateClient(Model.Bank bank, string firstname, string lastname, string pesel)
        {
            var client = new Client()
            {
                Bank = bank,
                Firstname = firstname,
                Lastname = lastname,
                PESEL = pesel
            };

            bank.ClientList.Add(client);

            return client;
        }

        public void CreateInterestSystem(Model.Bank bank, decimal percent, List<EProductType> productTypes)
        {
            bank.InterestList.Add(new Interest()
            {
                Bank = bank,
                Name = $"{percent}%",
                Percent = percent,
                DestinationProducts = productTypes,
            });
        }

        public void DeleteClient(Model.Bank bank, Client client)
        {
            var clientToDelete = bank.ClientList.Remove(client);
            if (!clientToDelete)
                throw new ClientDoesNotExistException();
        }
    }
}
