using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Client> ClientList { get; set; }
        public List<Interest> InterestList { get; set; }
    }
}
