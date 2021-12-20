using Business.Models;
using Business.Models.Operations;
using System;


    class Program
    {
        public static void Main (string [] args)
        {

            Calculator calc = new Calculator();

            Console.WriteLine(calc.Do(1, 1, new AddOperation()));
            Console.WriteLine(calc.Do(1, 1, new DivideOperation()));
            Console.WriteLine(calc.Do(1, 1, new MultiplyOperation()));
            Console.WriteLine(calc.Do(1, 1, new SubstractOperation()));
    }
    }
