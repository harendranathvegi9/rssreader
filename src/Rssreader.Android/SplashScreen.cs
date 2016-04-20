using Android.App;
using MvvmCross.Droid.Views;

namespace Rssreader.Android
{
    [Activity(Label = "RSS-reader", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen) { }
    }
}