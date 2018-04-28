using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialMedia.Models
{
    public class FeedModel
    {
        public string Username { get; set; }
        public ImageSource UserProfile { get; set; }
        public string Caption { get; set; }
        public DateTime PostedDate { get; set; }
        public string PostedDateString { get; set; }
        public ImageSource Image { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
    }
}
