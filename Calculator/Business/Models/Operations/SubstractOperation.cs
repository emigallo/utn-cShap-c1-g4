using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public class SubstractOperation : BasicOperation
    {
        public SubstractOperation()
        {

        }

        public override double CalculateResult(double val1, double val2)
        {
            return val1 - val2;
        }
    }
}
