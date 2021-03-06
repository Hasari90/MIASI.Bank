﻿using Bank.Base.CustomException;
using Bank.Base.Decorator;
using Bank.Base.Visitor;
using System.Collections.Generic;

namespace Bank.Model
{
    /// <summary>
    /// Rachunek bankowy
    /// </summary>
    public class BankAccount: Element, IWithdrawMoneyOperation
    {
        public BankAccount()
        {
            CreditList = new List<Credit>();
            HistoryList = new List<History>();
        }

        public Client Client { get; set; }
        public bool IsDebit { get; set; }
        public decimal MaxDebitBalance { get; set; }
        public string Number { get; set; }
        public List<History> HistoryList { get; set; }
        public InterestMechanism interestMechanism { get; set; }
        public List<Credit> CreditList { get; set; }
        public decimal Balance { get; set; }

        public override void Accept(IVisitor visitor)
            => visitor.Visit(this);

        public void WithdrawMoneyFromAccount(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
            else
                throw new InsufficientAccountBalanceException();
        }
    }
}