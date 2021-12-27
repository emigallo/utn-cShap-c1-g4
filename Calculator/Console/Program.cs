using Business.Models;
using Business.Operations;
using Business.Utils;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();
          

            calc.Add(4);
            OperationBase add = new AddOperation(3.3);
            calc.Add(add);

            OperationBase mult = new MultiplyOperation(2.4);
            calc.Add(mult);

            System.Console.WriteLine("La entrada fue: " + calc.GetInputs());

            double result = calc.Do();
            System.Console.WriteLine("El rdo es: " + result);

            calc.Copy();

            System.Console.WriteLine("Contains " + calc.ContainsOperation(new MultiplyOperation(2.4)));

            
            System.Console.WriteLine("Las operaciones de suma fueron: " + calc.GetOnlyAddOperationInputs());
        }

        //private static double CalculateResultAndShowInConsole(double val1, double val2, OperationBase op)
        //{
        //    //Calculator calc = new Calculator();

        //    //double result = calc.CalculateResult(val1, val2, op);
        //    //System.Console.WriteLine(result);

        //    //return result;
        //}
    }
}