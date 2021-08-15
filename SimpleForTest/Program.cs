using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;


namespace SimpleForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bagira-ufa.ru/");
        }
    }
}