using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Model;
using Bank.Base.Enum;
using Bank.Logic.Report;

namespace Bank.Test
{
    [TestClass]
    public class ReportTest
    {
        [TestMethod]
        public void Report_SelectReportBySex_CheckFilterFemale()
        {
            Model.Bank bank = new Model.Bank();

            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));

            SelectReportBySex report = new SelectReportBySex(ESexType.Female);
            ISelectReportBySex reportStructure = new ReportStructure(bank, report);
            reportStructure.RunSelectReportBySex();

            Assert.AreEqual(4, report.ReportResult.Count);
        }

        [TestMethod]
        public void Report_SelectReportBySex_CheckFilterMale()
        {
            Model.Bank bank = new Model.Bank();

            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank, ESexType.Female));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));
            bank.ClientList.Add(CreateClient(bank));

            SelectReportBySex report = new SelectReportBySex(ESexType.Male);
            ISelectReportBySex reportStructure = new ReportStructure(bank, report);
            reportStructure.RunSelectReportBySex();

            Assert.AreEqual(7, report.ReportResult.Count);
        }

        [TestMethod]
        public void Report_SelectReportByAge_Between18And24()
        {
            Model.Bank bank = new Model.Bank();

            bank.ClientList.Add(CreateClient(bank, age: 12));
            bank.ClientList.Add(CreateClient(bank, age: 17));
            bank.ClientList.Add(CreateClient(bank, age: 18));
            bank.ClientList.Add(CreateClient(bank, age: 19));
            bank.ClientList.Add(CreateClient(bank, age: 20));
            bank.ClientList.Add(CreateClient(bank, age: 23));
            bank.ClientList.Add(CreateClient(bank, age: 24));
            bank.ClientList.Add(CreateClient(bank, age: 25));

            SelectReportByAge report = new SelectReportByAge(18, 24);
            ISelectReportByAge reportStructure = new ReportStructure(bank, report);
            reportStructure.RunSelectReportByAge();

            Assert.AreEqual(5, report.ReportResult.Count);
        }

        Client CreateClient(Model.Bank bank, ESexType sex = ESexType.Male, int age = 90)
        {
            return new Client()
            {
                Bank = bank,
                Firstname = $"Test{Guid.NewGuid()}",
                Lastname = $"Test{Guid.NewGuid()}",
                Sex = sex,
                Age = age
            };
        }
    }
}
