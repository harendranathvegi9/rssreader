using System.Net.Http;

namespace Rssreader.Bussiness.WebCaller
{
    public class WebCaller : IWebCaller
    {
        public string GetString(string url)
        {
            using (var client = new HttpClient())
            using (var response = client.GetAsync(url).Result)
            using (var content = response.Content)
            {
                return content.ReadAsStringAsync().Result;
            }
        }
    }
}