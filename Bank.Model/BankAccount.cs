using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    /// <summary>
    /// Rachunek bankowy
    /// </summary>
    public class BankAccount
    {
        public int ID { get; set; }

        public bool IsDebit { get; set; }
        public decimal MaxDebitBalance { get; set; }
        public int ClientID { get; set; }
        public string Number { get; set; }
        public IEnumerable<History> HistoryList { get; set; }
        public decimal Balance { get; set; }
        public InterestMechanism interestMechanism { get; set; }

    }
}
