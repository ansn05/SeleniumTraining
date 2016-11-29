using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTraining;
using SeleniumTraining.Pages;

namespace SeleniumTraining
{
    [TestClass]
    public class LoginTests : LoginPage
    {
        public LoginTests(IWebDriver driver) : base(driver)
        {
        }

        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void CheckLoginPage()
        {
            BaseTest.GoTo();
            //Assert.AreEqual(true, Driver.Instance.ElementIsPresent(By.Id("loginform")));
            Assert.AreEqual(true, LoginForm);

        }

        [TestMethod]
        public  void LogInAsAdmin()
        {
            BaseTest.GoTo();
            BaseTest.LoginAs("ansntest")
                .withPassword("tester666")
                .Login();
            Assert.AreEqual(true, Driver.Instance.ElementIsPresent(By.Id("welcome")));
        }
    }
}
