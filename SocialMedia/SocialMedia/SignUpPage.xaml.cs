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
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();

            Username.Text = "Firhan";
            Email.Text = "firhan.faisal1995@gmail.com";
            Password.Text = "123456";
        }

        public async void GotoLoginPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}