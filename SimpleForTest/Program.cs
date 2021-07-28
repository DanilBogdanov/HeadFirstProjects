using System;
using System.Reflection;

namespace SimpleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tst t1 = new(1);
            Tst t2 = new(2);

            FieldInfo[] fields = t1.GetType().GetFields(System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                Console.WriteLine(field.GetValue(t1));
            }
        }
    }
}