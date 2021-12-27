using System;
using System.Collections.Generic;
using Business.Operations;

namespace Business.Models
{
    public class ValueInput
    {
        public ValueInput(double value)
        {
            this.Value = value; //valor inicial
            this.Operations = new List<OperationBase>(); //lo instanciamos como 0 valor
        }

        public double Value { get; init; }

        private List<OperationBase> Operations { get; init; } //init: para que solo pueda ser asignado un valor en la construccion del objeto

        public void AddOperation(OperationBase op)
        {
            if (op == null)
            {
                throw new Exception("'op' no puede ser null.");
            }

            this.Operations.Add(op);
        }

        public List<OperationBase> GetOperations()
        {
            return this.Operations;
        }
    }
}


// 4
// +4
// /2
// *3

