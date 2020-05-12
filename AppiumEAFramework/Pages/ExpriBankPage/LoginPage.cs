using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppiumEAFramework.Hooks;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumEAFramework.Pages
{
    class LoginPage :TestInitialize
    {
        private AndroidDriver<AndroidElement> _androidDriver;

        public LoginPage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;
        }
        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/usernameTextField")]
        private IWebElement user { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/passwordTextField")]
        private IWebElement pa { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/loginButton")]
        private IWebElement login { get; set; }


        internal HomePage Login(string email, string password)
        {
      
            Thread.Sleep(2000);
            test1.Info("This step shows Android");
            user.SendKeys(email);
            test1.Log(Status.Pass, "Insert username");

            pa.SendKeys(password);
            test1.Log(Status.Pass, "Insert password");


            Assert.IsTrue(isLoginButtonDisplay());
            test1.Log(Status.Pass, "Was saw the button");


            login.Click();
            test1.Log(Status.Pass, "Able to click");


            return new HomePage(_androidDriver);
        }

        //internal void SignIn()
        //{
        //    btnSignInFirst.Click();
        //}
        internal bool isLoginButtonDisplay()
        {
            return login.Displayed;
        }

    }
}
