using System;
using System.Threading;
using AppiumEAFramework.Extention;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.Utilities;
using AppiumEAFramework.WorksFlow;
using NUnit.Framework;

namespace AppiumEAFramework.TestCase
{
    [TestFixture]
    public class WeatherAPI : TestInitialize
    {

        [Test]
        public void GetResponseTest()
        {
            const string cityString = "Tel aviv";
            APIActions apiResponse = new APIActions();
            ApiUrlString = String.Format(Base.ApiUrlString + "{0}", cityString + "&appid=" + Base.apiToken);
            apiResponse.GetResponAndValid(ApiUrlString, "name");
            apiResponse.assertJson("Tel aviv", "Tel aviv");




        }
    }
}
