using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Maket
{
    public partial class zapravka : ContentPage
    {
        int price = 0;
        public static string LabTxt;


        public zapravka()
        {
            InitializeComponent();

            RelativeLayout fuel = new RelativeLayout();

            Label adres = new Label();
            fuel.Children.Add(adres,
            Constraint.RelativeToParent((parent) =>
            {
                return (parent.Width * 0.1);    // установка координаты X
            }),
           Constraint.RelativeToParent((parent) =>
           {
               return parent.Height * 0.05;   // установка координаты Y
           }));
            adres.Text = LabTxt;



            //Label Column
            {
                Label column = new Label();
                column.Text = "Колонка";
                fuel.Children.Add(column,
               Constraint.RelativeToParent((parent) =>
               {
                   return (parent.Width * 0.1);    // установка координаты X
               }),
              Constraint.RelativeToParent((parent) =>
              {
                  return parent.Height * 0.15;   // установка координаты Y
              }));
            }


            /**
                        //4 buttons number column
                        {

                            Button b1 = new Button();
                            Button b2 = new Button();
                            Button b3 = new Button();
                            Button b4 = new Button();


                            b1.Text = "1";
                            b2.Text = "2";
                            b3.Text = "3";
                            b4.Text = "4";
                            b1.BackgroundColor = Color.Red;
                            b2.BackgroundColor = Color.White;
                            b3.BackgroundColor = Color.White;
                            b4.BackgroundColor = Color.White;

                            fuel.Children.Add(b1,
                           Constraint.RelativeToParent((parent) =>
                           {
                               return parent.Width * 0.1;    // установка координаты X
                           }),
                          Constraint.RelativeToParent((parent) =>
                          {
                              return parent.Height * 0.25;   // установка координаты Y
                          }));

                            fuel.Children.Add(b2,
                            Constraint.RelativeToParent((parent) =>
                            {
                                return parent.Width * 0.35;    // установка координаты X
                            }),
                           Constraint.RelativeToParent((parent) =>
                           {
                               return parent.Height * 0.25;   // установка координаты Y
                           }));

                            fuel.Children.Add(b3,
                            Constraint.RelativeToParent((parent) =>
                            {
                                return parent.Width * 0.65;    // установка координаты X
                            }),
                           Constraint.RelativeToParent((parent) =>
                           {
                               return parent.Height * 0.25;   // установка координаты Y
                           }));


                            fuel.Children.Add(b4,
                            Constraint.RelativeToParent((parent) =>
                            {
                                return parent.Width * 0.8;    // установка координаты X
                            }),
                           Constraint.RelativeToParent((parent) =>
                           {
                               return parent.Height * 0.25;   // установка координаты Y
                           }));


                            b1.Clicked += (object sender, EventArgs e) =>
                            {
                                b1.BackgroundColor = Color.Red;
                                b2.BackgroundColor = Color.White;
                                b3.BackgroundColor = Color.White;
                                b4.BackgroundColor = Color.White;

                            };

                            b2.Clicked += (object sender, EventArgs e) =>
                            {

                                b1.BackgroundColor = Color.White;
                                b2.BackgroundColor = Color.Red;
                                b3.BackgroundColor = Color.White;
                                b4.BackgroundColor = Color.White;
                            };

                            b3.Clicked += (object sender, EventArgs e) =>
                            {
                                b1.BackgroundColor = Color.White;
                                b2.BackgroundColor = Color.White;
                                b3.BackgroundColor = Color.Red;
                                b4.BackgroundColor = Color.White;
                            };

                            b4.Clicked += (object sender, EventArgs e) =>
                            {
                                b1.BackgroundColor = Color.White;
                                b2.BackgroundColor = Color.White;
                                b3.BackgroundColor = Color.White;
                                b4.BackgroundColor = Color.Red;
                            };


                        }

               **/


            Picker column23 = new Picker();
            column23.BackgroundColor = Color.Red;
            column23.Title = "Выберите колонку";
            column23.Items.Add("1 колонка");
            column23.Items.Add("2 колонка");
            column23.Items.Add("3 колонка");
            column23.Items.Add("4 колонка");

            fuel.Children.Add(column23,
            Constraint.RelativeToParent((parent) =>
            {
                return (parent.Width * 0.1);    // установка координаты X
            }),
           Constraint.RelativeToParent((parent) =>
           {
               return parent.Width * 0.3;   // установка координаты Y
           }));




            //Label price
            Label Price = new Label();
            Price.Text = Convert.ToString(price) + " руб.";
            fuel.Children.Add(Price,
            Constraint.RelativeToParent((parent) =>
            {
                return (parent.Width * 0.5);    // установка координаты X
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width;   // установка координаты Y
            }));


            //Kol-vo litrov
            Entry kolvo = new Entry
            {
                Placeholder = "Введите количество литров",
                IsPassword = false,
                Keyboard = Keyboard.Numeric
            };
            fuel.Children.Add(kolvo,
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Width * 0.1;    // установка координаты X
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return parent.Height * 0.4;   // установка координаты Y
            }));
            kolvo.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                var entry = sender as Entry;
                int kolvo1 = Convert.ToInt32(entry.Text);
                price = kolvo1 * 10;
                Price.Text = price.ToString();
            };


            //Vibor toplivo
            {

                Picker picker = new Picker();
                picker.BackgroundColor = Color.Red;
                picker.Title = "Выберите топливо";
                picker.Items.Add("A-95");
                picker.Items.Add("A-92");
                picker.Items.Add("Propan");
                picker.Items.Add("Diesel");

                fuel.Children.Add(picker,
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Width * 0.1);    // установка координаты X
                }),
               Constraint.RelativeToParent((parent) =>
               {
                   return parent.Width * 0.8;   // установка координаты Y
               }));


                picker.SelectedIndexChanged += Picker_SelectedIndexChanged;

            }


            //button Oplatit
            {
                Button Oplata = new Button();
                Oplata.Text = "Оплатить";
                Oplata.BackgroundColor = Color.Red;
                fuel.Children.Add(Oplata,
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Width * 0.1);    // установка координаты X

                }),
               Constraint.RelativeToParent((parent) =>
               {
                   return parent.Width;   // установка координаты Y
               }));
                Oplata.Clicked += Oplata_Clicked;
            }
            Content = fuel;

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Oplata_Clicked(object sender, EventArgs e)
        {
            if (price > 0)
            {
                Navigation.PushAsync(new thankScreen(), true);
            }
        }
    }
}
