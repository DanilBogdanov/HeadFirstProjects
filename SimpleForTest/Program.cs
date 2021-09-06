using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace SimpleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["one"] = 1;
            dictionary.Add("two", 2);
            int[] arr = new int [5];
            
            foreach (KeyValuePair<string, int> pair in dictionary) 
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
        }
    }
}