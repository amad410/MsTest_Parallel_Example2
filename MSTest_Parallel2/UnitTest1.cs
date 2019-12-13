using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MSTest_Parallel2
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.espn.com");
        }

        [TestMethod]
        public void TestMethod2()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }


    }
}
