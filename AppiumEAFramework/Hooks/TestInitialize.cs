using System;
using AppiumEAFramework.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AppiumEAFramework.Hooks
{
    [TestFixture]
    public class TestInitialize : Base
    {
        public static string browser;
        public static string goUrl;

        public string htmlReporter { get; private set; }

        [SetUp]
        public void InitializeTest()
        {
            InitPlatform(jsonFile("platfromOS"));
            ExtentStart();
            test1 = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            var end = jsonFile("platfromOS");

            switch (end)
            {
                case "android":
                    AppiumUtilities.CloseAndroidApp();
                    break;
                case "ios":
                    AppiumUtilities.CloseIOSApp();
                    break;
                case "chrome":
                    driver.Quit();
                    break;

                default:
                    break;
            }

            ExtentClose();


        }
        [OneTimeSetUp]
        public void ExtentStart()
        {
            DateTime now = DateTime.UtcNow;
            string nowOn = now.ToString();
            Console.WriteLine(nowOn);
            extent = new ExtentReports();
            var htmlReprot = new ExtentV3HtmlReporter(htmlReporter + nowOn + ".html");
            extent.AttachReporter(htmlReprot);

        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        public void InitPlatform(string pltfromosjson)
        {
            {
                switch (pltfromosjson)
                {
                    case "android":
                        {
                            AndroidContext = StartAppiumServerForHybrid();
                            break;
                        }
                    case "ios":
                        {
                            IOSContext = StartAppiumServerForNative();
                            break;
                        }
                    case "api":
                        {

                            break;
                        }
                    case "chrome":
                        {
                            driver = new ChromeDriver();
                            driver.Manage().Window.Maximize();
                            driver.Navigate().GoToUrl(goUrl);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("NOt Supported ?");
                            break;
                        }
                }
            }
        }

        public string jsonFile(string node)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("/Users/doringber/Downloads/FirstFrameWork/AppiumEAFramework/config.json").Build();

            //return node = config[node];
            while (config[node] != null)
            {
                Console.WriteLine("This one: |" + config.ToString());
                browser = config["browser"];
                goUrl = config["url"];
                htmlReporter = config["reportPath"];
                return config[node];

            }
            return null;
        }



    }

}

