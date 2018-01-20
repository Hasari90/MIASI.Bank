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
        public override void OnEntry(MethodExecutionArgs args)
        {
            var a = args.Arguments;
            double value = Convert.ToDouble(a[0]) * 0.01;
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
        }
    }
}
