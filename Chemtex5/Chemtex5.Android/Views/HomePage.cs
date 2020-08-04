using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Chemtex5;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class HomePage : ContentPage
    {
        string _dbToGoToPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "ExportedDB.db3");
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        public HomePage()
        {
            this.Title = "Surowce";

            StackLayout stackLayout = new StackLayout();
            Button button = new Button();
            button.Text = "Dodaj surowiec";
            button.Clicked += Button_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Pokaż surowce";
            button.Clicked += Button_Get_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Edytuj surowce";
            button.Clicked += Button_Edit_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Usuń surowce";
            button.Clicked += Button_Delete_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Eksportuj bazę danych";
            button.Clicked += Button_DBExport_Clicked;
            stackLayout.Children.Add(button);

            button = new Button();
            button.Text = "Importuj bazę danych";
            button.Clicked += Button_DBImport_Clicked;
            stackLayout.Children.Add(button);

            Content = stackLayout;
        }

        private async void Button_DBImport_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_dbToGoToPath))
                {
                    if (File.Exists(_dbPath)) File.Delete(_dbPath); 
                }
                File.Copy(_dbToGoToPath, _dbPath);
                await DisplayAlert(null, "Import bazy danych powiódł się ze ścieżki " + _dbToGoToPath, "OK");
                
            }
            catch
            {
                await DisplayAlert(null, "Nie udało się importować bazy danych. Upewnij się, że znajduje się ona w głównym folderze androida pod nazwą 'ExportedDB.db3' (wielkość liter ma znaczenie) ", "OK");
            }
        }

        private async void Button_DBExport_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(_dbToGoToPath)) File.Delete(_dbToGoToPath);
                File.Copy(_dbPath, _dbToGoToPath);
                await DisplayAlert(null, "Eksport bazy danych powiódł się do ścieżki: " + _dbToGoToPath, "OK");
            }
            catch
            {
                await DisplayAlert(null, "Eksport bazy danych nie powiódł się, upewnij się, czy dałeś aplikacji pozwolenie na zapisywanie poza jej wewnętrzną przestrzenią", "OK");
            }
        }

        private async void Button_Delete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteResourcesPage());
        }

        private async void Button_Edit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditResourcePage());
        }

        private async void Button_Get_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetAllResourcesPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddResourcePage());
        }
    }
}