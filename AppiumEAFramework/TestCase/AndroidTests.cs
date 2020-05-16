using System;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.Pages;
using AppiumEAFramework.Utilities;
using NUnit.Framework;

namespace AppiumEAFramework.TestCase
{
    [TestFixture]
    public class AndroidTests : TestInitialize
    {


        [Test]
        public void AndroidExpriBankTest()
        {


            LoginPage homePage = new LoginPage(AndroidContext);

            homePage.Login("company", "company");
            BankSecondScreen bankSecondScreen = new BankSecondScreen(AndroidContext);

            bankSecondScreen.makePay();
            BrowserCommand.Back();
            bankSecondScreen.mortageReques();
            BrowserCommand.Back();
            bankSecondScreen.expenseReport();
            BrowserCommand.Back();
            bankSecondScreen.logOut();


        }
    }
}

