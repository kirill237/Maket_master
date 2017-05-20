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
	public partial class List1 : ContentPage
	{
		public List1 ()
		{
			InitializeComponent ();
		}

        private void OnButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            string text1 = button.Text;
            //var aaaa = new zapravka();
            zapravka.LabTxt = text1;
            Navigation.PushModalAsync(new zapravka(), true);
            //zapravka.
            // Navigation.PushAsync(new zapravka(text1));
        }
    }
}
