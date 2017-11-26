using Bank.Base.Enum;
using System;

namespace Bank.Model
{
    /// <summary>
    /// Operacje bankowe
    /// </summary>
    public class BankOperation
    {
        public string Description { get; set; }
        public EOperationType OperationType { get; set; }
        public DateTime RealizationDate { get; set; }
    }
}