using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumEAFramework.Pages
{
    class HomePage
    {
        private AndroidDriver<AndroidElement> _androidDriver;
        public HomePage(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;
        }

        [FindsBy(How = How.XPath, Using = "//span[text()='Items']")]
        IWebElement menuItems { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Search']")]
        IWebElement menuSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Settings']")]
        IWebElement menuSettings { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#add")]
        IWebElement btnAdd { get; set; }

        internal void ClickItems()
        {
            menuItems.Click();
        }

        internal void ClickSearch()
        {
            menuSearch.Click();
        }

        internal void ClickSettings()
        {
            menuSettings.Click();
        }

        //internal NewItemPage CreateNewItem()
        //{
        //    Thread.Sleep(5000);
        //    btnAdd.Click();
        //    return new NewItemPage(_androidDriver);
        //}
    }
}
