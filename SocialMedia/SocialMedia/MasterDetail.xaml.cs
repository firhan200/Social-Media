using SocialMedia.Constants;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialMedia
{
	public partial class MasterDetail : MasterDetailPage
	{
        MenuPage menuPage = new MenuPage();

        public MasterDetail()
		{
            Master = menuPage;
            Detail = new NavigationPage(new FeedsTabbedPage());

            menuPage.ListView.ItemTapped += ListView_ItemTapped;
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var leftMenuModel = e.Item as MenuModel;

            ChangeDetailByTitle(leftMenuModel.Name);

            IsPresented = false;
        }

        private void ChangeDetailByTitle(string menu)
        {
            if (menu == MenuLinks.Feeds)
            {
                Detail = new NavigationPage(new FeedsTabbedPage());
            }
            else if (menu == MenuLinks.Account)
            {
                //current user account
                Detail = new NavigationPage(new AccountPage(null));
            }           
        }
    }
}
