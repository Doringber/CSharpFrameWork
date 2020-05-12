using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Remote;


namespace AppiumEAFramework.Utilities
{
    public class AppiumUtilities : Base
    {
        private AppiumLocalService _appiumLocalService;

        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly IOSDriver<IOSElement> _iosDriver;

        public AppiumUtilities(AppiumLocalService appiumLocalService, AndroidDriver<AndroidElement> androidDriver=null, IOSDriver<IOSElement>  iOSDriver=null)
        {
            _appiumLocalService = appiumLocalService;
            _androidDriver = androidDriver;
            _iosDriver = iOSDriver;
        }


        public AndroidDriver<AndroidElement> InitializeAndroidHybridApp()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();

            System.Environment.SetEnvironmentVariable("JAVA_HOME", "/Library/Java/JavaVirtualMachines/jdk-13.0.2.jdk/Contents/Home/bin/java");
            desiredCapabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            desiredCapabilities.SetCapability(MobileCapabilityType.DeviceName, "old");
            desiredCapabilities.SetCapability(MobileCapabilityType.Udid, "emulator-5554");
            desiredCapabilities.SetCapability(MobileCapabilityType.App, @"/Users/doringber/appiumstudio/original-apks/com.experitest.ExperiBank.LoginActivity.2.apk");
            desiredCapabilities.SetCapability(AndroidMobileCapabilityType.AppPackage, "com.experitest.ExperiBank");
            desiredCapabilities.SetCapability(AndroidMobileCapabilityType.AppActivity, ".LoginActivity");
            desiredCapabilities.SetCapability("automationName", "UiAutomator1");
       
            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(_appiumLocalService,desiredCapabilities);


            return androidDriver;
        }


        public IOSDriver<IOSElement> InitializeiOSNativeApp()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability(MobileCapabilityType.PlatformName, "iOS");
            desiredCapabilities.SetCapability(MobileCapabilityType.DeviceName, "iPhone X");
            desiredCapabilities.SetCapability(MobileCapabilityType.AutomationName, "XCUITest");
            desiredCapabilities.SetCapability(MobileCapabilityType.PlatformVersion, "11.4");
            //desiredCapabilities.SetCapability(MobileCapabilityType.BrowserName, "Safari");

            //desiredCapabilities.SetCapability(MobileCapabilityType.Udid, "115FBFED-55C9-47A5-9D6C-D8A8C01D701D");
            desiredCapabilities.SetCapability(MobileCapabilityType.App, "io.ionic.starter.wow");
            IOSDriver<IOSElement> iOSDriver = new IOSDriver<IOSElement>(_appiumLocalService, desiredCapabilities);

            return iOSDriver;
        }


        public AppiumLocalService StartAppiumLocalService()
        {
            var severoptions = new OptionCollector();
            var relaxedSecurityOptions = new KeyValuePair<string, string>("--relaxed-security", "");
            severoptions.AddArguments(relaxedSecurityOptions);
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort()
            .Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }


        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }


        public void CloseAndroidApp()
        {
            _androidDriver.CloseApp();
        }

        public void CloseIOSApp()
        {
            _iosDriver.CloseApp();
        }


    }

 
}
