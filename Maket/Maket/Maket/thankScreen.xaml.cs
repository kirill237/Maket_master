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
    public partial class thankScreen : ContentPage
    {
        public thankScreen()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainMenu(), true);
        }
    }
}
