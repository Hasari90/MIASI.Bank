using Bank.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    /// <summary>
    /// Odsetki
    /// </summary>
    public class Interest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public List<EProductType> DestinationProducts { get; set; }
    }
}
