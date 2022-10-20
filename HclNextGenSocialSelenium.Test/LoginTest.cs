using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.IO;

namespace HclNextGenSocialSelenium.Test
{
    [TestClass]
    public class LoginTest
    {
        string _baseURL = string.Empty;
        RemoteWebDriver _driver = null;
        public TestContext TestContext { get; set; }
        
        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver");
            //var path = @"C:\SeleniumDriver";
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            //If satisfied then
            if (!string.IsNullOrWhiteSpace(path))
            {
                return new ChromeDriver(path, options, TimeSpan.FromSeconds(300));
            }
            else
            {
                return new ChromeDriver(options);
            }
        }
        
        [TestInitialize]
        public void Setup()
        {
            this._baseURL = @"http://pkwebaspnet.azurewebsites.net/Account/Login?ReturnUrl=%2f";
            _driver = GetChromeDriver();
        }

        [TestMethod]
        public void ClickLoginButtonWithoutUserName()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys("SomePassword");
            //this._driver.FindElement(By.XPath("//input[@ type='submit'")).Click();
            //this._driver.FindElement(By.XPath(".//*[@value='Log in']")).Click();
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            //string errorText = this._driver.FindElement(By.ClassName("field-validation-error")).Text.Replace(System.Environment.NewLine, string.Empty);
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Email']")).Text;
            Assert.AreEqual("The User name field is required.", errorText);
            PushScreenshot();
        }


        [TestMethod]
        public void ClickLoginButtonWithUserName()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys("SomePassword");
            //this._driver.FindElement(By.XPath("//input[@ type='submit'")).Click();
            //this._driver.FindElement(By.XPath(".//*[@value='Log in']")).Click();
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            //string errorText = this._driver.FindElement(By.ClassName("field-validation-error")).Text.Replace(System.Environment.NewLine, string.Empty);
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Email']")).Text;
            Assert.AreEqual("The User name field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickLoginButtonWithoutPassword()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys("foo@bar.com");
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            //string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            Assert.AreEqual("The Password field is required.", errorText);
            //Assert.AreEqual(string.Empty, errorText); 
            PushScreenshot();
        }

        [TestMethod]
        public void ClickLoginButtonWithPassword()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys("foo@bar.com");
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            //string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            Assert.AreEqual("The Password field is required.", errorText);
            //Assert.AreEqual(string.Empty, errorText); 
            PushScreenshot();
        }

        [TestMethod]
        public void ClickLogniButtonWithoutUserNameAndPassword()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            //string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Email']")).Text;
            errorText=errorText + this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual("The User name field is required.The Password field is required.", errorText);
            PushScreenshot();
        }

        [TestMethod]
        public void ClickLogniButtonWithUserNameAndPassword()
        {
            this._driver.Navigate().GoToUrl(this._baseURL);
            this._driver.FindElement(By.Id("Email")).SendKeys(string.Empty);
            this._driver.FindElement(By.Id("Password")).SendKeys(string.Empty);
            this._driver.FindElement(By.XPath("//*[contains(@class,'btn')]")).Click();
            //string errorText = this._driver.FindElement(By.ClassName("validation-summary-errors")).Text.Replace(System.Environment.NewLine, string.Empty);
            string errorText = this._driver.FindElement(By.XPath(".//span[@for='Email']")).Text;
            errorText = errorText + this._driver.FindElement(By.XPath(".//span[@for='Password']")).Text;
            Assert.AreEqual("The User name field is required.The Password field is required.", errorText);
            PushScreenshot();
        }

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
