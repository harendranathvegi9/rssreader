using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Rssreader.Bussiness.Feed;
using Rssreader.Bussiness.WebCaller;
using Rssreader.Bussiness.Xml;
using Rssreader.Core.ViewModels;

namespace Rssreader.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FeedViewModel>();

            Mvx.RegisterType<IXmlReaderService, XmlReaderService>();
            Mvx.RegisterType<IWebCaller, WebCaller>();
            Mvx.RegisterType<IFeedService, FeedService>();
        }
    }
}