using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialMedia.Models
{
    public class CommentModel
    {
        public string Username { get; set; }
        public ImageSource UserProfile { get; set; }
        public DateTime PostedDate { get; set; }
        public string PostedDateString { get; set; }
        public string Comment { get; set; }
    }
}
