using AventStack.ExtentReports;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;

namespace AppiumEAFramework.Utilities
{
    public class Base
    {
        public AppiumLocalService AppiumServiceContext;
        public static AppiumDriver<IWebElement> appiumDriver;
        public static AndroidDriver<AndroidElement> AndroidContext;
        public IOSDriver<IOSElement> IOSContext;
        public static IWebDriver driver;

        public static ExtentReports extent;
        public static ExtentTest test1;


        public AppiumUtilities AppiumUtilities => new AppiumUtilities(AppiumServiceContext, AndroidContext, IOSContext);

        public static string typePlatfrom;
        public static string platfromOS1;
        public static string url;
        public static string browser;
        public static string goUrl;
        public static string apiToken;
        public static string ApiUrlString;

        public static JObject jObject { get; set; }





        public AndroidDriver<AndroidElement> StartAppiumServerForHybrid()
        {
            //Appium Local service
            AppiumServiceContext = AppiumUtilities.StartAppiumLocalService();

            AndroidContext = AppiumUtilities.InitializeAndroidHybridApp();

            return AndroidContext;
        }

        public IOSDriver<IOSElement> StartAppiumServerForNative()
        {
            //Appium Local service
            AppiumServiceContext = AppiumUtilities.StartAppiumLocalService();

            IOSContext = AppiumUtilities.InitializeiOSNativeApp();

            return IOSContext;
        }

    }
}
