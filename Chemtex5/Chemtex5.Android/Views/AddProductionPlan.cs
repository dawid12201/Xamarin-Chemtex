using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Chemtex5.Models;
using SQLite;
using Xamarin.Forms;

namespace Chemtex5.Views
{
    public class AddProductionPlan : ContentPage
    {
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        List<Surowiec> ResultResources = new List<Surowiec>();
        Button goBackButton = new Button();
        Button addProductsButton = new Button();
        ListView resultMissingListView = new ListView();
        Entry ResultEntry = new Entry();
        private Picker _recipePicker1;
        private Entry _countEntry1;
        private Picker _recipePicker2;
        private Entry _countEntry2;
        private Picker _recipePicker3;
        private Entry _countEntry3;
        private Picker _recipePicker4;
        private Entry _countEntry4;
        private Picker _recipePicker5;
        private Entry _countEntry5;
        private Picker _recipePicker6;
        private Entry _countEntry6;
        private Picker _recipePicker7;
        private Entry _countEntry7;
        private Picker _recipePicker8;
        private Entry _countEntry8;
        private Picker _recipePicker9;
        private Entry _countEntry9;
        private Picker _recipePicker10;
        private Entry _countEntry10;
        private Button _saveButton;
        private Button _countButton;
        Produkt produkt1 = new Produkt();
        Produkt produkt2 = new Produkt();
        Produkt produkt3 = new Produkt();
        Produkt produkt4 = new Produkt();
        Produkt produkt5 = new Produkt();
        Produkt produkt6 = new Produkt();
        Produkt produkt7 = new Produkt();
        Produkt produkt8 = new Produkt();
        Produkt produkt9 = new Produkt();
        Produkt produkt10 = new Produkt();
        Receptura receptura1 = new Receptura();
        string[] surowce1 { get; set; }

        Receptura receptura2 = new Receptura(); 
        string[] surowce2 { get; set; }

        Receptura receptura3 = new Receptura();
        string[] surowce3 { get; set; }

        Receptura receptura4 = new Receptura();
        string[] surowce4 { get; set; }

        Receptura receptura5 = new Receptura();
        string[] surowce5 { get; set; }

        Receptura receptura6 = new Receptura();
        string[] surowce6 { get; set; }

        Receptura receptura7 = new Receptura();
        string[] surowce7 { get; set; }

        Receptura receptura8 = new Receptura();
        string[] surowce8 { get; set; }

        Receptura receptura9 = new Receptura();
        string[] surowce9 { get; set; }

        Receptura receptura10 = new Receptura();
        string[] surowce10 { get; set; }

        Surowiec surowiec1Default = new Surowiec();
        Surowiec surowiec2Default = new Surowiec();
        Surowiec surowiec3Default = new Surowiec();
        Surowiec surowiec4Default = new Surowiec();
        Surowiec surowiec5Default = new Surowiec();
        Surowiec surowiec6Default = new Surowiec();
        Surowiec surowiec7Default = new Surowiec();
        Surowiec surowiec8Default = new Surowiec();
        Surowiec surowiec9Default = new Surowiec();
        Surowiec surowiec10Default = new Surowiec();
        Surowiec surowiec11Default = new Surowiec();
        Surowiec surowiec12Default = new Surowiec();
        Surowiec surowiec13Default = new Surowiec();
        Surowiec surowiec14Default = new Surowiec();
        Surowiec surowiec15Default = new Surowiec();
        Surowiec surowiec16Default = new Surowiec();
        Surowiec surowiec17Default = new Surowiec();
        Surowiec surowiec18Default = new Surowiec();
        Surowiec surowiec19Default = new Surowiec();
        Surowiec surowiec20Default = new Surowiec();

        ScrollView scroll = new ScrollView();

        StackLayout stackLayout = new StackLayout();
        StackLayout resultStackLayout = new StackLayout();
        public AddProductionPlan()
        {
            this.Title = "Plan produkcyjny";

            var db = new SQLiteConnection(_dbPath);
            _recipePicker1 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz pierwszą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry1 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość pierwszego produktu"
            };
            stackLayout.Children.Add(_recipePicker1);
            stackLayout.Children.Add(_countEntry1);
            Receptura receptura = (Receptura)_recipePicker1.SelectedItem;
            
