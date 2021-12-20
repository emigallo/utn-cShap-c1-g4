using Business.Models.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
     public class Calculator
    {
        public Calculator()
        {

        }

        public double Do (double val1, double val2, BasicOperation bo)
        {
            return bo.CalculateResult(val1, val2);
        }




    }
}
