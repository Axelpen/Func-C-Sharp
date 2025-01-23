using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Functional
{
    public class funcCalc
    {
        // Define basic operations using functional patterns
        public static Func<int, int, string> Add = (a, b) =>
            $"Result of {a} + {b} is {a + b}";

        public static Func<int, int, string> Subtract = (a, b) =>
            $"{a} - {b} is {a - b}";

        public static Func<int, int, string> Multiply = (a, b) =>
            $"{a} * {b} is {a * b}";

        public static Func<int, int, string> Divide = (a, b) =>
            b != 0 ? $"{a} / {b} is {a / b}" : "Cannot divide by zero";

        public static Func<int, int, int> Test = (a,b) => a+b;


    }
}