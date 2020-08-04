using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Chemtex5.Models;
using SQLite;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class DeleteProductPage : ContentPage
    {
        private ListView _listView;
        private Button _button;
        Produkt _produkt = new Produkt();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public DeleteProductPage()
        {
            this.Title = "Usuń produkt";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Produkt>().OrderBy(x => x.Name).ToList();
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _button = new Button();
            _button.Text = "Usuń";
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            Content = stackLayout;
        }

        private async void _button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.Table<Produkt>().Delete(x => x.Id == _produkt.Id);
            await Navigation.PopAsync();
        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _produkt = (Produkt)e.SelectedItem;
        }
    }
}