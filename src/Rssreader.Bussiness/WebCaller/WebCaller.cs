using System;
using System.Net.Http;
using Rssreader.Bussiness.Exceptions;

namespace Rssreader.Bussiness.WebCaller
{
    public class WebCaller : IWebCaller
    {
        public string GetString(string url)
        {
            using (var client = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(10)
            })
            {
                try
                {
                    var response = client.GetAsync(url).Result;
                    var content = response.Content;
                    return content.ReadAsStringAsync().Result;
                }
                catch
                {
                    throw new RssTimeoutException("TIMEOUT EXCEPTION");
                }
            }
        }
    }
}