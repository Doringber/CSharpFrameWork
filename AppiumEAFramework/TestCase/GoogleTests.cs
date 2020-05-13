using System;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.WorksFlow;
using NUnit.Framework;

namespace AppiumEAFramework.TestCase
{
    [TestFixture]
    public class GoogleTests : TestInitialize
    {
        [Test]
        public void Search()
        {
            GoogleWorksFlow workflow = new GoogleWorksFlow();
            workflow.HomeScreenSearch("dor ingber");
            test1.Pass("Finish the test");


            var url = driver.Url;
            Assert.IsTrue(url.Contains("dor"));
            test1.Pass("Assert URL contain right string");
        }

        [Test]
        public void PressOnDoodles()
        {
            GoogleWorksFlow workflow = new GoogleWorksFlow();
            workflow.HomeScreenMoreLuck();

            var url = driver.Url;
            Assert.IsTrue(url.Contains("doodles"));
            test1.Pass("Assert URL contain right string" + url);

        }
    }
}
