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
	public partial class FeedDetailPage : ContentPage
	{
		public FeedDetailPage (FeedModel feed)
		{
			InitializeComponent ();

            this.Title = feed.Username+"'s post";

            Username.Text = feed.Username;
            UserProfile.Source = feed.UserProfile;
            PostedDateString.Text = feed.PostedDateString;
            Caption.Text = feed.Caption;
            Image.Source = feed.Image;
            Likes.Text = feed.Likes.ToString();
            Comments.Text = feed.Comments.ToString();
            CommentsLabel.Text = "(" + feed.Comments.ToString() + ") Comments";

            PopulateComments();
        }

        private async void PopulateComments()
        {
            var comments = new List<CommentModel>();
            comments.Add(new CommentModel
            {
                Username = "Linda",
                UserProfile = "sample",
                PostedDateString = "1 minutes ago",
                Comment = "Great works!"
            });
            comments.Add(new CommentModel
            {
                Username = "Thomas",
                UserProfile = "sample",
                PostedDateString = "2 minutes ago",
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in"
            });

            CommentsList.ItemsSource = comments;
        }
	}
}