using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.IO;
using SQLite;
using Chemtex5.Models;

namespace Chemtex5.Views
{
    public class AddResourcePage : ContentPage
    {

        private Entry _nameEntry;
        private Entry _countEntry;
        private Button _saveButton;

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public AddResourcePage()
        {
            this.Title = "Dodaj surowiec";

            StackLayout stackLayout = new StackLayout();

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa surowca";
            stackLayout.Children.Add(_nameEntry);

            _countEntry = new Entry();
            _countEntry.Keyboard = Keyboard.Text;
            _countEntry.Placeholder = "Ilość surowca";
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
            db.CreateTable<Surowiec>();

            var maxPk = db.Table<Surowiec>().OrderByDescending(c => c.Id).FirstOrDefault();

            Surowiec surowiec = new Surowiec()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameEntry.Text.Replace(" ", "_"),
                Count = Convert.ToDouble(_countEntry.Text)

            };
            db.Insert(surowiec);
            await DisplayAlert(null, surowiec.Name + " zapisano", "OK");
            await Navigation.PopAsync();
        }
    }
}