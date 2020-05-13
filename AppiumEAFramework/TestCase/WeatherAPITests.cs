using System;
using System.Threading;
using AppiumEAFramework.Hooks;
using AppiumEAFramework.Utilities;
using NUnit.Framework;

namespace AppiumEAFramework.TestCase
{
    [TestFixture]
    public class WeatherAPI : TestInitialize
    {
        [Test]
        public void GetResponseTest()
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
    }
}
