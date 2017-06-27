using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing.Imaging;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace CalculatorWebTestProject.Config
{
    [SetUpFixture]
    public abstract class CalculatorTest
    {

        public static IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Url = ConfigurationSettings.AppSettings["URL"];
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            Console.Write(title);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(120)); 
        }
        public void TakeScreenshot(IWebDriver driver, string saveLocation)
        {
            Random rd = new Random();
            int rand = rd.Next(1,78);
            ITakesScreenshot ss = driver as ITakesScreenshot;
            Screenshot screenshot = ss.GetScreenshot();
            screenshot.SaveAsFile(saveLocation+".png"+rand, ImageFormat.Png);
        }
        [TearDown]
        public void TestStop()
        {
            driver.Close();
        }
    }
}
