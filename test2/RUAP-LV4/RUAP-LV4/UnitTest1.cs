﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace RUAP_LV4
{
    namespace SeleniumTests
    {
        [TestFixture]
        public class UntitledTestCase
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                baseURL = "https://www.google.com/";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                
            }

            [Test]
            public void TheUntitledTestCaseTest()
            {
                driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/");
                driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/");
                driver.FindElement(By.Id("newsletter-subscribe-button")).Click();
                driver.FindElement(By.Id("newsletter-email")).Click();
                driver.FindElement(By.Id("newsletter-email")).Clear();
                driver.FindElement(By.Id("newsletter-email")).SendKeys("bruno.pandza99@gmail.com");
                driver.FindElement(By.Id("newsletter-subscribe-button")).Click();
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }


  
}
