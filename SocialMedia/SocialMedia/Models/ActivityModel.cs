using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialMedia.Models
{
    public class ActivityModel
    {
        public string Username { get; set; }
        public ImageSource UserProfile { get; set; }
        public string Action { get; set; }
        public string ActionObject { get; set; }
        public string PostedDateString { get; set; }
    }
}
