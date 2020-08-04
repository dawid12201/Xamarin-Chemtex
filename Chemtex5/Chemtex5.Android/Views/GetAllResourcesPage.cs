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
    public class GetAllResourcesPage : ContentPage
    {
        private ListView _listView;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");

        public GetAllResourcesPage()
        {
            this.Title = "Surowce";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listView = new ListView();
            _listView.ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList();

            stackLayout.Children.Add(_listView);

            Content = stackLayout;
        }
    }
}