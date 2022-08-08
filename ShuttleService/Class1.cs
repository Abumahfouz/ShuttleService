using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuttleService
{
    internal class AbstractImp : OurProcedure.AccidentSafeguard
    {
        public override bool SafeguardMeasure()
        {
            return true;
        }
    }

}
