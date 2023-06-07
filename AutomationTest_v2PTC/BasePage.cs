using CoreFrameWork;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestFixture]
    class BasePage
    {
        public static IWebDriver driver = DriverFactory.getWebDriver("chrome", DriverFactory.ChromeVersion["114"]);

        [SetUp]
        public static void Setup()
        {
        }


        [TearDown]
        public static void TearDown()
        {
            DriverFactory.TerminateWebDriver();
        }
    }
}

