using System;

namespace Rssreader.Bussiness.Exceptions
{
    public class RssTimeoutException : Exception
    {
        public RssTimeoutException(string message) : base(message) { }
    }
}