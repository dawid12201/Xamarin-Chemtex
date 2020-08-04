using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SQLite;
using Chemtex5.Models;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class AddExistingProductPage : ContentPage
    {
        private Entry _nameEntry;
        private Entry _countEntry;
        private Button _saveButton;

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public AddExistingProductPage()
        {
            this.Title = "Dodaj istniejący produkt";

            StackLayout stackLayout = new StackLayout();

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa produktu";
            stackLayout.Children.Add(_nameEntry);

            _countEntry = new Entry();
            _countEntry.Keyboard = Keyboard.Text;
            _countEntry.Placeholder = "Ilość produktu";
            stackLayout.Children.Add(_countEntry);

            _saveButton = new Button();
            _saveButton.Text = "Dodaj";
            _saveButton.Clicked += _saveButton_Clicked;
            stackLayout.Children.Add(_saveButton);

            Content = stackLayout;
        }

        private async void _saveButton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Produkt>();

            var maxPk = db.Table<Produkt>().OrderByDescending(c => c.Id).FirstOrDefault();

            Produkt produkt = new Produkt()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameEntry.Text,
                Count = Convert.ToDouble(_countEntry.Text)

            };
            db.Insert(produkt);
            await DisplayAlert(null, produkt.Name + " zapisano", "OK");
            await Navigation.PopAsync();
        }
    }
}