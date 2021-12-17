using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace ErturkeskiturkTestinium

{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            string link = @"https://www.beymen.com/";
            driver.Navigate().GoToUrl(link);


            driver.FindElement(By.ClassName("-customer")).Click();
            driver.FindElement(By.ClassName("-favorite")).Click();
            driver.FindElement(By.ClassName("-cart")).Click();
            driver.FindElement(By.ClassName("m-empty__messageBtn")).Click();


            driver.FindElement(By.ClassName("default-input")).SendKeys("pantolan");
            driver.FindElement(By.ClassName("bmi-search")).Click();


            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,6900);");


            IWebElement element = driver.FindElement(By.Id("moreContentButton"));
            System.Threading.Thread.Sleep(5000);
            element.Click();


            IWebElement element2 = driver.FindElement(By.ClassName("o-productList__item"));
            System.Threading.Thread.Sleep(5000);
            element2.Click();


            driver.FindElement(By.XPath("//*[@id=\"sizes\"]/div/span[1]")).Click();


            IWebElement element3 = driver.FindElement(By.Id("addBasket"));
            System.Threading.Thread.Sleep(5000);
            element3.Click();


            driver.FindElement(By.ClassName("-cart")).Click();


            IWebElement element4 = driver.FindElement(By.Id("removeCartItemBtn0"));
            System.Threading.Thread.Sleep(5000);
            element4.Click();

            
            Console.Read();





        }
    }
}
