using System;

namespace Bank.Model
{
    /// <summary>
    /// Lokata
    /// </summary>
    public class Investment
    {
        public BankAccount BankAccount { get; set; }
        public InterestMechanism interestMechanism { get; set; }
        public decimal Value { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}