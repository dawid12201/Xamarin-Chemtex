using Chemtex5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class EditRecipePage : ContentPage
    {
        private ListView _listView;
        private Entry _nameEntry;
        private Entry _countEntry;
        private Button _EditButton;

        Receptura _receptura = new Receptura();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public EditRecipePage()
        {
            this.Title = "Edytuj recepturę";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList();
            _listView.ItemSelected += _listView_ItemSelected;
            stackLayout.Children.Add(_listView);

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa receptury";
            stackLayout.Children.Add(_nameEntry);

            _countEntry = new Entry();
            _countEntry.Keyboard = Keyboard.Text;
            _countEntry.Placeholder = "Surowce";
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
                var _recipeUpdate = db.Table<Receptura>().Where(X => X.Name == _receptura.Name).FirstOrDefault();
                _recipeUpdate.Surowce = _countEntry.Text;
                _recipeUpdate.Name = _nameEntry.Text;
                db.Update(_recipeUpdate);
                await Navigation.PopAsync();
            }
            catch
            {
                await Navigation.PopAsync();
            }
        }

        private void _listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _receptura = (Receptura)e.SelectedItem;
            _nameEntry.Text = _receptura.Name;
            _countEntry.Text = Convert.ToString(_receptura.Surowce);
        }
    }
}