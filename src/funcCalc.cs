
namespace FuncProgramming.src
{
    public class FuncCalc
    {
        public static Func<int, int, string> Multiply = (a, b) =>
            $"{a} * {b} is {a * b}";

        public static Func<int, int, string> Divide = (a, b) =>
            b != 0 ? $"{a} / {b} is {a / b}" : "Cannot divide by zero";

        public static Func<int, int, int> Test = (a, b) => a + b;

        public static Func<int, int, string> Add { get; set; } = (a, b) =>
            $"Result of {a} + {b} is {a + b}";
        public static Func<int, int, string> Subtract { get; set; } = (a, b) =>
            $"{a} - {b} is {a - b}";
    }
}
