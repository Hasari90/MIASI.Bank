using System;

namespace Bank.Model
{
    public class Credit
    {
        public BankAccount BankAccount { get; set; }
        public Interest Interest { get; set; }
        public decimal BorrowedValue { get; set; }
        public int InstallmentValue { get; set; }
        public decimal InterestValue { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime PlannedDateTo { get; set; }
    }
}