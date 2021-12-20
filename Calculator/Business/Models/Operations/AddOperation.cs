using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public class AddOperation : BasicOperation
    {
        public AddOperation()
        {

        }
        public override double CalculateResult(double val1, double val2)
        {
            return val1 + val2;
        }
    }
}
