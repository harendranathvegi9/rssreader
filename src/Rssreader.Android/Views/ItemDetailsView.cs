using Android.App;
using MvvmCross.Droid.Views;

namespace Rssreader.Android.Views
{
    [Activity(Label = "Details")]
    public class ItemDetailsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_ItemDetails);
        }
    }
}