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
    public class AddTransportPage : ContentPage
    {
        private Picker _picker;
        private Entry _idEntry;
        private Entry _countEntry;
        private Picker _picker2;
        private Entry _idEntry2;
        private Entry _countEntry2;
        private Picker _picker3;
        private Entry _idEntry3;
        private Entry _countEntry3;
        private Picker _picker4;
        private Entry _idEntry4;
        private Entry _countEntry4;
        private Picker _picker5;
        private Entry _idEntry5;
        private Entry _countEntry5;
        private Button _AddButton;
        Surowiec _surowiec = new Surowiec();

        Surowiec surowiec = new Surowiec();

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public AddTransportPage()
        {
            
            this.Title = "Dodaj surowce z transportu";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            
            
                _picker = new Picker()
                {
                    ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                    Title = "Wybierz surowiec",
                    TitleColor = Color.Gold,
                    
                };
                _idEntry = new Entry()
                {
                    Placeholder = "ID",
                    IsVisible = false,
                };
                _countEntry = new Entry()
                {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Wprowadź ilość surowca",
                };
                _picker2 = new Picker()
                {
                    ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                    Title = "Wybierz surowiec",
                    TitleColor = Color.Gold,
                    
                };
                _idEntry2 = new Entry()
                {
                    Placeholder = "ID",
                    IsVisible = false,
                };
                _countEntry2 = new Entry()
                {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Wprowadź ilość surowca",
                };
                _picker3 = new Picker()
                {
                    ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                    Title = "Wybierz surowiec",
                    TitleColor = Color.Gold,
                    
                };
                _idEntry3 = new Entry()
                {
                    Placeholder = "ID",
                    IsVisible = false,
                };
                _countEntry3 = new Entry()
                {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Wprowadź ilość surowca",
                };

                _picker4 = new Picker()
                {
                    ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                    Title = "Wybierz surowiec",
                    TitleColor = Color.Gold,
                    
                };
                _idEntry4 = new Entry()
                {
                    Placeholder = "ID",
                    IsVisible = false,
                };
                _countEntry4 = new Entry()
                {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Wprowadź ilość surowca",
                };
                _picker5 = new Picker()
                {
                    ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                    Title = "Wybierz surowiec",
                    TitleColor = Color.Gold,
                    
                };
                _idEntry5 = new Entry()
                {
                    Placeholder = "ID",
                    IsVisible = false,
                };
                _countEntry5 = new Entry()
                {
                    Keyboard = Keyboard.Text,
                    Placeholder = "Wprowadź ilość surowca",
                };
               
                

            _AddButton = new Button();
            _AddButton.Text = "Dodaj";
            _AddButton.Clicked += _AddButton_Clicked;


            stackLayout.Children.Add(_picker);
            stackLayout.Children.Add(_idEntry);
            stackLayout.Children.Add(_countEntry);
            stackLayout.Children.Add(_picker2);
            stackLayout.Children.Add(_idEntry2);
            stackLayout.Children.Add(_countEntry2);
            stackLayout.Children.Add(_picker3);
            stackLayout.Children.Add(_idEntry3);
            stackLayout.Children.Add(_countEntry3);
            stackLayout.Children.Add(_picker4);
            stackLayout.Children.Add(_idEntry4);
            stackLayout.Children.Add(_countEntry4);
            stackLayout.Children.Add(_picker5);
            stackLayout.Children.Add(_idEntry5);
            stackLayout.Children.Add(_countEntry5);
            stackLayout.Children.Add(_AddButton);
           

            Content = stackLayout;
        }

       

        private async void _AddButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var db = new SQLiteConnection(_dbPath);
                Surowiec surowiec = new Surowiec();
                surowiec = (Surowiec)_picker.SelectedItem;
                surowiec.Count += Convert.ToDouble(_countEntry.Text);
                db.Update(surowiec);
                Surowiec surowiec2 = new Surowiec();
                surowiec2 = (Surowiec)_picker2.SelectedItem;
                surowiec2.Count += Convert.ToDouble(_countEntry2.Text);
                db.Update(surowiec2);
                Surowiec surowiec3 = new Surowiec();
                surowiec3 = (Surowiec)_picker3.SelectedItem;
                surowiec3.Count += Convert.ToDouble(_countEntry3.Text);
                db.Update(surowiec3);
                Surowiec surowiec4 = new Surowiec();
                surowiec4 = (Surowiec)_picker4.SelectedItem;
                surowiec4.Count += Convert.ToDouble(_countEntry4.Text);
                db.Update(surowiec4);
                Surowiec surowiec5 = new Surowiec();
                surowiec5 = (Surowiec)_picker5.SelectedItem;
                surowiec5.Count += Convert.ToDouble(_countEntry5.Text);
                db.Update(surowiec5);
                await Navigation.PopAsync();

            }
            catch
            {
                await Navigation.PopAsync();
            }
        }
    }
}