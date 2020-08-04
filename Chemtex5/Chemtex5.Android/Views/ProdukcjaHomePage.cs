using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class ProdukcjaHomePage : ContentPage
    {
        public ProdukcjaHomePage()
        {
            this.Title = "Produkcja";

            StackLayout stackLayout = new StackLayout();

            Button button3 = new Button();
            //button3.Text = "Stwórz produkt";
            //button3.Clicked += Button3_Clicked;
            //stackLayout.Children.Add(button3);

            button3 = new Button();
            button3.Text = "Planowana produkcja";
            button3.Clicked += Button3_Clicked1;
            stackLayout.Children.Add(button3);

            Button button4 = new Button();
            button4.Text = "Pokaż produkty na magazynie";
            button4.Clicked += Button4_Clicked;
            stackLayout.Children.Add(button4);

            Button button6 = new Button();
            button6.Text = "Dodaj produkt z magazynu";
            button6.Clicked += Button6_Clicked;
            stackLayout.Children.Add(button6);

            Button button8 = new Button();
            button8.Text = "Edytuj produkt na magazynie";
            button8.Clicked += Button8_Clicked;
            stackLayout.Children.Add(button8);

            Button button5 = new Button();
            button5.Text = "Usuń produkt z magazynu";
            button5.Clicked += Button5_Clicked;
            stackLayout.Children.Add(button5);

            Button button = new Button();
            button.Text = "Dodaj recepturę";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);

            Button button1 = new Button();
            button1.Text = "Pokaż receptury";
            button1.Clicked += Button1_Clicked;
            stackLayout.Children.Add(button1);

            Button button7 = new Button();
            button7.Text = "Edytuj recepturę";
            button7.Clicked += Button7_Clicked;
            stackLayout.Children.Add(button7);

            Button button2 = new Button();
            button2.Text = "Usuń recepturę";
            button2.Clicked += Button2_Clicked;
            stackLayout.Children.Add(button2);


            Content = stackLayout;


        }

        private async void Button8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditProductPage());
        }

        private async void Button7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditRecipePage());
        }

        private async void Button3_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProductionPlan());
        }

        private async void Button6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExistingProductPage());
        }

        private async void Button5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteProductPage());
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllProductsPage());
        }

        //private async void Button3_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AddProductPage());
        //}

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteRecipePage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipePage());
        }
        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllRecipesPage());
        }
    }
}