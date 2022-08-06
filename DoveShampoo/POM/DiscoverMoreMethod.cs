using DoveShampoo.Drivers;
using DoveShampoo.Utility;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DoveShampoo.POM
{
    public class DiscoverMoreMethod
    {
        public static IJavaScriptExecutor js;

        public static void NavigateURL()
        {
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Navigate().GoToUrl(ExcelSheet.excelRead(1, 1));
            LogFourNet.log.Info("URL open in Browser");
        }

        public static void ScrollDownToLetsStopTheBeautyTest()
        {
            js = (IJavaScriptExecutor)DriverClass.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverClass.driver.FindElement(By.XPath("//h1[contains(text(),'Welcome to Dove...')]")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to LetsStopTheBeautyTest section");
        }

        public static void ClickOnDiscoverMore()
        {
            DriverClass.driver.FindElement(By.XPath("//a[contains(text(),'Discover more')]")).Click();
            LogFourNet.log.Info("Click on the Discover More");
        }
       
        public static void ScrollToTheRealWomenbehindStopTheBeautyTest()
        {
            js = (IJavaScriptExecutor)DriverClass.driver;
            Thread.Sleep(2000);
            int locationY_OfElement = DriverClass.driver.FindElement(By.XPath("//h2[contains(text(),'The Real Women behind #StopTheBeautyTest')]")).Location.Y;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0, " + locationY_OfElement + ")");
            LogFourNet.log.Info("Scroll to The Real Women behind #StopTheBeautyTest");
        }

        public static void verifyText()
        {
            string text = DriverClass.driver.FindElement(By.XPath("//h2[contains(text(),'The Real Women behind #StopTheBeautyTest')]")).Text;
            Thread.Sleep(1000);
            Assert.That(text, Is.EqualTo("The Real Women behind #StopTheBeautyTest"));
            LogFourNet.log.Info("Very the text The Real Women behind #StopTheBeautyTest");
        }

        public static void TakeScreenShot()
        {
            Thread.Sleep(1000);
            ScreenShot.TakeScreenshot("TheReaWomenbehindStopTheBeautyTest");
            LogFourNet.log.Info("Takes Screenshot of screen");
        }
    }
}
