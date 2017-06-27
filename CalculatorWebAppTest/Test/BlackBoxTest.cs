using CalculatorWebTestProject.Config;
using CalculatorWebTestProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace CalculatorWebTestProject
{
    [TestFixture]
    class TestClass : CalculatorTest
    {
        String Value1 = "567";
        String Value2 = "123";

        [Test, Order(1)]
        public void AddTest()
        {
             var blackBoxPage = new BlackBoxPage(driver);
             PageFactory.InitElements(driver, blackBoxPage);
             blackBoxPage.enterFirstText.SendKeys(Value1);
             Console.Write("Enter First Number [" + Value1 + "]");
             blackBoxPage.entersecondText.SendKeys(Value2);
             Console.Write("Enter second Number [" + Value2 + "]");
             int totalResult = int.Parse(Value1) + int.Parse(Value2);
             String result = Convert.ToString(totalResult);
             blackBoxPage.clickAddButton.Click();
             Console.Write("Click on [Add] button");
             Thread.Sleep(TimeSpan.FromSeconds(4));
             Assert.IsTrue(blackBoxPage.verifyResult(result), "Result not matched");
             Console.Write("Verify Result passed");
        }

        [Test, Order(2)]
        public void SubtractTest()
        {
            var blackBoxPage = new BlackBoxPage(driver);
            PageFactory.InitElements(driver, blackBoxPage);
            blackBoxPage.enterFirstText.SendKeys(Value1);
            Console.Write("Enter First Number ["+Value1+"]");
            blackBoxPage.entersecondText.SendKeys(Value2);
            Console.Write("Enter second Number [" + Value2 + "]");
            int totalResult = int.Parse(Value1) - int.Parse(Value2);
            String result = Convert.ToString(totalResult);
            blackBoxPage.clickSubtractButton.Click();
            Console.Write("Click on [Subtract] button");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.IsTrue(blackBoxPage.verifyResult(result), "Result not matched");
            Console.Write("Verify Result passed");
        }

        [Test, Order(3)]
        public void MultiplyTest()
        {
            var blackBoxPage = new BlackBoxPage(driver);
            PageFactory.InitElements(driver, blackBoxPage);
            blackBoxPage.enterFirstText.SendKeys(Value1);
            Console.Write("Enter First Number [" + Value1 + "]");
            blackBoxPage.entersecondText.SendKeys(Value2);
            Console.Write("Enter second Number [" + Value2 + "]");
            int totalResult = int.Parse(Value1) * int.Parse(Value2);
            String result = Convert.ToString(totalResult);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            blackBoxPage.clickMultiplyButton.Click();
            Console.Write("Click on [Multiply] button");
            Assert.IsTrue(blackBoxPage.verifyResult(result), "Result not matched");
            Console.Write("Verify Result passed");
        }

        [Test, Order(4)]
        public void DivideTest()
        {
            var blackBoxPage = new BlackBoxPage(driver);
            PageFactory.InitElements(driver, blackBoxPage);
            blackBoxPage.enterFirstText.SendKeys(Value1);
            Console.Write("Enter First Number [" + Value1 + "]");
            blackBoxPage.entersecondText.SendKeys(Value2);
            Console.Write("Enter second Number [" + Value2 + "]");
            decimal totalResult = decimal.Parse(Value1) / decimal.Parse(Value2);
            decimal trun = blackBoxPage.TruncateDecimal(totalResult, 2);
            String result = Convert.ToString(trun);
            blackBoxPage.clickDivideButton.Click();
            Console.Write("Click on [Division] button");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.IsTrue(blackBoxPage.verifyResult(result), "Result not matched");
            Console.Write("Verify Result passed");
        }
    }
}
