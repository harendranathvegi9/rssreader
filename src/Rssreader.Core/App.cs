using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Rssreader.Core.ViewModels;

namespace Rssreader.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainViewModel>();
        }
    }
}