using Rssreader.Bussiness.Models.Xml;

namespace Rssreader.Bussiness.Xml
{
    public interface IXmlReaderService
    {
        Rss Deserialize(string xml);
    }
}