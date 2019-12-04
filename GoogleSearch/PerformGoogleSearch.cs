using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace GoogleSearch
{
    [TestClass]
    public class PerformGoogleSearch
    {
        [Test]
        public void MySearch()
        {
            //Create the reference for our browser
            IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = base(driver);
            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");
            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));
            //Perform Ops
            element.SendKeys("Hello");
            element.FindElement(By.XPath("//div[@class='FPdoLc VlcLAe']//input[@name='btnK']")).Click();
            //Close the browser
            Thread.Sleep(5000);
            driver.Close();

        }
    }
}
