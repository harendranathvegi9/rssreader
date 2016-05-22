using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Rssreader.Bussiness.Models.Xml;

namespace Rssreader.Bussiness.Xml
{
    public class XmlReaderService : IXmlReaderService
    {
        public Rss Deserialize(string xml)
        {
            if (String.IsNullOrEmpty(xml))
            {
                return new Rss();
            }

            Channel channel = GetChannel(xml);
            channel.Items = GetItems(xml);

            return new Rss
            {
                Channel = channel
            };
        }

        private Channel GetChannel(string xml)
        {
            return XDocument.Parse(xml).Descendants("channel").Select(x => new Channel
            {
                Title = x.Element("title")?.Value,
                Description = x.Element("description")?.Value,
                Link = x.Element("link")?.Value,
                Language = x.Element("language")?.Value,
                LastBuildDate = Convert.ToDateTime(x.Element("lastBuildDate")?.Value)
            }).FirstOrDefault();
        }

        private IEnumerable<Item> GetItems(string xml)
        {
            return XDocument.Parse(xml).Descendants("item").Select(x => new Item
            {
                Title = x.Element("title")?.Value,
                Description = x.Element("description")?.Value,
                Link = x.Element("link")?.Value,
                PubDate = Convert.ToDateTime(x.Element("pubDate")?.Value)
            });
        }
    }
}