using System;
using System.Collections.Generic;
using System.Text;

namespace StringMaxMin
{
    static class Print
    {
        public static void PrintCollection( this List<string> a)
        {
            a.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }
    }
}
