using Bank.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;
using Bank.Logic.CustomException;

namespace Bank.Logic
{
    public class BankLogic : IBankLogic
    {
        public Client CreateClient(Model.Bank bank, string firstname, string lastname, string pesel)
        {
            var client = new Client()
            {
                ID = bank.ClientList.Count(),
                Firstname = firstname,
                Lastname = lastname,
                PESEL = pesel
            };

            bank.ClientList.Add(client);

            return client;
        }

        public void CreateInterestSystem(Model.Bank bank, decimal percent, List<Model.Enum.EProductType> productTypes)
        {
            bank.InterestList.Add(new Interest()
            {
                ID = bank.InterestList.Count(),
                Name = $"{percent}%",
                Percent = percent,
                DestinationProducts = productTypes,
            });
        }

        public void DeleteClient(Model.Bank bank, Client client)
        {
            var clientToDelete = bank.ClientList.Where(x => x.ID == client.ID).SingleOrDefault();
            if (clientToDelete != null)
                bank.ClientList.RemoveAt(bank.ClientList.IndexOf(clientToDelete));
            else
                throw new ClientDoesNotExistException();
        }
    }
}
