using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class Credit
    {
        public int ID { get; set; }
        public int BankAccountID { get; set; }
        public decimal BorrowedValue { get; set; }
        public int InstallmentValue { get; set; }
        public decimal InterestValue { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime PlannedDateTo { get; set; }
        public int InterestID { get; set; }

    }
}
