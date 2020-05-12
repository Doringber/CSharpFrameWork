using System;
using System.IO;
using System.Net;
using System.Text;
using AventStack.ExtentReports;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace AppiumEAFramework.Utilities
{
    public class APIopenweathermap : Base
    {   
            private string ApiUrlString = "http://api.openweathermap.org/data/2.5/weather?q=";
            private string apiKey = "95bb4bcaf0fb03099e859f16dde0a0f3";
            public JObject jObject { get; set; }



        public string GetResponse(string city)
            {
                StringBuilder responseString = new StringBuilder();
                ApiUrlString = String.Format(ApiUrlString + "{0}", city + "&appid=" + apiKey);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ApiUrlString);

                // Set some reasonable limits on resources used by this request
                request.MaximumAutomaticRedirections = 4;
                request.MaximumResponseHeadersLength = 4;
                // Set credentials to use for this request.
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
              
             try
                {
                    // Get the stream associated with the response.
                    Stream receiveStream = response.GetResponseStream();
                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    if (receiveStream != null)
                    {
                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                        string line = "";
                        while ((line = readStream.ReadLine()) != null)
                        {
                            responseString.Append(line);
                            test1.Log(Status.Pass, "Response line: " + line);

                    }
                    Console.WriteLine("Response stream received.");
                        Console.WriteLine(responseString.ToString());
                        response.Close();
                        readStream.Close();
                    }
                }
                catch (Exception)
                {
                    responseString.Append("Did not get response");

                }
                return responseString.ToString();
            }
        public JObject JsonRespone()
        {

            RestClient restClient = new RestClient("http://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=95bb4bcaf0fb03099e859f16dde0a0f3");
            RestRequest restRequest = new RestRequest(Method.GET);
            IRestResponse restResponse = restClient.Execute(restRequest);

            //Parse the JSON response

            var jObject = JObject.Parse(restResponse.Content);
            return jObject;

        }

        public void assertReposne(string value, string compre)
        {
            try
            {
                jObject = JsonRespone();
                string text = jObject.GetValue(value).ToString();
                Assert.AreEqual(text, (compre));
                test1.Log(Status.Pass, "Assert Respone with this text: " + text);


            }
            catch (Exception ex)
            {
                test1.Log(Status.Fail, "Assert Respone fail" + ex);

            }


        }

    }

    }

