using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.IO;

namespace HclNextGenSocialSelenium.Test
{
    [TestClass]
    public class UserRegisterTest
    {
        string _baseURL = string.Empty;
        RemoteWebDriver _driver = null;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {
            this._baseURL = @"http://pkwebaspnet.azurewebsites.net/Account/Register?returnUrl=%2F";
            //_driver = new ChromeDriver(Environment.GetEnvironmentVariable("ChromeWebDriver"));
            _driver=GetChromeDriver();
        }

        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver");
            //var path = @"C:\SeleniumDriver";
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");

            if (!string.IsNullOrWhiteSpace(path))
            {
                return new ChromeDriver(path, options, TimeSpan.FromSeconds(300));
            }
            else
            {
                return new ChromeDriver(options);
            }
        }

        [TestMethod]
        public void ClickRegisterButtonWithAllBlankField()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='UserName']")).Text;
            //errorText= errorText+ this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual(@"The User name field is required.The Password field is required.", errorText);
            PushScreenshot();
        }


        [TestMethod]
        public void ClickRegisterButtonWithValue()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='UserName']")).Text;
            //errorText= errorText+ this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual(@"The User name field is required.The Password field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickRegisterButtonWithUserNameBlank()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys("testpassword");
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testpassword");
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='UserName']")).Text;
            Assert.AreEqual(@"The User name field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickSubmitButtonWithUser()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys("testpassword");
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys("testpassword");
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='UserName']")).Text;
            Assert.AreEqual(@"The User name field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickRegisterButtonWithPasswordAndConfirmPasswrdBlank()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys("testusername");
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual("The Password field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickAccountButtonWithValue()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys("testusername");
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual("The Password field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickRegisterWithPasswordMismatch()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys("testusername");
            this._driver.FindElement(By.Id("Password")).SendKeys("password1");
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys("password2");
            //this._driver.FindElement(By.XPath(".//*[@value='Register']")).Click();
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='ConfirmPassword']")).Text;
            Assert.AreEqual("'Confirm password' and 'Password' do not match.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickVerifyPasswordMismatch()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("UserName")).SendKeys("testusername");
            this._driver.FindElement(By.Id("Password")).SendKeys("password1");
            this._driver.FindElement(By.Id("ConfirmPassword")).SendKeys("password2");
            //this._driver.FindElement(By.XPath(".//*[@value='Register']")).Click();
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            //string errorText = this._driver.FindElement(By.XPath(".//span[@for='ConfirmPassword']")).Text;
            Assert.AreEqual("'Confirm password' and 'Password' do not match.", errorText);
            PushScreenshot();
        }

        //[TestMethod]
        //public void ClickRegisterWithMinimalPasswordLengthVioalationRule()
        //{
        //    this._driver.Navigate().GoToUrl(this._baseURL);
        //    this._driver.FindElement(By.Id("Input_Email")).SendKeys("testusername");
        //    this._driver.FindElement(By.Id("Input_Password")).SendKeys("123");
        //    this._driver.FindElement(By.Id("Input_ConfirmPassword")).SendKeys("123");
        //    //this._driver.FindElement(By.XPath(".//*[@value='Register']")).Click();
        //    this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
        //    string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
        //    Assert.AreEqual("The Password must be at least 6 characters long.", errorText);
        //    PushScreenshot();
        //}

        public void PushScreenshot()
        {
            var filePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()) + ".png";
            var screenshot = this._driver.GetScreenshot();
            screenshot.SaveAsFile(filePath);
            TestContext.AddResultFile(filePath);
        }

        [TestCleanup]
        public void TearDown()
        {
            this._driver.Close();
            this._driver.Dispose();
        }
    }
}
