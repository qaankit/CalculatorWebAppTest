using CalculatorWebTestProject.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CalculatorWebTestProject.Pages
{
    public class WhiteBoxPage : BaseSuite
    {
        public WhiteBoxPage(IWebDriver driver)
            : base(driver)
        {
            // TODO: Complete member initialization
        }

            [FindsBy(How = How.CssSelector, Using = "#txtbx_first_no")]
            public IWebElement enterFirstText { get; set; }

            [FindsBy(How = How.CssSelector, Using = "#txtbx_second_no")]
            public IWebElement entersecondText { get; set; }

            [FindsBy(How = How.Name, Using = "#btn_Add")]
            public IWebElement clickLogin { get; set; }
    }
  
    
}
