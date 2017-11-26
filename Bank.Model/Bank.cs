using System.Collections.Generic;

namespace Bank.Model
{
    public class Bank
    {
        public Bank()
        {
            ClientList = new List<Client>();
            InterestList = new List<Interest>();
        }

        public string Name { get; set; }
        public List<Client> ClientList { get; set; }
        public List<Interest> InterestList { get; set; }
    }
}