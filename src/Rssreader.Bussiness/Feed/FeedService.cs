using System;
using Rssreader.Bussiness.Models.Xml;
using Rssreader.Bussiness.WebCaller;
using Rssreader.Bussiness.Xml;

namespace Rssreader.Bussiness.Feed
{
    public class FeedService : IFeedService
    {
        private readonly IWebCaller _webCaller;
        private readonly IXmlReaderService _xmlReaderService;

        public FeedService(IWebCaller webCaller,
            IXmlReaderService xmlReaderService)
        {
            _webCaller = webCaller;
            _xmlReaderService = xmlReaderService;
        }

        public Rss GetFeed(string feedUrl)
        {
            if (String.IsNullOrEmpty(feedUrl))
            {
                return new Rss();
            }

            return _xmlReaderService.Deserialize(_webCaller.GetString(feedUrl));
        }
    }
}