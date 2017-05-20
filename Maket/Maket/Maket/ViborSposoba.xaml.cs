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
	public partial class ViborSposoba : ContentPage
	{
		public ViborSposoba ()
		{
            InitializeComponent();

            a.BackgroundColor = Color.Red;
            Geo.BackgroundColor = Color.Red;
            Geo.Clicked += (object sender, EventArgs e) =>
            {
                zapravka.LabTxt = "ул. Автодорожная, 7А  8-924-597-70-71";
                Navigation.PushAsync(new zapravka(), true);  //Modal
            };
            a.Clicked += (object sender, EventArgs e) => { Navigation.PushAsync(new List1(), true); };
        }
	}
}
