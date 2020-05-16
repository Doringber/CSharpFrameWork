using System;
using System.Net;
using AppiumEAFramework.Utilities;
using AventStack.ExtentReports;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace AppiumEAFramework.Extention
{
    public class APIActions : Base
    {
        public WebClient webClient = new WebClient();


        public void assertJson(string value, string compre)
        {
            try
            {
                //jObject = JsonResponeGet();
                //string text = jObjectParse.GetValue(value).ToString();
                Assert.AreEqual(value, (compre));
                test1.Log(Status.Pass, "Assert Respone with this text: " + value);


            }
            catch (Exception ex)
            {
                test1.Log(Status.Fail, "Assert Respone fail" + ex);

            }


        }

        public void GetResponAndValid(string url, string value)
        {
            WebClient webClient = new WebClient();
            string strPageCode = webClient.DownloadString(url);
            dynamic doj = JsonConvert.DeserializeObject<dynamic>(strPageCode);
            string temp = doj[value].ToString();
            Console.WriteLine(temp);

        }

    
    }
}
