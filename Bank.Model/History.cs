using Bank.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    /// <summary>
    /// Historia
    /// </summary>
    public class History
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int ObjectID { get; set; }
        public EHstoryType ObjectType { get; set; }
    }
}
