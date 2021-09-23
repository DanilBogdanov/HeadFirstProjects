using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace SimpleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aInt = { 1, 2, 3, 4 };
            int[] bInt = { 1, 5, 6, 4 };
            

            Person[] persons = { new Person() { Name = "A", Age = 10 },
                new Person() {Name = "B", Age = 20 } };

            var item = from u in persons
                       orderby u.Name descending, u.Age descending
                       select u;
            //printCol(item);
            //Console.WriteLine("--------");
            var i = persons.OrderBy(u => u.Name);
            //printCol(i);
            //Console.WriteLine("--------");
            //printCol(aInt.Except(bInt));
            Console.WriteLine(persons.Max(u => u.Age));
        }

        private static void printCol(System.Collections.IEnumerable en)
        {
            foreach (var item in en)
            {
                Console.WriteLine(item);
            }
        }
    }
}