using NUnit.Framework;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.Pages;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects;
using System;
using AventStack.ExtentReports;
using AppiumEAFramework.Utilities;
using System.Threading.Tasks;
using System.Threading;
using AppiumEAFramework.WorksFlow;

namespace AppiumEAFramework
{

    [TestFixture]
    public class TestClass : TestInitialize
    {


        [Test]
        public void AndroidExpriBankTest()
        {
   

            LoginPage homePage = new LoginPage(AndroidContext);

            homePage.Login("company", "company");
            BankSecondScreen bankSecondScreen = new BankSecondScreen(AndroidContext);
            BrowserCommand browserCommand = new BrowserCommand();

            bankSecondScreen.makePay();
            browserCommand.Back();
            bankSecondScreen.mortageReques();
            browserCommand.Back();
            bankSecondScreen.expenseReport();
            browserCommand.Back();
            bankSecondScreen.logOut();


        }


        [Test]
        public void IOSXamarinAppTest() 
        {

    
            var page = IOSContext.PageSource;
            Console.WriteLine(page);

            IOSContext.FindElementByName("ellipse Tab 2").Click();
            test1.Info("This step shows usage of info(details)");
            test1.Log(Status.Pass, "iOS wass pass 2");
            //// log with snapshot
            //test1.Fail("details",
            //    MediaEntityBuilder.CreateScreenCaptureFromPath("/Users/doringber/Downloads/reportsCSharp/screenshot.png").Build());

            //// test with snapshot
            //test1.AddScreenCaptureFromPath("/Users/doringber/Downloads/reportsCSharp/screenshot.png");
            IOSContext.FindElementByName("square Tab 3").Click();
            test1.Log(Status.Pass, "iOS was finish"); 

        }


        [Test]
        public void apitests()
        {
            const string cityString = "London,uk";
            APIopenweathermap apiResponse = new APIopenweathermap();
            string expectedResult = apiResponse.GetResponse(cityString);
            Thread.Sleep(5000);
            Console.WriteLine("-------------------- Web Page Displayed ------------------");
            //_webDriver.Navigate().GoToUrl(BaseUrl + cityString + "&appid=" + apiKey);
            //IWebElement responseElement = _webDriver.FindElement(By.TagName("pre"));
            //string displayedResponse = responseElement.Text;
            //Console.WriteLine(displayedResponse);

            apiResponse.assertReposne("name", "London");
            apiResponse.assertReposne("country", "GB");

        }

        [Test]
        public void GoogleTestOne()
        {
            GoogleWorksFlow workflow = new GoogleWorksFlow();
            workflow.HomeScreenSearch("dor ingber");
            test1.Pass("Finish the test");


            var url = driver.Url;
            Assert.IsTrue(url.Contains("dor"));
            test1.Pass("Assert URL contain right string");
        }

        [Test]
        public void GoogleTestTwo()
        {
            GoogleWorksFlow workflow = new GoogleWorksFlow();
            workflow.HomeScreenMoreLuck();

            var url = driver.Url;
            Assert.IsTrue(url.Contains("doodles"));
            test1.Pass("Assert URL contain right string" + url);

        }





    }


}

