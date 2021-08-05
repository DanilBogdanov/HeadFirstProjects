using System;
using System.Reflection;

namespace SimpleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new();
            B b = new();
            C.count = 2;
            B.count = 5;
            Console.WriteLine($"C.count={C.count}");
            Console.WriteLine($"B.count={B.count}");
        }
    }
}