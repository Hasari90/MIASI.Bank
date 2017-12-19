using Bank.Base.Decorator;
using System;

namespace Bank.Model
{
    public class Credit: IWithdrawMoneyOperation
    {
        public BankAccount BankAccount { get; set; }
        public Interest Interest { get; set; }
        public int InstallmentValue { get; set; }
        public decimal InterestValue { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime PlannedDateTo { get; set; }

        public decimal BorrowedValue { get; set; }

        public void WithdrawMoneyFromAccount(decimal amount)
        {
            if(BorrowedValue >= amount)
                BorrowedValue -= amount;
            else
            {
                var amountRemained = amount - BorrowedValue;
                BorrowedValue = 0m;

                BankAccount.WithdrawMoneyFromAccount(amountRemained);
            }

        }
    }
}