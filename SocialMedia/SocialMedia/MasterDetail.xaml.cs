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
		}
	}
}
