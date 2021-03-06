﻿using Bank.Base.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;
using Bank.Base.Enum;

namespace Bank.Logic.Report
{
    public class ReportStructure: ISelectReportBySex, ISelectReportByAge, ISelectReportByBalance
    {
        public Model.Bank Bank { get; set; }
        public IVisitor ConcreteRaport { get; set; }

        public ReportStructure(Model.Bank bank, IVisitor concreteRaport)
        {
            Bank = bank;
            ConcreteRaport = concreteRaport;
        }

        public void RunSelectReportBySex()
        {
            foreach (var client in Bank.ClientList)
            {
                ConcreteRaport.Visit(client);
            }
        }

        public void RunSelectReportByAge()
        {
            foreach (var client in Bank.ClientList)
            {
                ConcreteRaport.Visit(client);
            }
        }

        public void RunSelectReportByAmount()
        {
            var accountList = Bank.ClientList.SelectMany(x => x.BankAccountList);

            foreach (var account in accountList)
            {
                ConcreteRaport.Visit(account);
            }
        }
    }
}
