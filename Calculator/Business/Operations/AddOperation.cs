namespace Business.Operations
{
    public class AddOperation : OperationBase
    {
        public AddOperation(double value) : base("+", value) //le pasamos al contructor
        {

        }

        public override double CalculateResult(double input1)
        {
            return input1 + base.Value; //con el base estamos accediendo al value del padre
        }

        public override string GetInput()
        {
            return base.Value.ToString("F2");
        }
    }
}