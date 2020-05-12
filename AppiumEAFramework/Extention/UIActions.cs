using System;
using AppiumEAFramework.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AppiumEAFramework.Extention
{
    public class UIActions: Base
    {
        public void ClickElement(IWebDriver driver, By element, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(drv => drv.FindElement(element));
            }
            test1.Log(Status.Pass, "Clicked Successfully on element: " + element);
            driver.FindElement(element).Click();

        }

        public void sendKeys(IWebDriver driver, By element, string keys)
        {
            driver.FindElement(element).SendKeys(keys);
            test1.Log(Status.Pass, "Send Keys: " + keys);

        }

        public void pressKey(IWebDriver driver, By element, string keys)
        {
            driver.FindElement(element).SendKeys(keys);
            test1.Log(Status.Pass, "Press on key: " + keys);

        }

    }
}

