using System;
using AppiumEAFramework.Extention;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.Pages.GooglePage;
using OpenQA.Selenium;

namespace AppiumEAFramework.WorksFlow
{
    public class GoogleWorksFlow : TestInitialize
    {
        UIActions basicMethod = new UIActions();

        public void HomeScreenSearch(String search)
        {
            basicMethod.sendKeys(driver, HomeScreen.searchInput, search);
            basicMethod.pressKey(driver, HomeScreen.searchInput, Keys.Enter);

        }

        public void HomeScreenMoreLuck()
        {
            basicMethod.ClickElement(driver, HomeScreen.moreLuckThenBrainbtn, 6);

        }
    }
}
