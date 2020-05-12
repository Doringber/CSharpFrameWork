using System;
using System.Threading;
using AppiumEAFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumEAFramework.Pages
{

    class BankSecondScreen
    {

        public BankSecondScreen(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
           
        }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/makePaymentButton")]
        private IWebElement makePaymentButton { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/mortageRequestButton")]
        private IWebElement mortageRequestButton { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/expenseReportButton")]
        private IWebElement expenseReportButton { get; set; }

        [FindsBy(How = How.Id, Using = "com.experitest.ExperiBank:id/logoutButton")]
        private IWebElement logoutButton { get; set; }

        internal void makePay()
        {
            Thread.Sleep(1000);
            makePaymentButton.Click();

        }

        internal void mortageReques()
        {
            Thread.Sleep(1000);
            mortageRequestButton.Click();

        }

        internal void expenseReport()
        {
            Thread.Sleep(1000);
            expenseReportButton.Click();

        }

        internal void logOut()
        {
            Thread.Sleep(1000);
            logoutButton.Click();



        }



    }
}
