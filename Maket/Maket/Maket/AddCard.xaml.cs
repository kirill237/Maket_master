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
    public partial class AddCard : ContentPage
    {
        private int ch = 0;
        private int G_ch = 0;
        String save_inp = "";
        char lastSymDel = ' ';
        public AddCard()
        {
            InitializeComponent();
        }

        private void AddCRD(object sender, EventArgs e)
        {
            //   App.Current.Properties.Add("CreditCard", entry.Text);
            //   App.Current.Properties.Add("CreditDt", entry_dt.Text);
            //   App.Current.Properties.Add("CreditCCV", entry_CCV.Text);
            Navigation.PopAsync(true);
        }

        private void CCV_entry(object sender, TextChangedEventArgs e)
        {
            //  if (entry_CCV.Text.Length > 12)
            // {
            //   entry_CCV.Text = entry_CCV.Text.Remove(entry_CCV.Text.Length - 1);
            // }
        }

        private void Data_entry(object sender, TextChangedEventArgs e)
        {
            //  if (entry_dt.Text.Length > 12)
            //  {
            //    entry_dt.Text = entry_dt.Text.Remove(entry_dt.Text.Length - 1);
            // }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            if (entry.Text.Length > save_inp.Length)
            {
                if (entry.Text[entry.Text.Length - 1] != '-')
                {
                    ch++;
                    G_ch++;
                    if (ch % 4 == 0 && G_ch < 15)
                    {
                        entry.Text += "-";
                        ch = 0;
                    }
                    save_inp = entry.Text;

                }
            }
            else if(save_inp.Length != entry.Text.Length)
            {
                if (save_inp[save_inp.Length - 2] == '-')
                {
                    entry.Text = entry.Text.Remove(entry.Text.Length - 1);
                    ch = 5;
                }
                else
                {
                    ch--;
                    G_ch--;
                }
                save_inp = entry.Text;
            }
            if(entry.Text.Length > 19)
            {
                entry.Text = entry.Text.Remove(entry.Text.Length - 1);
            }
            else
            {
                //Credit_num.Text = save_inp;
            }
            */
            // if (entry.Text.Length > 12)
            // {
            //   entry.Text = entry.Text.Remove(entry.Text.Length - 1);
            //}
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }
    }
}
