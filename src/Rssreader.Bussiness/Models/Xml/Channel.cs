using System;
using System.Collections.Generic;

namespace Rssreader.Bussiness.Models.Xml
{
    public class Channel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime LastBuildDate { get; set; }
        public string Language { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}