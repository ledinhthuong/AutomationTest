using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace CoreFrameWork
{
    public class DriverFactory
    {
        internal static IWebDriver Driver { get; set; }
        public static IDictionary<string, string> ChromeVersion = new Dictionary<string, string>(){
            {"112", @"C:\SeleniumAT\Chrome112"},
            {"113", @"C:\SeleniumAT\Chrome113"},
            {"114", @"C:\SeleniumAT\Chrome114"}
        };


        public static IWebDriver getWebDriver(string driverName, string driverPath) 
        {

            if (Driver == null)
            {
                {
                    switch (driverName.ToLower())
                    {
                        case "chrome":
                            Driver = new ChromeDriver();                        
                            break;

                        case "firefox":
                            Driver = new FirefoxDriver();
                            break;

                        case "Edge":
                            Driver = new EdgeDriver();
                            break;
                        default:
                            throw new NotSupportedException("the web browser is not supported!");

                    }
                }
            }
            Driver.Manage().Window.Maximize();
            return Driver;      
        }

        public static void TerminateWebDriver()
        {
            Driver.Close();
            Driver = null;
        }


    }
}
