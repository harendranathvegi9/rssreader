using Android.App;
using MvvmCross.Droid.Views;

namespace Rssreader.Android.Views
{
    [Activity(Label = "Main")]
    public class MainView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Main);
        }
    }
}