using FuncProgramming.src;

Console.WriteLine("Hello, World!");
funcCalcCall(5, 7);
immutListCall();
static void funcCalcCall(int a, int b)
{
    Console.WriteLine(FuncCalc.Add(5, 3));
    Console.WriteLine(FuncCalc.Subtract(5, 3));
    Console.WriteLine(FuncCalc.Multiply(5, 3));
    Console.WriteLine(FuncCalc.Divide(5, 5));
    Console.WriteLine(FuncCalc.Test(int.Parse(Console.ReadLine() ?? "0"), 5));
}

static void immutListCall()
{
    Immutable.printList();
}
