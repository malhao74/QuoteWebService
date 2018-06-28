using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using System.IO;
namespace QuoteWebService
{
    public class DataLayerQuotesDaddy
    {
        public static string Get()
        {
            // Make the request
            WebRequest request = WebRequest.Create("https://talaikis.com/api/quotes/random/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            // Check the status
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }
            // Read the response into a string 
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();

            return responseString;
        }
    }
}