using DoveShampoo.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoveShampoo.Drivers
{
    public class DriverClass
    {
        public static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            LogFourNet.log.Info("Driver gets Initialize");
        }

        public static void CloseDriver()
        {
            driver.Close();
            LogFourNet.log.Info("Driver gets Closed");
        }
    }
}
