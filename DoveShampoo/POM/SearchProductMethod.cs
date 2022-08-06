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
    public class SearchProductMethod
    {
        public static void NavigateURL()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in Browser");
        }

        public static void ClickOnSearch()
        {
            Thread.Sleep(2000);
            DriverClass.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
            LogFourNet.log.Info("Click on the search bar");
        }

        public static void SearchProduct()
        {
            Thread.Sleep(2000);
         //input[@class='c-global-search__textbox form-control typeahead tt-input']
            IWebElement product = DriverClass.driver.FindElement(By.XPath("//*[@id='globalSearch']/div[2]/div/span/input"));
            product.SendKeys(ExcelSheet.excelRead(2,1));
            product.SendKeys(Keys.Enter);
            LogFourNet.log.Info("Enter search product in search bar");
        }

        public static void verifyText()
        {
            Thread.Sleep(5000);
            string text = DriverClass.driver.FindElement(By.XPath("//h2[contains(text(),'Baby Shampoo')]")).Text;
            Thread.Sleep(1000);
            Assert.That(text, Is.EqualTo("Baby Shampoo"));
            LogFourNet.log.Info("Verify the text");
        } 

        public static void TakeScreenShot()
        {
            Thread.Sleep(1000);
            ScreenShot.TakeScreenshot("Search Product");
            LogFourNet.log.Info("Takes Screenshot of screen");
        }
    }
}
