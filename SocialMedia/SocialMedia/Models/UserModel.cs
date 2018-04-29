using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SocialMedia.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Bio { get; set; }
        public ImageSource UserProfile { get; set; }
        public int Posts { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
    }
}
