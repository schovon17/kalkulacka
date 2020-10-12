using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kalkulackav2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        /* psani cisel */
        async void napsat1(object sender, EventArgs args)
        {
            double a = Double.Parse(c1.Text);   /* vybere se číslo */

            if (zmena_label.Text == "První")        /* zkotroluje, kolikate je to cislo v poradi */
            {
                cislo1.Text = (cislo1.Text + a).ToString();     /* prepise to cislo */
            } else if(zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }  
        }

        async void napsat2(object sender, EventArgs args)
        {
            double a = Double.Parse(c2.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat3(object sender, EventArgs args)
        {
            double a = Double.Parse(c3.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat4(object sender, EventArgs args)
        {
            double a = Double.Parse(c4.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat5(object sender, EventArgs args)
        {
            double a = Double.Parse(c5.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat6(object sender, EventArgs args)
        {
            double a = Double.Parse(c6.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat7(object sender, EventArgs args)
        {
            double a = Double.Parse(c7.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat8(object sender, EventArgs args)
        {
            double a = Double.Parse(c8.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }
        async void napsat9(object sender, EventArgs args)
        {
            double a = Double.Parse(c9.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }

        async void napsat0(object sender, EventArgs args)
        {
            double a = Double.Parse(c0.Text);

            if (zmena_label.Text == "První")
            {
                cislo1.Text = (cislo1.Text + a).ToString();
            }
            else if (zmena_label.Text == "Druhý")
            {
                cislo2.Text = (cislo2.Text + a).ToString();
            }
        }


        async void zmenacisla(object sender, EventArgs args)
        {
            if (zmena_label.Text == "První")
            {
                zmena_label.Text = "Druhý";
            } else
            {
                zmena_label.Text = "První";
            }
        }

        /* operace */
        async void scitani(object sender, EventArgs args)
        {
           
            double a = Double.Parse(cislo1.Text);   
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a + b).ToString();         /* provede operaci */
            rovnase.Text = "=";                         /* prida rovna se do vysledku */
        }
        async void odecitani(object sender, EventArgs args)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a - b).ToString();
            rovnase.Text = "=";
        }
        async void nasobeni(object sender, EventArgs args)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a * b).ToString();
            rovnase.Text = "=";
        }
        async void deleni(object sender, EventArgs args)
        {
            double a = Double.Parse(cislo1.Text);
            double b = Double.Parse(cislo2.Text);
            vysledek.Text = (a / b).ToString();
            rovnase.Text = "=";
        }
        /* mazani */
        async void smazanivysledku(object sender, EventArgs args)
        {
            vysledek.Text = "";                 /* smaze dany label */
            rovnase.Text = "";
        }
        async void smazani(object sender, EventArgs args)
        {
            cislo1.Text = "";
            cislo2.Text = "";
            vysledek.Text = "";
            rovnase.Text = "";
        }
    }
}
