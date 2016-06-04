using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using Rssreader.Bussiness.Exceptions;
using Rssreader.Bussiness.Feed;
using Rssreader.Bussiness.Models.Xml;
using Rssreader.Common;
using Rssreader.Core.Parameters;

namespace Rssreader.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        private ObservableCollection<Item> _items;
        private string _link;
        private readonly IFeedService _feedService;
        private string _exceptionTitle;

        public FeedViewModel(IFeedService feedService)
        {
            _feedService = feedService;
            RefreshFeed(Constant.BaseRssFeedUrl);
            Link = Constant.BaseRssFeedUrl;
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

        public string Link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
                RaisePropertyChanged(() => Link);
            }
        }

        public string ExceptionTitle
        {
            get { return _exceptionTitle; }
            set
            {
                _exceptionTitle = value;
                RaisePropertyChanged(() => ExceptionTitle);
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

        public ICommand RefreshFeedCommand => new MvxCommand(() => RefreshFeed(Link));

        private void RefreshFeed(string feedUrl)
        {
            try
            {
                Items = new ObservableCollection<Item>(_feedService.GetFeed(feedUrl).Channel.Items);
            }
            catch (RssTimeoutException exception)
            {
                ExceptionTitle = exception.Message;
            }
            catch (RssEncodingException exception)
            {
                ExceptionTitle = exception.Message;
            }
        }
    }
}