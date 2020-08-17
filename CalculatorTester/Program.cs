using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 6);
            if (result != 5)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
