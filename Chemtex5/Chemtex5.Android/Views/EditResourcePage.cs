using Chemtex5.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class EditResourcePage : ContentPage
    {
        private ListView _listView;
        private Entry _idEntry;
        private Entry _nameEntry;
        private Entry _countEntry;
        private Button _EditButton;

        Surowiec _surowiec = new Surowiec();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public EditResourcePage()
        {
            this.Title = "Edytuj surowiec";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList();
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _idEntry = new Entry();
            _idEntry.Placeholder = "ID";
            _idEntry.IsVisible = false;
            stackLayout.Children.Add(_idEntry);

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa surowca";
            stackLayout.Children.Add(_nameEntry);

            _countEntry = new Entry();
            _countEntry.Keyboard = Keyboard.Text;
            _countEntry.Placeholder = "Ilość surowca";
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
                Surowiec surowiec = new Surowiec()
                {
                    Id = Convert.ToInt16(_idEntry.Text),
                    Name = _nameEntry.Text.Replace(" ", "_"),
                    Count = Convert.ToDouble(_countEntry.Text)
                };
                db.Update(surowiec);
                await Navigation.PopAsync();
            }
            catch
            {
                await Navigation.PopAsync();
            }
            

        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _surowiec = (Surowiec)e.SelectedItem;
            _idEntry.Text = _surowiec.Id.ToString();
            _nameEntry.Text = _surowiec.Name;
            _countEntry.Text = Convert.ToString(_surowiec.Count);
        }
    }
}