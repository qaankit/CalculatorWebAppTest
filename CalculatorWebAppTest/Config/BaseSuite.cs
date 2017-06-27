using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CalculatorWebTestProject.Config
{
    public class BaseSuite
    {
        protected IWebDriver driver;
        public BaseSuite(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Boolean isElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void waitForElement(By by)
        {
            for (int sec = 1; sec <= 10; sec++)
            {
                try
                {
                    if (driver.FindElement(by).Displayed)
                    {
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception e)
                {

                }
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {

                }
            }
            //analyze browser logs
            Console.Write("Debug Log : waitForElementDisplayed method : Element not displayed.");
        }
        public void waitForAlert()
        {
            int i = 0;
            while (i++ < 10)
            {
                try
                {
                    driver.SwitchTo().Alert();
                    break;
                }
                catch (NoAlertPresentException e)
                {
                    Thread.Sleep(1000);
                    continue;
                }
            }
        }
        public void navigateBack()
        {
            driver.Navigate().Back();
        }
    }
}