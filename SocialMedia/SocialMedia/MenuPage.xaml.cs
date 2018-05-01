using SocialMedia.Constants;
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
	public partial class MenuPage : ContentPage
	{
        public ListView ListView { get { return MenuList; } }

        public MenuPage ()
		{
			InitializeComponent ();
            PopulateMenus();

        }

        public void PopulateMenus()
        {
            var textColor = Color.FromHex("#078cd6");
            var menus = new List<MenuModel>();
            menus.Add(new MenuModel{
                Name = MenuLinks.Feeds,
                Icon = ImageSource.FromFile("feeds"),
                Color = textColor
            });
            menus.Add(new MenuModel
            {
                Name = MenuLinks.Notifications,
                Icon = ImageSource.FromFile("notifications"),
                Color = textColor
            });
            menus.Add(new MenuModel
            {
                Name = MenuLinks.Account,
                Icon = ImageSource.FromFile("account"),
                Color = textColor
            });
            menus.Add(new MenuModel
            {
                Name = MenuLinks.Settings,
                Icon = ImageSource.FromFile("settings"),
                Color = textColor
            });
            menus.Add(new MenuModel
            {
                Name = MenuLinks.Logout,
                Icon = ImageSource.FromFile("logout"),
                Color = textColor
            });

            MenuList.ItemsSource = menus;
        }
	}
}