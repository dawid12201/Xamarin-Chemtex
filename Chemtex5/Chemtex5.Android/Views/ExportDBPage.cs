using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.OS;
using Chemtex5.Droid;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class ExportDBPage : ContentPage
    {
        //string _dbToGoToPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "ExportedDB.db3");
      
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public ExportDBPage()
        {
            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Eksportuj baze danych";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);
            Content = stackLayout;
  
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var docPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
            var filepath = Path.Combine(docPath, "ExportedDB.db3");
            try
            {
                if (File.Exists(filepath)) File.Delete(filepath);
                File.Copy(_dbPath, filepath);
                await DisplayAlert(null, "Eksport bazy danych powiódł się do ścieżki: "+ docPath, "OK");
                await Navigation.PopAsync();
            }
            catch (Exception exception)
            {
                await DisplayAlert(null, exception.ToString(), "OK");
                await Navigation.PopAsync();
            }
        }
    }
}