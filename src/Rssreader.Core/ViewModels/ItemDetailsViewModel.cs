using MvvmCross.Core.ViewModels;
using Rssreader.Core.Parameters;

namespace Rssreader.Core.ViewModels
{
    public class ItemDetailsViewModel : MvxViewModel
    {
        private string _title;
        private string _description;
        private string _link;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
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

        public void Init(ItemDetailsParameters parameters)
        {
            Title = parameters.Title;
            Description = parameters.Description;
            Link = parameters.Link;
        }
    }
}