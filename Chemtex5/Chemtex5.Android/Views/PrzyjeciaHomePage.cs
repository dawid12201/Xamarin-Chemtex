using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class PrzyjeciaHomePage : ContentPage
    {
        public PrzyjeciaHomePage()
        {
            this.Title = "Przyjecia";

            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Dodaj towary z transportu";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);

            Content = stackLayout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTransportPage());
        }
    }
}