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

            Console.WriteLine("Summ function:");
            Console.WriteLine($"3 + 2 = {calculator.Summ(3, 2)}");
            Console.WriteLine($"-2 - 4 = {calculator.Summ(-2, -4)}");
            Console.WriteLine($"0 + 0 = {calculator.Summ(0, 0)}");
            Console.WriteLine($"-5 + 5 = {calculator.Summ(-5, 5)}");
            Console.WriteLine();

            Console.WriteLine("Sub function:");
            Console.WriteLine($"3 - 2 = {calculator.Sub(3, 2)}");
            Console.WriteLine($"-2 - 4 = {calculator.Sub(-2, 4)}");
            Console.WriteLine($"0 - 0 = {calculator.Sub(0, 0)}");
            Console.WriteLine($"-5 - 5 = {calculator.Sub(-5, 5)}");
            Console.WriteLine();
          
            Console.WriteLine("Mul function:");
            Console.WriteLine($"3 * 2 = {calculator.Mul(3, 2)}");
            Console.WriteLine($"-2 * 4 = {calculator.Mul(-2, 4)}");
            Console.WriteLine($"0 * 0 = {calculator.Mul(0, 0)}");
            Console.WriteLine($"-5 * (-5) = {calculator.Mul(-5, -5)}");
            Console.WriteLine();

            Console.WriteLine("Div function:");
            Console.WriteLine($"3 / 2 = {calculator.Div(3, 2)}");
            Console.WriteLine($"-2 / 4 = {calculator.Div(-2, 4)}");
            Console.WriteLine($"0 / 0 = {calculator.Div(0, 0)}");
            Console.WriteLine($"-5 / 5 = {calculator.Div(-5, 5)}");
            Console.WriteLine();

            Console.WriteLine("Sqrt function:");
            Console.WriteLine($"sqrt(3) = {calculator.Sqrt(3)}");
            Console.WriteLine($"sqrt(-2) = {calculator.Sqrt(-2)}");
            Console.WriteLine($"sqrt(0) = {calculator.Sqrt(0)}");
            Console.WriteLine($"sqrt(16) = {calculator.Sqrt(16)}");
        }
    }
}
