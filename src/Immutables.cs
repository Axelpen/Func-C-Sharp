using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;


namespace FuncProgramming.src

{
    internal class Immutable
    {
        static ImmutableList<string> test = ImmutableList.Create("Red", "Green");
        public static void printList()
        {
            Console.WriteLine(string.Join(", ", test));
        }
    }
}
