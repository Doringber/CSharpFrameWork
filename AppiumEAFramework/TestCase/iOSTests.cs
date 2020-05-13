using System;
using AppiumEAFramework.Hooks;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace AppiumEAFramework.TestCase
{
    [TestFixture]
    public class iOSTests : TestInitialize
    {
        [Test]
        public void SwtichTabs()
        {
            var page = IOSContext.PageSource;
            Console.WriteLine(page);

            IOSContext.FindElementByName("ellipse Tab 2").Click();
            test1.Info("This step shows usage of info(details)");
            test1.Log(Status.Pass, "iOS wass pass 2");
            IOSContext.FindElementByName("square Tab 3").Click();
            test1.Log(Status.Pass, "iOS was finish");

        }

    }
    }
