using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Chemtex5.Views
{
    public class ImportDBPage : ContentPage
    {
        string _dbToGoToPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "ExportedDB.db3");
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public ImportDBPage()
        {
            this.Title = "Importuj bazę danych";
            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Importuj baze danych";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);
            Content = stackLayout;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try 
            {

                if (File.Exists(_dbPath)) File.Delete(_dbPath);
                File.Copy(_dbToGoToPath, _dbPath);
                await DisplayAlert(null, "Import bazy danych powiódł się ze ścieżki " + _dbToGoToPath, "OK");
                await Navigation.PopAsync();
            }
            catch
            {
                await DisplayAlert(null, "Wystąpił błąd przy próbie importu bazy danych", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}