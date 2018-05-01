using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMedia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FeedsPage : ContentPage
	{
		public FeedsPage ()
		{
			InitializeComponent ();
            PopulateFeeds();
            FeedList.ItemTapped += FeedList_ItemTapped;
            FeedList.RefreshCommand = new Command(PopulateFeeds);
        }

        private async void FeedList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var feed = e.Item as FeedModel;
            await Navigation.PushAsync(new FeedDetailPage(feed));
        }

        private void PopulateFeeds()
        {
            FeedList.IsRefreshing = true;

            var feeds = new List<FeedModel>();
            feeds.Add(new FeedModel
            {
                Username = "Firhan",
                UserProfile = ImageSource.FromFile("sample"),
                PostedDateString = "2 minutes ago",
                Caption = "Beautiful Landscape!!!",
                Image = ImageSource.FromFile("landscape"),
                Likes = 145,
                Comments = 79
            });
            feeds.Add(new FeedModel
            {
                Username = "Tom",
                UserProfile = ImageSource.FromFile("sample"),
                PostedDateString = "45 minutes ago",
                Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur",
                Image = ImageSource.FromFile("landscape2"),
                Likes = 670,
                Comments = 105
            });

            FeedList.ItemsSource = feeds;
            FeedList.IsRefreshing = false;
        }
	}
}