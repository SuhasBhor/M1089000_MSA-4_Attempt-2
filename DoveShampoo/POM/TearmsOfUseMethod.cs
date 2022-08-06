using DoveShampoo.Drivers;
using DoveShampoo.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoveShampoo.POM
{
    public class TearmsOfUseMethod
    {
        public static IJavaScriptExecutor js;

        public static void NavigateURL()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in Browser");
        }

        public static void ScrollDownToFooter()
        {
            js = (IJavaScriptExecutor)DriverClass.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverClass.driver.FindElement(By.XPath("//a[contains(text(),'Terms of use')]")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to Footer");
        }

        public static void ClickOnTearmsOfUse()
        {
            DriverClass.driver.FindElement(By.XPath("//a[contains(text(),'Terms of use')]")).Click();
        }
       
        public static void verifyText()
        {
            string text = DriverClass.driver.FindElement(By.XPath("//b[contains(text(),'2. Prohibited Uses')]")).Text;
            Thread.Sleep(1000);
            Assert.That(text, Is.EqualTo("2. Prohibited Uses"));
            LogFourNet.log.Info("Verify the text Prohibited Uses");
        }

        public static void TakeScreenShot()
        {
            Thread.Sleep(1000);
            ScreenShot.TakeScreenshot("Prohibited Uses");
            LogFourNet.log.Info("Takes Screenshot of screen");
        }
    }
}
