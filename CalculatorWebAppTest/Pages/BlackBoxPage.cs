using CalculatorWebTestProject.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CalculatorWebTestProject
{
    public class BlackBoxPage : BaseSuite
    {
        public BlackBoxPage(IWebDriver driver)
            : base(driver)
        {
            // TODO: Complete member initialization
            
        }

        [FindsBy(How = How.CssSelector, Using = "#txtbx_first_no")]
        public IWebElement enterFirstText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#txtbx_second_no")]
        public IWebElement entersecondText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_Add")]
        public IWebElement clickAddButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_Substract")]
        public IWebElement clickSubtractButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_Multiply")]
        public IWebElement clickMultiplyButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btn_divide")]
        public IWebElement clickDivideButton { get; set; }

        public Boolean verifyResult(String totalResult)
        {
            string actualValue = driver.FindElement(By.CssSelector("#txtbx_result")).GetAttribute("value");
            decimal value = Convert.ToDecimal(actualValue);
            decimal truncate = TruncateDecimal(value, 2);
            string truncValue = Convert.ToString(truncate);
            string expectedValue = totalResult;
            if (expectedValue.Equals(truncValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}
