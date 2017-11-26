using Bank.Base.Enum;
using System.Collections.Generic;

namespace Bank.Model
{
    /// <summary>
    /// Odsetki
    /// </summary>
    public class Interest
    {
        public Bank Bank { get; set; }
        public Credit Credit { get; set; }
        public Investment Investment { get; set; }
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public List<EProductType> DestinationProducts { get; set; }
    }
}