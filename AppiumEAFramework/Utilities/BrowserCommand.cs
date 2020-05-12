using System;
namespace AppiumEAFramework.Utilities
{
    public  class BrowserCommand
    {

        
        public void Back()
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

        public void Refresh()
        {
            try
            {
                Base.AndroidContext.Navigate().Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Refresh not works becasue: " + ex);
            }

        }

        public  void GoToUrl(string url)
        {
            try
            {
                Base.AndroidContext.Navigate().GoToUrl(url);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" URL not works becasue: " + ex);
            }

        }

        public  void BackgroundApp(int num)
        {
            try
            {
                Base.AndroidContext.BackgroundApp(num);


            }
            catch (Exception ex)
            {
                Console.WriteLine(" Backgorund not works becasue: " + ex);


            }

        }

        public void PageSource()
        {
            try
            {
                string page = Base.AndroidContext.PageSource.ToString();
                Console.WriteLine(page);


            }
            catch (Exception ex)
            {
                Console.WriteLine(" PaseSource not works becasue: " + ex);


            }

        }


    }
}
