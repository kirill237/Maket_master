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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            Ancet.Text = "Регистрация нового пользователя\nВведите свои данные";
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new MainMenu(), true);

            Navigation.PushAsync(new MainMenu(), true);
        }
    }
}
