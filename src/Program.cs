using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace Functional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            funcCalcCall(5, 7);


        }
        private static void funcCalcCall(int a, int b)
        {
            Console.WriteLine(funcCalc.Add(5, 3));
            Console.WriteLine(funcCalc.Subtract(5, 3));
            Console.WriteLine(funcCalc.Multiply(5, 3));
            Console.WriteLine(funcCalc.Divide(5, 5));
            Console.WriteLine(funcCalc.Test(int.Parse(Console.ReadLine() ?? "0"), 5));
        }

    }
}
