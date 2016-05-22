using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using Rssreader.Bussiness.Feed;
using Rssreader.Bussiness.Models.Xml;
using Rssreader.Common;
using Rssreader.Core.Parameters;

namespace Rssreader.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        private ObservableCollection<Item> _items;

        public FeedViewModel(IFeedService feedService)
        {
            Items = new ObservableCollection<Item>(feedService.GetFeed(Constant.BaseRssFeedUrl).Channel.Items);
        }

        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        public ICommand OpenItemDetailsView => new MvxCommand<Item>(item =>
        {
            ShowViewModel<ItemDetailsViewModel>(new ItemDetailsParameters
            {
                Title = item.Title,
                Description = item.Description,
                Link = item.Link
            });
        });
    }
}