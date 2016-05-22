using Rssreader.Bussiness.Models.Xml;

namespace Rssreader.Bussiness.Feed
{
    public interface IFeedService
    {
        Rss GetFeed(string feedUrl);
    }
}