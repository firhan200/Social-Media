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
	public partial class AccountPage : ContentPage
	{
		public AccountPage (UserModel user)
		{
			InitializeComponent ();

            PopulateUser(user);
        }

        public void PopulateUser(UserModel user)
        {
            if (user == null)
            {
                user = new UserModel {
                    //get login user
                    Username = "Firhan",
                    UserProfile = ImageSource.FromFile("sample"),
                    Bio = "https://firhan200.github.io",
                    Posts = 2,
                    Followers = 102,
                    Following = 261
                };               
            }
            Username.Text = user.Username;
            UserProfile.Source = user.UserProfile;
            Bio.Text = user.Bio;
            Posts.Text = user.Posts.ToString();
            Followers.Text = user.Followers.ToString();
            Following.Text = user.Following.ToString();
        }
	}
}