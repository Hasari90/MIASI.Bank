using PostSharp.Aspects;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAspect
{
    [Serializable]
    [MulticastAttributeUsage(PersistMetaData = true)]
    public class Aspect : OnMethodBoundaryAspect
    {
        private double commission;

        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var a = args.Arguments;
            Commission += Convert.ToDouble(a[0]) * 0.01;
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Commission sum value: " + Commission.ToString());
            base.OnExit(args);
        }
    }
}
