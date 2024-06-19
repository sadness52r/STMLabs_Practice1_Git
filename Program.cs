using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"3 + 2 = {calculator.Summ(3, 2)}");
            Console.WriteLine($"-2 - 4 = {calculator.Summ(-2, -4)}");
            Console.WriteLine($"0 + 0 = {calculator.Summ(0, 0)}");
            Console.WriteLine($"-5 + 5 = {calculator.Summ(-5, 5)}");
        }
    }
}
