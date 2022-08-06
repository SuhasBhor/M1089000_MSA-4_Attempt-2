using DoveShampoo.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoveShampoo.Utility
{
    public class ScreenShot
    {
        public static void TakeScreenshot(string screenShotName)
        {
            ((ITakesScreenshot)DriverClass.driver).GetScreenshot()
                .SaveAsFile(@"C:\Users\mindc1may35\Desktop\DoveShampoo\Screenshot\" + screenShotName + ".Png");
        }
    }
}
