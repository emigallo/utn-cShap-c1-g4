using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public class DivideOperation : BasicOperation
    {
        public DivideOperation()
        {

        }

        public override double CalculateResult(double val1, double val2)
        {
            if (val2 == 0)
            {
                throw new Exception("No se puede dividir por 0");
            }

            return val1 / val2;
        }
    }
}
