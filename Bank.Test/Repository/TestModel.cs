using Bank.Repository.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Test.Repository
{
    public class TestModel : IId<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
