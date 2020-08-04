using Chemtex5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class EditProductPage : ContentPage
    {
        private ListView _listView;
        private Entry _nameEntry;
        private Entry _countEntry;
        private Button _EditButton;

        Produkt _produkt = new Produkt();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public EditProductPage()
        {
            this.Title = "Edytuj produkt";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Produkt>().OrderBy(x => x.Name).ToList();
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa produktu";
            stackLayout.Children.Add(_nameEntry);

            _countEntry = new Entry();
            _countEntry.Keyboard = Keyboard.Text;
            _countEntry.Placeholder = "Ilość produktu";
            stackLayout.Children.Add(_countEntry);

            _EditButton = new Button();
            _EditButton.Text = "Zaktualizuj";
            _EditButton.Clicked += _EditButton_Clicked;
            stackLayout.Children.Add(_EditButton);

            Content = stackLayout;
        }

        private async void _EditButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var db = new SQLiteConnection(_dbPath);
                var _productUpdate = db.Table<Produkt>().Where(X => X.Name == _produkt.Name).FirstOrDefault();
                _productUpdate.Count = Convert.ToDouble(_countEntry.Text);
                _productUpdate.Name = _nameEntry.Text;
                db.Update(_productUpdate);
                await Navigation.PopAsync();
            }
            catch
            {
                await Navigation.PopAsync();
            }
        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _produkt = (Produkt)e.SelectedItem;
            _nameEntry.Text = _produkt.Name;
            _countEntry.Text = Convert.ToString(_produkt.Count);
        }
    }
}