using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    /// <summary>
    /// Lokata
    /// </summary>
    public class Investment
    {
        public int ID { get; set; }
        public int BankAccountID { get; set; }
        public int InterestID { get; set; }
        public decimal Value { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
}
