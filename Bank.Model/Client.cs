using Bank.Base.Enum;
using System.Collections.Generic;

namespace Bank.Model
{
    public class Client
    {
        public Bank Bank { get; set; }
        public List<BankAccount> BankAccountList { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PESEL { get; set; }
        public ESexType Sex { get; set; }
    }
}