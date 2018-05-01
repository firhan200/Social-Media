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
	public partial class ActivitiesPage : ContentPage
	{
		public ActivitiesPage ()
		{
			InitializeComponent ();
            PopulateActivities();

            ActivityList.RefreshCommand = new Command(PopulateActivities);
        }

        private void PopulateActivities()
        {
            ActivityList.IsRefreshing = true;

            var activities = new List<ActivityModel>();
            activities.Add(new ActivityModel
            {
                Username = "Linda",
                UserProfile = "sample",
                PostedDateString = "1 minutes ago",
                Action = "started following",
                ActionObject = "you"
            });
            activities.Add(new ActivityModel
            {
                Username = "Thomas",
                UserProfile = "sample",
                PostedDateString = "14 minutes ago",
                Action = "is new on",
                ActionObject = "Social Media"
            });
            activities.Add(new ActivityModel
            {
                Username = "Tom",
                UserProfile = "sample",
                PostedDateString = "45 minutes ago",
                Action = "posted something ond",
                ActionObject = "feeds"
            });

            ActivityList.ItemsSource = activities;
            ActivityList.IsRefreshing = false;
        }
    }
}