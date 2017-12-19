using Bank.Base.Enum;
using Bank.Base.Visitor;
using System;
using System.Collections.Generic;

namespace Bank.Model
{
    public class Client: Element
    {
        public Client()
        {
            BankAccountList = new List<BankAccount>();
        }

        public Bank Bank { get; set; }
        public List<BankAccount> BankAccountList { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PESEL { get; set; }
        public int Age { get; set; }
        public ESexType Sex { get; set; }

        public override void Accept(IVisitor visitor)
            => visitor.Visit(this);
    }
}