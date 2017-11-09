using Bank.Model.Enum;
using Bank.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    /// <summary>
    /// Operacje bankowe
    /// </summary>
    public class BankOperation
    {
        public int ID { get; set; }
        public int BankAccountID { get; set; }
        public string Description { get; set; }
        public EOperationType OperationType { get; set; }
        public DateTime RealizationDate { get; set; }
    }
}
