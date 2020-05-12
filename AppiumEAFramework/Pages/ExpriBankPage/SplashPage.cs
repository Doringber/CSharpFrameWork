using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumEAFramework.Pages
{
    class SplashPage
    {
        private AndroidDriver<AndroidElement> _androidDriver;

        public SplashPage(AndroidDriver<AndroidElement> androidDriver)
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

        internal LoginPage SkipWelcome(string name, string pass)
        {
            user.SendKeys(name);
            pa.SendKeys(pass);
            login.Click();
            return new LoginPage(_androidDriver);
        }


    }
}
