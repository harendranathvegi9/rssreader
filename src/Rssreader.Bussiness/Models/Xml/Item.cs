using System;

namespace Rssreader.Bussiness.Models.Xml
{
    public class Item
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }
        public string Description { get; set; }
    }
}