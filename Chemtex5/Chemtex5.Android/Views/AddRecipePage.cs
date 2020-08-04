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
    public class AddRecipePage : ContentPage
    {
        private Entry _nameEntry;
        private Picker _reagentPicker1;
        private Picker _reagentPicker2;
        private Picker _reagentPicker3;
        private Picker _reagentPicker4;
        private Picker _reagentPicker5;
        private Picker _reagentPicker6;
        private Picker _reagentPicker7;
        private Picker _reagentPicker8;
        private Picker _reagentPicker9;
        private Picker _reagentPicker10;
        private Picker _reagentPicker11;
        private Picker _reagentPicker12;
        private Picker _reagentPicker13;
        private Picker _reagentPicker14;
        private Picker _reagentPicker15;
        private Picker _reagentPicker16;
        private Picker _reagentPicker17;
        private Picker _reagentPicker18;
        private Picker _reagentPicker19;
        private Picker _reagentPicker20;
        private Entry _countEntry1;
        private Entry _countEntry2;
        private Entry _countEntry3;
        private Entry _countEntry4;
        private Entry _countEntry5;
        private Entry _countEntry6;
        private Entry _countEntry7;
        private Entry _countEntry8;
        private Entry _countEntry9;
        private Entry _countEntry10;
        private Entry _countEntry11;
        private Entry _countEntry12;
        private Entry _countEntry13;
        private Entry _countEntry14;
        private Entry _countEntry15;
        private Entry _countEntry16;
        private Entry _countEntry17;
        private Entry _countEntry18;
        private Entry _countEntry19;
        private Entry _countEntry20;
        private Button _saveButton;

        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");

        public AddRecipePage()
        {
            this.Title = "Dodaj recepturę";

            var db = new SQLiteConnection(_dbPath);
            ScrollView scroll = new ScrollView();
            StackLayout stackLayout = new StackLayout();

            _nameEntry = new Entry();
            _nameEntry.Keyboard = Keyboard.Text;
            _nameEntry.Placeholder = "Nazwa receptury";

            _reagentPicker1 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz pierwszy surowiec",
                TitleColor = Color.Gold
            };

            _countEntry1 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker2 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz drugi surowiec",
                TitleColor = Color.Gold
            };

            _countEntry2 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker3 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz trzeci surowiec",
                TitleColor = Color.Gold
            };

            _countEntry3 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker4 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz czwarty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry4 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker5 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz piąty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry5 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker6 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz szósty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry6 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker7 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz siódmy surowiec",
                TitleColor = Color.Gold
            };

            _countEntry7 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker8 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz ósmy surowiec",
                TitleColor = Color.Gold
            };

            _countEntry8 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker9 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dziewiąty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry9 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker10 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dziesiąty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry10 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker11 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz jedenasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry11 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker12 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dwunasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry12 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker13 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz trzynasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry13 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker14 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz czternasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry14 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker15 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz piętnasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry15 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker16 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz szesnasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry16 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker17 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz siedemnasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry17 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker18 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz osiemnasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry18 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker19 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dziewiętnasty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry19 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };
            _reagentPicker20 = new Picker()
            {
                ItemsSource = db.Table<Surowiec>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dwudziesty surowiec",
                TitleColor = Color.Gold
            };

            _countEntry20 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość surowca"
            };


            stackLayout.Children.Add(_nameEntry);
            stackLayout.Children.Add(_reagentPicker1);
            stackLayout.Children.Add(_countEntry1);
            stackLayout.Children.Add(_reagentPicker2);
            stackLayout.Children.Add(_countEntry2);
            stackLayout.Children.Add(_reagentPicker3);
            stackLayout.Children.Add(_countEntry3);
            stackLayout.Children.Add(_reagentPicker4);
            stackLayout.Children.Add(_countEntry4);
            stackLayout.Children.Add(_reagentPicker5);
            stackLayout.Children.Add(_countEntry5);
            stackLayout.Children.Add(_reagentPicker6);
            stackLayout.Children.Add(_countEntry6);
            stackLayout.Children.Add(_reagentPicker7);
            stackLayout.Children.Add(_countEntry7);
            stackLayout.Children.Add(_reagentPicker8);
            stackLayout.Children.Add(_countEntry8);
            stackLayout.Children.Add(_reagentPicker9);
            stackLayout.Children.Add(_countEntry9);
            stackLayout.Children.Add(_reagentPicker10);
            stackLayout.Children.Add(_countEntry10);
            stackLayout.Children.Add(_reagentPicker11);
            stackLayout.Children.Add(_countEntry11);
            stackLayout.Children.Add(_reagentPicker12);
            stackLayout.Children.Add(_countEntry12);
            stackLayout.Children.Add(_reagentPicker13);
            stackLayout.Children.Add(_countEntry13);
            stackLayout.Children.Add(_reagentPicker14);
            stackLayout.Children.Add(_countEntry14);
            stackLayout.Children.Add(_reagentPicker15);
            stackLayout.Children.Add(_countEntry15);
            stackLayout.Children.Add(_reagentPicker16);
            stackLayout.Children.Add(_countEntry16);
            stackLayout.Children.Add(_reagentPicker17);
            stackLayout.Children.Add(_countEntry17);
            stackLayout.Children.Add(_reagentPicker18);
            stackLayout.Children.Add(_countEntry18);
            stackLayout.Children.Add(_reagentPicker19);
            stackLayout.Children.Add(_countEntry19);
            stackLayout.Children.Add(_reagentPicker20);
            stackLayout.Children.Add(_countEntry20);

            _saveButton = new Button()
            {
                Text = "Zapisz recepturę"
            };
            _saveButton.Clicked += _saveButton_Clicked;

            stackLayout.Children.Add(_saveButton);
            scroll.Content = stackLayout;

            Content = scroll;
        }

        private async void _saveButton_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Receptura>();

            var maxPk = db.Table<Receptura>().OrderByDescending(c => c.Id).FirstOrDefault();
            Receptura receptura = new Receptura()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = _nameEntry.Text,
                Surowce = ""
            };
            try
            {
            


                
                Surowiec surowiec1 = (Surowiec)_reagentPicker1.SelectedItem;
            surowiec1.Count = Convert.ToDouble(_countEntry1.Text);
            receptura.Surowce = receptura.Surowce + surowiec1.Name +" (" + surowiec1.Count + ") ";
            Surowiec surowiec2 = (Surowiec)_reagentPicker2.SelectedItem;
            surowiec2.Count = Convert.ToDouble(_countEntry2.Text);
                receptura.Surowce = receptura.Surowce + surowiec2.Name + " (" + surowiec2.Count + ") ";
                Surowiec surowiec3 = (Surowiec)_reagentPicker3.SelectedItem;
            surowiec3.Count = Convert.ToDouble(_countEntry3.Text);
                receptura.Surowce = receptura.Surowce + surowiec3.Name + " (" + surowiec3.Count + ") ";
                Surowiec surowiec4 = (Surowiec)_reagentPicker4.SelectedItem;
            surowiec4.Count = Convert.ToDouble(_countEntry4.Text);
                receptura.Surowce = receptura.Surowce + surowiec4.Name + " (" + surowiec4.Count + ") ";
                Surowiec surowiec5 = (Surowiec)_reagentPicker5.SelectedItem;
            surowiec5.Count = Convert.ToDouble(_countEntry5.Text);
                receptura.Surowce = receptura.Surowce + surowiec5.Name + " (" + surowiec5.Count + ") ";
                Surowiec surowiec6 = (Surowiec)_reagentPicker6.SelectedItem;
            surowiec6.Count = Convert.ToDouble(_countEntry6.Text);
                receptura.Surowce = receptura.Surowce + surowiec6.Name + " (" + surowiec6.Count + ") ";
                Surowiec surowiec7 = (Surowiec)_reagentPicker7.SelectedItem;
            surowiec7.Count = Convert.ToDouble(_countEntry7.Text);
                receptura.Surowce = receptura.Surowce + surowiec7.Name + " (" + surowiec7.Count + ") ";
                Surowiec surowiec8 = (Surowiec)_reagentPicker8.SelectedItem;
            surowiec8.Count = Convert.ToDouble(_countEntry8.Text);
                receptura.Surowce = receptura.Surowce + surowiec8.Name + " (" + surowiec8.Count + ") ";
                Surowiec surowiec9 = (Surowiec)_reagentPicker9.SelectedItem;
            surowiec9.Count = Convert.ToDouble(_countEntry9.Text);
                receptura.Surowce = receptura.Surowce + surowiec9.Name + " (" + surowiec9.Count + ") ";
                Surowiec surowiec10 = (Surowiec)_reagentPicker10.SelectedItem;
            surowiec10.Count = Convert.ToDouble(_countEntry10.Text);
                receptura.Surowce = receptura.Surowce + surowiec10.Name + " (" + surowiec10.Count + ") ";
                Surowiec surowiec11 = (Surowiec)_reagentPicker11.SelectedItem;
            surowiec11.Count = Convert.ToDouble(_countEntry11.Text);
                receptura.Surowce = receptura.Surowce + surowiec11.Name + " (" + surowiec11.Count + ") ";
                Surowiec surowiec12 = (Surowiec)_reagentPicker12.SelectedItem;
            surowiec12.Count = Convert.ToDouble(_countEntry12.Text);
                receptura.Surowce = receptura.Surowce + surowiec12.Name + " (" + surowiec12.Count + ") ";
                Surowiec surowiec13 = (Surowiec)_reagentPicker13.SelectedItem;
            surowiec13.Count = Convert.ToDouble(_countEntry13.Text);
                receptura.Surowce = receptura.Surowce + surowiec13.Name + " (" + surowiec13.Count + ") ";
                Surowiec surowiec14 = (Surowiec)_reagentPicker14.SelectedItem;
            surowiec14.Count = Convert.ToDouble(_countEntry14.Text);
                receptura.Surowce = receptura.Surowce + surowiec14.Name + " (" + surowiec14.Count + ") ";
                Surowiec surowiec15 = (Surowiec)_reagentPicker15.SelectedItem;
            surowiec15.Count = Convert.ToDouble(_countEntry15.Text);
                receptura.Surowce = receptura.Surowce + surowiec15.Name + " (" + surowiec15.Count + ") ";
                Surowiec surowiec16 = (Surowiec)_reagentPicker16.SelectedItem;
            surowiec16.Count = Convert.ToDouble(_countEntry16.Text);
                receptura.Surowce = receptura.Surowce + surowiec16.Name + " (" + surowiec16.Count + ") ";
                Surowiec surowiec17 = (Surowiec)_reagentPicker17.SelectedItem;
            surowiec17.Count = Convert.ToDouble(_countEntry17.Text);
                receptura.Surowce = receptura.Surowce + surowiec17.Name + " (" + surowiec17.Count + ") ";
                Surowiec surowiec18 = (Surowiec)_reagentPicker18.SelectedItem;
            surowiec18.Count = Convert.ToDouble(_countEntry18.Text);
                receptura.Surowce = receptura.Surowce + surowiec18.Name + " (" + surowiec18.Count + ") ";
                Surowiec surowiec19 = (Surowiec)_reagentPicker19.SelectedItem;
            surowiec19.Count = Convert.ToDouble(_countEntry19.Text);
                receptura.Surowce = receptura.Surowce + surowiec19.Name + " (" + surowiec19.Count + ") ";
                Surowiec surowiec20 = (Surowiec)_reagentPicker20.SelectedItem;
            surowiec20.Count = Convert.ToDouble(_countEntry20.Text);
                receptura.Surowce = receptura.Surowce + surowiec20.Name + " (" + surowiec20.Count + ") ";





                db.Insert(receptura);
            await DisplayAlert(null, receptura.Name + " zapisano", "OK");
            await Navigation.PopAsync();
            }
            catch
            {
                db.Insert(receptura);
                await Navigation.PopAsync();
            }
        }
    }
}