using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Chemtex5.Models;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class GetAllProductsPage : ContentPage
    {
        private ListView _listView;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public GetAllProductsPage()
        {
            this.Title = "Produkty";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Produkt>().OrderBy(x => x.Name).ToList();

            stackLayout.Children.Add(_listView);
            Content = stackLayout;
        }
    }
}