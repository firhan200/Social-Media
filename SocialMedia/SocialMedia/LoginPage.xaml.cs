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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();

            Username.Text = "Firhan";
            Password.Text = "123456";
		}

        private async void Login(object sender, EventArgs e)
        {
            LoginBtn.IsVisible = false;
            Loader.IsVisible = true;

            try
            {
                string username = Username.Text;
                string password = Password.Text;

                await Task.Delay(2);

                Application.Current.MainPage = new MasterDetail();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Login Error: "+ex.Message);
            }        

            Loader.IsVisible = false;
            LoginBtn.IsVisible = true;
        } 

        public async void GotoSignUpPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
	}
}