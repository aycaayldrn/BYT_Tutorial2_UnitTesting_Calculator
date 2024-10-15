using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2_s26735_Part2
{
    public class Calculator
    {
        public double Var1 { get; private set; }
        public double Var2 { get; private set; }
        public char Operation { get; private set; }

        public Calculator(double var1, double var2, char operation)
        {
            Var1 = var1;
            Var2 = var2;
            Operation = operation;
        }


        public double Calculation()
        {
            switch (Operation)
            {
                case '+':
                    return Var1 + Var2;
                case '-':
                    return Var1 - Var2;
                case '*':
                    return Var1 * Var2;
                case '/':
                    if (Var2 == 0) { throw new DivideByZeroException("Cannot devide by zero"); }
                    return Var1 / Var2;
                default: throw new InvalidOperationException("Invalid operation");
            }
        }

    }
}
