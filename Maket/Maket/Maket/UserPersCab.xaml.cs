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
	public partial class UserPersCab : ContentPage
	{
		public UserPersCab ()
		{
            object name = "";
            if (App.Current.Properties.TryGetValue("CreditCard", out name))
            {
                Cred.Text = (string)App.Current.Properties["CreditCard"];
            }
            InitializeComponent();
            Addcrda.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new AddCard(), true); };
            back.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new MainMenu(), true); };
            chang.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new Registration(), true); };
        }
	}
}
