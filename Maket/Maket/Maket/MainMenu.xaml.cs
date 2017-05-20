using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();

            Contact.BackgroundColor = Color.Red;
            fuel.BackgroundColor = Color.Red;
            reg.BackgroundColor = Color.Red;
            abouUs.BackgroundColor = Color.Red;
            support.BackgroundColor = Color.Red;

            abouUs.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new AboutUs(), true); };

            Contact.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new contacts(), true); };

            fuel.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new ViborSposoba(), true); };
            //  reg.Clicked += (object sender, EventArgs e) => { Navigation.PushModalAsync(new UserPersCab(), true); };
            reg.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new UserPersCab(), true); };
        }
    }
}
