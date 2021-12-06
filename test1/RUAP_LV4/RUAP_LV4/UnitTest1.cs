using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Female'])[1]/following::label[1]")).Click();
                driver.FindElement(By.Id("FirstName")).Click();
                driver.FindElement(By.Id("FirstName")).Clear();
                driver.FindElement(By.Id("FirstName")).SendKeys("Bruno");
                driver.FindElement(By.Id("LastName")).Click();
                driver.FindElement(By.Id("LastName")).Clear();
                driver.FindElement(By.Id("LastName")).SendKeys("Pandža");
                driver.FindElement(By.Id("Email")).Click();
                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("bruno.pandza99@gmail.com");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Register'])[2]/following::div[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::strong[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Register'])[2]/following::div[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::div[2]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[3]/following::strong[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Your Password'])[1]/following::div[2]")).Click();
                driver.FindElement(By.Id("Password")).Click();
                driver.FindElement(By.Id("Password")).Clear();
                driver.FindElement(By.Id("Password")).SendKeys("Bucikralj1");
                driver.FindElement(By.Id("ConfirmPassword")).Clear();
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Bucikralj1");
                driver.FindElement(By.Id("register-button")).Click();
                driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
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
