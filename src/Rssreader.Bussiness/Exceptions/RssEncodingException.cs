using System;

namespace Rssreader.Bussiness.Exceptions
{
    public class RssEncodingException : Exception
    {
        public RssEncodingException(string message) : base(message) { }
    }
}