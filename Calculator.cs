using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public int Summ(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mul(int a, int b) {return a * b; }
        public double Div(int a, int b) 
        {
            try
            {
                return (double)a / b;
            }
            catch (DivideByZeroException)
            {
                return double.PositiveInfinity;
            }
        }
    }
}
