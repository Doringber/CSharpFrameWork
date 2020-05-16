using System;
namespace AppiumEAFramework.Utilities
{
    public static class BrowserCommand
    {

        
        public static void Back()
        {
            try
            {
                Base.AndroidContext.Navigate().Back();

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Back not works becasue: " + ex);
            }
        }

        public static void Refresh()
        {
            try
            {
                Base.appiumDriver.Navigate().Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Refresh not works becasue: " + ex);
            }

        }

        public static void GoToUrl(string url)
        {
            try
            {
                Base.appiumDriver.Navigate().GoToUrl(url);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" URL not works becasue: " + ex);
            }

        }

        public static void BackgroundApp(int num)
        { 
            try
            {
                Base.appiumDriver.BackgroundApp(num);


            }
            catch (Exception ex)
            {
                Console.WriteLine(" Backgorund not works becasue: " + ex);


            }

        }

        public static void PageSource()
        {
            try
            {                
                string page = Base.appiumDriver.PageSource.ToString();
                Console.WriteLine(page);


            }
            catch (Exception ex)
            {
                Console.WriteLine(" PaseSource not works becasue: " + ex);


            }

        }


    }
}
