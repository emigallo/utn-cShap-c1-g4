using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public abstract class BasicOperation
    {
        public BasicOperation()
        {
        }

        public abstract double CalculateResult(double val1, double val2);



    }
}
