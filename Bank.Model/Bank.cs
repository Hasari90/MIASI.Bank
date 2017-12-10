using System.Collections.Generic;

namespace Bank.Model
{
    public class Bank
    {
        public Bank()
        {
            if(ClientList == null)
                ClientList = new List<Client>();
            if(InterestList == null)
                InterestList = new List<Interest>();
        }

        public string Name { get; set; }
        public List<Client> ClientList { get; set; }
        public List<Interest> InterestList { get; set; }


    }
}