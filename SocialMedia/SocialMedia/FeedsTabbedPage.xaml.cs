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
    public partial class FeedsTabbedPage : TabbedPage
    {
        public FeedsTabbedPage ()
        {
            InitializeComponent();

            Children.Add(new FeedsPage());
            Children.Add(new ActivitiesPage());
        }
    }
}