using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace AppiumEAFramework.Pages
{
    public class HomePageWow
    {
     

            public HomePageWow(IOSDriver<IOSElement> iosContext)
            {
                //TimeOutDuration timeSpan = new TimeOutDuration(new TimeSpan(0, 0, 0, 5, 0));
                PageFactory.InitElements(iosContext, this);
            }

            [FindsBy(How = How.Name, Using = "UI Components")]
            public IMobileElement<IOSElement> UIComponents { get; set; }

            [FindsBy(How = How.Name, Using = "ellipse Tab 2")]
            IMobileElement<IOSElement> tab2 { get; set; }

            [FindsBy(How = How.Name, Using = "square Tab 3")]
            IMobileElement<IOSElement> tab3 { get; set; }

            [FindsBy(How = How.Name, Using = "Save Item")]
            IMobileElement<IOSElement> btnSave { get; set; }

            internal void verifyTabs()
            {
                tab2.Click();
                tab3.Click();
                
                //var text = UIComponents.Text;
                //Assert.IsTrue(text != null);
            
                //txtName.SendKeys(name);
                //txtDescription.SendKeys(description);
                //btnSave.Click();
            }
        }
    }