            _recipePicker2 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz drugą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry2 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość drugiego produktu"
            };
            stackLayout.Children.Add(_recipePicker2);
            stackLayout.Children.Add(_countEntry2);
            Receptura receptura2 = (Receptura)_recipePicker2.SelectedItem;

            _recipePicker3 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz trzecią recepturę",
                TitleColor = Color.Gold
            };
            _countEntry3 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość trzeciego produktu"
            };
            stackLayout.Children.Add(_recipePicker3);
            stackLayout.Children.Add(_countEntry3);
            Receptura receptura3 = (Receptura)_recipePicker3.SelectedItem;

            _recipePicker4 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz czwartą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry4 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość czwartego produktu"
            };
            stackLayout.Children.Add(_recipePicker4);
            stackLayout.Children.Add(_countEntry4);
            Receptura receptura4 = (Receptura)_recipePicker4.SelectedItem;

            _recipePicker5 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz piątą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry5 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość piątego produktu"
            };
            stackLayout.Children.Add(_recipePicker5);
            stackLayout.Children.Add(_countEntry5);
            Receptura receptura5 = (Receptura)_recipePicker5.SelectedItem;

            _recipePicker6 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz szóstą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry6 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość szóstego produktu"
            };
            stackLayout.Children.Add(_recipePicker6);
            stackLayout.Children.Add(_countEntry6);
            Receptura receptura6 = (Receptura)_recipePicker6.SelectedItem;

            _recipePicker7 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz siódmą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry7 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość siódmego produktu"
            };
            stackLayout.Children.Add(_recipePicker7);
            stackLayout.Children.Add(_countEntry7);
            Receptura receptura7 = (Receptura)_recipePicker7.SelectedItem;

            _recipePicker8 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz ósmą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry8 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość ósmego produktu"
            };
            stackLayout.Children.Add(_recipePicker8);
            stackLayout.Children.Add(_countEntry8);
            Receptura receptura8 = (Receptura)_recipePicker8.SelectedItem;

            _recipePicker9 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dziewiątą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry9 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość dziewiątego produktu"
            };
            stackLayout.Children.Add(_recipePicker9);
            stackLayout.Children.Add(_countEntry9);
            Receptura receptura9 = (Receptura)_recipePicker9.SelectedItem;

            _recipePicker10 = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz dziesiątą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry10 = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość dziesiątego produktu"
            };
            stackLayout.Children.Add(_recipePicker10);
            stackLayout.Children.Add(_countEntry10);
            Receptura receptura10 = (Receptura)_recipePicker10.SelectedItem;

            _countButton = new Button();
            _countButton.Text = "Oblicz wymagane surowce";
            _countButton.Clicked += _countButton_Clicked;
            stackLayout.Children.Add(_countButton);


            //_saveButton = new Button();
            //_saveButton.Text = "Zapisz plan";
            //_saveButton.Clicked += _saveButton_Clicked;
            //stackLayout.Children.Add(_saveButton);

            scroll.Content = stackLayout;
            Content = scroll;
        }

        private async void AddProductsButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool answer = await DisplayAlert("Czy stworzyć produkty?", "Upewnij się, że masz wystarczające ilości surowców, aby uniknąć ujemnych wartości. Kontynuować produkcję?", "Tak", "Nie");
                if (answer) 
                {
                    var db = new SQLiteConnection(_dbPath);
                    foreach (var c in ResultResources)
                    {
                        var Surowiec = db.Table<Surowiec>().Where(X => X.Name == c.Name).FirstOrDefault();
                        Surowiec.Count = c.Count;
                        db.Update(Surowiec);
                    }
                    db.CreateTable<Produkt>();
                        var maxPK = db.Table<Produkt>().OrderByDescending(c => c.Id).FirstOrDefault();
                        
                    try
                    {
                        produkt1.Id = (maxPK == null ? 1 : maxPK.Id + 1);
                        produkt1.Name = receptura1.Name;
                        produkt1.Count = Convert.ToDouble(_countEntry1.Text);

                        produkt2.Id = (maxPK == null ? 2 : maxPK.Id + 2);
                        produkt2.Name = receptura2.Name;
                        produkt2.Count = Convert.ToDouble(_countEntry2.Text);

                        produkt3.Id = (maxPK == null ? 3 : maxPK.Id + 3);
                        produkt3.Name = receptura3.Name;
                        produkt3.Count = Convert.ToDouble(_countEntry3.Text);

                        produkt4.Id = (maxPK == null ? 4 : maxPK.Id + 4);
                        produkt4.Name = receptura4.Name;
                        produkt4.Count = Convert.ToDouble(_countEntry4.Text);

                        produkt5.Id = (maxPK == null ? 5 : maxPK.Id + 5);
                        produkt5.Name = receptura5.Name;
                        produkt5.Count = Convert.ToDouble(_countEntry5.Text);

                        produkt6.Id = (maxPK == null ? 6 : maxPK.Id + 6);
                        produkt6.Name = receptura6.Name;
                        produkt6.Count = Convert.ToDouble(_countEntry6.Text);

                        produkt7.Id = (maxPK == null ? 7 : maxPK.Id + 7);
                        produkt7.Name = receptura7.Name;
                        produkt7.Count = Convert.ToDouble(_countEntry7.Text);

                        produkt8.Id = (maxPK == null ? 8 : maxPK.Id + 8);
                        produkt8.Name = receptura8.Name;
                        produkt8.Count = Convert.ToDouble(_countEntry8.Text);

                        produkt9.Id = (maxPK == null ? 9 : maxPK.Id + 9);
                        produkt9.Name = receptura9.Name;
                        produkt9.Count = Convert.ToDouble(_countEntry9.Text);

                        produkt10.Id = (maxPK == null ? 10 : maxPK.Id + 10);
                        produkt10.Name = receptura10.Name;
                        produkt10.Count = Convert.ToDouble(_countEntry10.Text);

                        await DisplayAlert(null, "Stworzono produkty i odjęto surowce", "OK");
                        var produkt1Update = db.Table<Produkt>().Where(X => X.Name == produkt1.Name).FirstOrDefault();
                        if (produkt1Update != null) 
                        { 
                            produkt1Update.Count += produkt1.Count; db.Update(produkt1Update); 
                        }
                        else 
                        {
                            if (produkt1.Name != "" && produkt1.Name != null) db.Insert(produkt1);
                        };
                        var produkt2Update = db.Table<Produkt>().Where(X => X.Name == produkt2.Name).FirstOrDefault();

                        if (produkt2Update != null)
                        {
                            produkt2Update.Count += produkt2.Count; db.Update(produkt2Update);
                        }
                        else
                        {
                            if (produkt2.Name != "" && produkt2.Name != null) db.Insert(produkt2);
                        };
                        var produkt3Update = db.Table<Produkt>().Where(X => X.Name == produkt3.Name).FirstOrDefault();

                        if (produkt3Update != null)
                        {
                            produkt3Update.Count += produkt3.Count; db.Update(produkt3Update);
                        }
                        else
                        {
                            if (produkt3.Name != "" && produkt3.Name != null) db.Insert(produkt3);
                        };
                        var produkt4Update = db.Table<Produkt>().Where(X => X.Name == produkt4.Name).FirstOrDefault();

                        if (produkt4Update != null)
                        {
                            produkt4Update.Count += produkt4.Count; db.Update(produkt4Update);
                        }
                        else
                        {
                            if (produkt4.Name != "" && produkt4.Name != null) db.Insert(produkt4);
                        };
                        var produkt5Update = db.Table<Produkt>().Where(X => X.Name == produkt5.Name).FirstOrDefault();

                        if (produkt5Update != null)
                        {
                            produkt5Update.Count += produkt5.Count; db.Update(produkt5Update);
                        }
                        else
                        {
                            if (produkt5.Name != "" && produkt5.Name != null) db.Insert(produkt5);
                        };
                        var produkt6Update = db.Table<Produkt>().Where(X => X.Name == produkt6.Name).FirstOrDefault();

                        if (produkt6Update != null)
                        {
                            produkt6Update.Count += produkt6.Count; db.Update(produkt6Update);
                        }
                        else
                        {
                            if (produkt6.Name != "" && produkt6.Name != null) db.Insert(produkt6);
                        };
                        var produkt7Update = db.Table<Produkt>().Where(X => X.Name == produkt7.Name).FirstOrDefault();

                        if (produkt7Update != null)
                        {
                            produkt7Update.Count += produkt7.Count; db.Update(produkt7Update);
                        }
                        else
                        {
                            if (produkt7.Name != "" && produkt7.Name != null) db.Insert(produkt7);
                        };
                        var produkt8Update = db.Table<Produkt>().Where(X => X.Name == produkt8.Name).FirstOrDefault();

                        if (produkt8Update != null)
                        {
                            produkt8Update.Count += produkt8.Count; db.Update(produkt8Update);
                        }
                        else
                        {
                            if (produkt8.Name != "" && produkt8.Name != null) db.Insert(produkt8);
                        };
                        var produkt9Update = db.Table<Produkt>().Where(X => X.Name == produkt9.Name).FirstOrDefault();

                        if (produkt9Update != null)
                        {
                            produkt9Update.Count += produkt9.Count; db.Update(produkt9Update);
                        }
                        else
                        {
                            if (produkt9.Name != "" && produkt9.Name != null) db.Insert(produkt9);
                        };
                        var produkt10Update = db.Table<Produkt>().Where(X => X.Name == produkt10.Name).FirstOrDefault();

                        if (produkt10Update != null)
                        {
                            produkt10Update.Count += produkt10.Count; db.Update(produkt10Update);
                        }
                        else
                        {
                            if (produkt10.Name != "" && produkt10.Name != null) db.Insert(produkt10);
                        };

                    }
                    catch
                    {
                        await DisplayAlert(null, "Stworzono produkty i odjęto surowce", "OK");
                        var produkt1Update = db.Table<Produkt>().Where(X => X.Name == produkt1.Name).FirstOrDefault();
                        if (produkt1Update != null)
                        {
                            produkt1Update.Count += produkt1.Count; db.Update(produkt1Update);
                        }
                        else
                        {
                            if (produkt1.Name != "" && produkt1.Name != null) db.Insert(produkt1);
                        };
                        var produkt2Update = db.Table<Produkt>().Where(X => X.Name == produkt2.Name).FirstOrDefault();

                        if (produkt2Update != null)
                        {
                            produkt2Update.Count += produkt2.Count; db.Update(produkt2Update);
                        }
                        else
                        {
                            if (produkt2.Name != "" && produkt2.Name != null) db.Insert(produkt2);
                        };
                        var produkt3Update = db.Table<Produkt>().Where(X => X.Name == produkt3.Name).FirstOrDefault();

                        if (produkt3Update != null)
                        {
                            produkt3Update.Count += produkt3.Count; db.Update(produkt3Update);
                        }
                        else
                        {
                            if (produkt3.Name != "" && produkt3.Name != null) db.Insert(produkt3);
                        };
                        var produkt4Update = db.Table<Produkt>().Where(X => X.Name == produkt4.Name).FirstOrDefault();

                        if (produkt4Update != null)
                        {
                            produkt4Update.Count += produkt4.Count; db.Update(produkt4Update);
                        }
                        else
                        {
                            if (produkt4.Name != "" && produkt4.Name != null) db.Insert(produkt4);
                        };
                        var produkt5Update = db.Table<Produkt>().Where(X => X.Name == produkt5.Name).FirstOrDefault();

                        if (produkt5Update != null)
                        {
                            produkt5Update.Count += produkt5.Count; db.Update(produkt5Update);
                        }
                        else
                        {
                            if (produkt5.Name != "" && produkt5.Name != null) db.Insert(produkt5);
                        };
                        var produkt6Update = db.Table<Produkt>().Where(X => X.Name == produkt6.Name).FirstOrDefault();

                        if (produkt6Update != null)
                        {
                            produkt6Update.Count += produkt6.Count; db.Update(produkt6Update);
                        }
                        else
                        {
                            if (produkt6.Name != "" && produkt6.Name != null) db.Insert(produkt6);
                        };
                        var produkt7Update = db.Table<Produkt>().Where(X => X.Name == produkt7.Name).FirstOrDefault();

                        if (produkt7Update != null)
                        {
                            produkt7Update.Count += produkt7.Count; db.Update(produkt7Update);
                        }
                        else
                        {
                            if (produkt7.Name != "" && produkt7.Name != null) db.Insert(produkt7);
                        };
                        var produkt8Update = db.Table<Produkt>().Where(X => X.Name == produkt8.Name).FirstOrDefault();

                        if (produkt8Update != null)
                        {
                            produkt8Update.Count += produkt8.Count; db.Update(produkt8Update);
                        }
                        else
                        {
                            if (produkt8.Name != "" && produkt8.Name != null) db.Insert(produkt8);
                        };
                        var produkt9Update = db.Table<Produkt>().Where(X => X.Name == produkt9.Name).FirstOrDefault();

                        if (produkt9Update != null)
                        {
                            produkt9Update.Count += produkt9.Count; db.Update(produkt9Update);
                        }
                        else
                        {
                            if (produkt9.Name != "" && produkt9.Name != null) db.Insert(produkt9);
                        };
                        var produkt10Update = db.Table<Produkt>().Where(X => X.Name == produkt10.Name).FirstOrDefault();

                        if (produkt10Update != null)
                        {
                            produkt10Update.Count += produkt10.Count; db.Update(produkt10Update);
                        }
                        else
                        {
                            if (produkt10.Name != "" && produkt10.Name != null) db.Insert(produkt10);
                        };
                    }

                    
                }
                else
                {
                    //await DisplayAlert(null, "Anulowano proces produkcji", "OK");
                }
            }
            catch
            {
            }
        }

        private async void _countButton_Clicked(object sender, EventArgs e)
        {
            
            
            try
            {
                //Get all recipes and resources and refactor the strings
                receptura1 = (Receptura)_recipePicker1.SelectedItem;
                surowce1 = receptura1.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura2 = (Receptura)_recipePicker2.SelectedItem;
                surowce2 = receptura2.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura3 = (Receptura)_recipePicker3.SelectedItem;
                surowce3 = receptura3.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura4 = (Receptura)_recipePicker4.SelectedItem;
                surowce4 = receptura4.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura5 = (Receptura)_recipePicker5.SelectedItem;
                surowce5 = receptura5.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura6 = (Receptura)_recipePicker6.SelectedItem;
                surowce6 = receptura6.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura7 = (Receptura)_recipePicker7.SelectedItem;
                surowce7 = receptura7.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura8 = (Receptura)_recipePicker8.SelectedItem;
                surowce8 = receptura8.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura9 = (Receptura)_recipePicker9.SelectedItem;
                surowce9 = receptura9.Surowce.Replace(")", "").Replace("(", "").Split(' ');

                receptura10 = (Receptura)_recipePicker10.SelectedItem;
                surowce10 = receptura10.Surowce.Replace(")", "").Replace("(", "").Split(' ');
            }
            catch 
            { 
            }
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Produkt>();
            var maxPK = db.Table<Produkt>().OrderByDescending(c => c.Id).FirstOrDefault();
            try 
            {

                produkt1.Id = (maxPK == null ? 1 : maxPK.Id + 1);
                produkt1.Name = receptura1.Name;
                produkt1.Count = Convert.ToDouble(_countEntry1.Text);

                produkt2.Id = (maxPK == null ? 2 : maxPK.Id + 2);
                produkt2.Name = receptura2.Name;
                produkt2.Count = Convert.ToDouble(_countEntry2.Text);

                produkt3.Id = (maxPK == null ? 3 : maxPK.Id + 3);
                produkt3.Name = receptura3.Name;
                produkt3.Count = Convert.ToDouble(_countEntry3.Text);

                produkt4.Id = (maxPK == null ? 4 : maxPK.Id + 4);
                produkt4.Name = receptura4.Name;
                produkt4.Count = Convert.ToDouble(_countEntry4.Text);

                produkt5.Id = (maxPK == null ? 5 : maxPK.Id + 5);
                produkt5.Name = receptura5.Name;
                produkt5.Count = Convert.ToDouble(_countEntry5.Text);

                produkt6.Id = (maxPK == null ? 6 : maxPK.Id + 6);
                produkt6.Name = receptura6.Name;
                produkt6.Count = Convert.ToDouble(_countEntry6.Text);

                produkt7.Id = (maxPK == null ? 7 : maxPK.Id + 7);
                produkt7.Name = receptura7.Name;
                produkt7.Count = Convert.ToDouble(_countEntry7.Text);

                produkt8.Id = (maxPK == null ? 8 : maxPK.Id + 8);
                produkt8.Name = receptura8.Name;
                produkt8.Count = Convert.ToDouble(_countEntry8.Text);

                produkt9.Id = (maxPK == null ? 9 : maxPK.Id + 9);
                produkt9.Name = receptura9.Name;
                produkt9.Count = Convert.ToDouble(_countEntry9.Text);

                produkt10.Id = (maxPK == null ? 10 : maxPK.Id + 10);
                produkt10.Name = receptura10.Name;
                produkt10.Count = Convert.ToDouble(_countEntry10.Text);

            }
            catch
            {

            }
            

            #region TryCatches
            try
            {
                string resource1String = surowce1[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce1[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce1[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce1[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce1[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce1[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce1[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce1[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce1[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce1[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce1[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce1[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce1[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce1[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce1[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce1[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce1[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce1[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce1[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce1[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt1.Count * Convert.ToDouble(surowce1[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce2[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce2[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce2[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce2[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce2[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce2[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce2[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce2[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce2[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce2[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce2[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce2[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce2[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce2[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce2[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce2[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce2[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce2[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce2[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce2[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt2.Count * Convert.ToDouble(surowce2[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce3[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce3[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce3[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce3[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce3[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce3[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce3[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce3[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce3[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce3[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce3[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce3[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce3[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce3[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce3[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce3[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce3[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce3[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce3[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce3[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt3.Count * Convert.ToDouble(surowce3[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce4[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce4[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce4[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce4[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce4[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce4[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce4[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce4[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce4[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce4[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce4[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce4[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce4[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce4[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce4[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce4[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce4[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce4[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce4[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce4[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt4.Count * Convert.ToDouble(surowce4[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce5[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce5[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce5[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce5[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce5[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce5[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce5[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce5[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce5[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce5[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce5[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce5[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce5[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce5[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce5[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce5[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce5[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce5[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce5[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce5[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt5.Count * Convert.ToDouble(surowce5[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce6[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce6[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce6[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce6[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce6[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce6[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce6[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce6[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce6[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce6[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce6[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce6[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce6[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce6[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce6[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce6[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce6[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce6[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce6[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce6[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt6.Count * Convert.ToDouble(surowce6[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce7[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce7[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce7[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce7[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce7[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce7[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce7[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce7[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce7[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce7[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce7[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce7[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce7[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce7[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce7[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce7[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce7[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce7[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce7[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce7[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt7.Count * Convert.ToDouble(surowce7[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce8[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce8[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce8[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce8[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce8[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce8[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce8[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce8[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce8[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce8[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce8[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce8[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce8[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce8[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce8[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce8[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce8[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce8[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce8[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce8[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt8.Count * Convert.ToDouble(surowce8[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce9[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce9[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce9[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce9[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce9[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce9[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce9[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce9[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce9[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce9[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce9[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce9[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce9[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce9[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce9[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce9[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce9[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce9[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce9[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce9[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt9.Count * Convert.ToDouble(surowce9[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            try
            {
                string resource1String = surowce10[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                Resource1.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[1])));
                var obj = ResultResources.FirstOrDefault(x => x.Name == Resource1.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[1])));
                else ResultResources.Add(Resource1);

                string resource2String = surowce10[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                Resource2.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[3])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource2.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[3])));
                else ResultResources.Add(Resource2);

                string resource3String = surowce10[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                Resource3.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[5])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource3.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[5])));
                else ResultResources.Add(Resource3);

                string resource4String = surowce10[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                Resource4.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[7])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource4.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[7])));
                else ResultResources.Add(Resource4);

                string resource5String = surowce10[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                Resource5.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[9])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource5.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[9])));
                else ResultResources.Add(Resource5);

                string resource6String = surowce10[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                Resource6.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[11])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource6.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[11])));
                else ResultResources.Add(Resource6);

                string resource7String = surowce10[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                Resource7.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[13])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource7.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[13])));
                else ResultResources.Add(Resource7);

                string resource8String = surowce10[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                Resource8.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[15])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource8.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[15])));
                else ResultResources.Add(Resource8);

                string resource9String = surowce10[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                Resource9.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[17])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource9.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[17])));
                else ResultResources.Add(Resource9);

                string resource10String = surowce10[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                Resource10.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[19])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource10.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[19])));
                else ResultResources.Add(Resource10);

                string resource11String = surowce10[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                Resource11.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[21])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource11.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[21])));
                else ResultResources.Add(Resource11);

                string resource12String = surowce10[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                Resource12.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[23])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource12.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[23])));
                else ResultResources.Add(Resource12);

                string resource13String = surowce10[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                Resource13.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[25])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource13.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[25])));
                else ResultResources.Add(Resource13);

                string resource14String = surowce10[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                Resource14.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[27])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource14.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[27])));
                else ResultResources.Add(Resource14);

                string resource15String = surowce10[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                Resource15.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[29])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource15.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[29])));
                else ResultResources.Add(Resource15);

                string resource16String = surowce10[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                Resource16.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[31])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource16.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[31])));
                else ResultResources.Add(Resource16);

                string resource17String = surowce10[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                Resource17.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[33])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource17.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[33])));
                else ResultResources.Add(Resource17);

                string resource18String = surowce10[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                Resource18.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[35])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource18.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[35])));
                else ResultResources.Add(Resource18);

                string resource19String = surowce10[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                Resource19.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[37])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource19.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[37])));
                else ResultResources.Add(Resource19);

                string resource20String = surowce10[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                Resource20.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[39])));
                obj = ResultResources.FirstOrDefault(x => x.Name == Resource20.Name);
                if (obj != null) obj.Count -= Math.Abs((produkt10.Count * Convert.ToDouble(surowce10[39])));
                else ResultResources.Add(Resource20);

            }
            catch
            {

            }
            #endregion

            ResultEntry.Text = "Wynik surowców:";
            resultStackLayout.Children.Add(ResultEntry);
            resultMissingListView.ItemsSource = ResultResources;
            resultStackLayout.Children.Add(resultMissingListView);


            addProductsButton.Text = "Stwórz produkty";
            addProductsButton.Clicked += AddProductsButton_Clicked;
            resultStackLayout.Children.Add(addProductsButton);

            goBackButton.Text = "Wróc do listy";
            goBackButton.Clicked += GoBackButton_Clicked;
            resultStackLayout.Children.Add(goBackButton);

            Content = resultStackLayout;
        }

        private void GoBackButton_Clicked(object sender, EventArgs e)
        {
            Content = scroll;
            resultStackLayout.Children.Remove(ResultEntry);
            resultStackLayout.Children.Remove(resultMissingListView);
            resultStackLayout.Children.Remove(goBackButton);
            resultStackLayout.Children.Remove(addProductsButton);
            addProductsButton.Clicked -= AddProductsButton_Clicked;
            ResultResources.Clear();
            resultMissingListView.ItemsSource = null;

        }

        private async void _saveButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProdukcjaHomePage());
        }
    }
}