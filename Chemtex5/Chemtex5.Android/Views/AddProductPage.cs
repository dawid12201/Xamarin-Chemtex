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
    public class AddProductPage : ContentPage
    {
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "myDB.db3");
        private Picker _recipePicker;
        private Entry _countEntry;
        private Button _saveButton;

        StackLayout stackLayout = new StackLayout();
        public AddProductPage()
        {
            
            this.Title = "Stwórz produkt";

            var db = new SQLiteConnection(_dbPath);

            _recipePicker = new Picker()
            {
                ItemsSource = db.Table<Receptura>().OrderBy(x => x.Name).ToList(),
                Title = "Wybierz pierwszą recepturę",
                TitleColor = Color.Gold
            };
            _countEntry = new Entry()
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Ilość pierwszego produktu"
            };
            stackLayout.Children.Add(_recipePicker);
            stackLayout.Children.Add(_countEntry);
            Receptura receptura = (Receptura)_recipePicker.SelectedItem;
            _saveButton = new Button();
            _saveButton.Text = "Dodaj produkt";
            _saveButton.Clicked += _saveButton_Clicked;
            stackLayout.Children.Add(_saveButton);


            Content = stackLayout;
        }

        private bool IsEnoughResource(Surowiec surowiec, Produkt produkt, double surowiecAmount)
        {
            if (surowiec.Count < produkt.Count * surowiecAmount) return false;
            else return true;
        }

        private async void _saveButton_Clicked(object sender, EventArgs e)
        {


            try
            {
                Receptura receptura = (Receptura)_recipePicker.SelectedItem;
                string surowiec1 = receptura.Surowce.Replace(")", "");
                string surowiec2 = surowiec1.Replace("(", "");
                string[] surowce = surowiec2.Split(' ');
                var db = new SQLiteConnection(_dbPath);
                db.CreateTable<Produkt>();
                var maxPK = db.Table<Produkt>().OrderByDescending(c => c.Id).FirstOrDefault();
                Produkt produkt = new Produkt()
                {
                    Id = (maxPK == null ? 1 : maxPK.Id + 1),
                    Name = receptura.Name,
                    Count = Convert.ToDouble(_countEntry.Text)
                };

                string resource1String = surowce[0];
                var Resource1 = db.Table<Surowiec>().Where(c => c.Name == resource1String).FirstOrDefault();
                var resource1Previous = Resource1.Count;
                if (IsEnoughResource(Resource1, produkt, Convert.ToDouble(surowce[1])))
                {
                    Resource1.Count -= (produkt.Count * Convert.ToDouble(surowce[1]));
                    db.Update(Resource1);
                    db.Insert(produkt);
                }
                else
                {
                    double iloscBrakuje = -(Resource1.Count - (produkt.Count * Convert.ToDouble(surowce[1])));
                    string brakujeSurowca = "Brakuje " + Resource1.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    
                }

                string resource2String = surowce[2];
                var Resource2 = db.Table<Surowiec>().Where(c => c.Name == resource2String).FirstOrDefault();
                var resource2Previous = Resource2.Count;
                if (IsEnoughResource(Resource2, produkt, Convert.ToDouble(surowce[3])))
                {
                    Resource2.Count -= (produkt.Count * Convert.ToDouble(surowce[3]));
                    db.Update(Resource2);
                }
                else
                {
                    double iloscBrakuje = -(Resource2.Count - (produkt.Count * Convert.ToDouble(surowce[3])));
                    string brakujeSurowca = "Brakuje " + Resource2.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    db.Delete(produkt);
                }

                string resource3String = surowce[4];
                var Resource3 = db.Table<Surowiec>().Where(c => c.Name == resource3String).FirstOrDefault();
                var resource3Previous = Resource3.Count;
                if (IsEnoughResource(Resource3, produkt, Convert.ToDouble(surowce[5])))
                {
                    Resource3.Count -= (produkt.Count * Convert.ToDouble(surowce[5]));
                    db.Update(Resource3);
                }
                else
                {
                    double iloscBrakuje = -(Resource3.Count - (produkt.Count * Convert.ToDouble(surowce[5])));
                    string brakujeSurowca = "Brakuje " + Resource3.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);

                    db.Delete(produkt);
                }

                string resource4String = surowce[6];
                var Resource4 = db.Table<Surowiec>().Where(c => c.Name == resource4String).FirstOrDefault();
                var resource4Previous = Resource4.Count;
                if (IsEnoughResource(Resource4, produkt, Convert.ToDouble(surowce[7])))
                {
                    Resource4.Count -= (produkt.Count * Convert.ToDouble(surowce[7]));
                    db.Update(Resource4);
                }
                else
                {
                    double iloscBrakuje = -(Resource4.Count - (produkt.Count * Convert.ToDouble(surowce[7])));
                    string brakujeSurowca = "Brakuje " + Resource4.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    db.Delete(produkt);
                }


                string resource5String = surowce[8];
                var Resource5 = db.Table<Surowiec>().Where(c => c.Name == resource5String).FirstOrDefault();
                var resource5Previous = Resource5.Count;
                if (IsEnoughResource(Resource5, produkt, Convert.ToDouble(surowce[9])))
                {
                    Resource5.Count -= (produkt.Count * Convert.ToDouble(surowce[9]));
                    db.Update(Resource5);
                }
                else
                {
                    double iloscBrakuje = -(Resource5.Count - (produkt.Count * Convert.ToDouble(surowce[9])));
                    string brakujeSurowca = "Brakuje " + Resource5.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    db.Delete(produkt);
                }
                string resource6String = surowce[10];
                var Resource6 = db.Table<Surowiec>().Where(c => c.Name == resource6String).FirstOrDefault();
                var resource6Previous = Resource6.Count;
                if (IsEnoughResource(Resource6, produkt, Convert.ToDouble(surowce[11])))
                {
                    Resource6.Count -= (produkt.Count * Convert.ToDouble(surowce[11]));
                    db.Update(Resource6);
                }
                else
                {
                    double iloscBrakuje = -(Resource6.Count - (produkt.Count * Convert.ToDouble(surowce[11])));
                    string brakujeSurowca = "Brakuje " + Resource6.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    db.Delete(produkt);
                }
                string resource7String = surowce[12];
                var Resource7 = db.Table<Surowiec>().Where(c => c.Name == resource7String).FirstOrDefault();
                var resource7Previous = Resource7.Count;
                if (IsEnoughResource(Resource7, produkt, Convert.ToDouble(surowce[13])))
                {
                    Resource7.Count -= (produkt.Count * Convert.ToDouble(surowce[13]));
                    db.Update(Resource7);
                }
                else
                {
                    double iloscBrakuje = -(Resource7.Count - (produkt.Count * Convert.ToDouble(surowce[13])));
                    string brakujeSurowca = "Brakuje " + Resource7.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    db.Delete(produkt);
                }
                string resource8String = surowce[14];
                var Resource8 = db.Table<Surowiec>().Where(c => c.Name == resource8String).FirstOrDefault();
                var resource8Previous = Resource8.Count;
                if (IsEnoughResource(Resource8, produkt, Convert.ToDouble(surowce[15])))
                {
                    Resource8.Count -= (produkt.Count * Convert.ToDouble(surowce[15]));
                    db.Update(Resource8);
                }
                else
                {
                    double iloscBrakuje = -(Resource8.Count - (produkt.Count * Convert.ToDouble(surowce[15])));
                    string brakujeSurowca = "Brakuje " + Resource8.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    db.Delete(produkt);
                }
                string resource9String = surowce[16];
                var Resource9 = db.Table<Surowiec>().Where(c => c.Name == resource9String).FirstOrDefault();
                var resource9Previous = Resource9.Count;
                if (IsEnoughResource(Resource9, produkt, Convert.ToDouble(surowce[17])))
                {
                    Resource9.Count -= (produkt.Count * Convert.ToDouble(surowce[17]));
                    db.Update(Resource9);
                }
                else
                {
                    double iloscBrakuje = -(Resource9.Count - (produkt.Count * Convert.ToDouble(surowce[17])));
                    string brakujeSurowca = "Brakuje " + Resource9.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    db.Delete(produkt);
                }

                string resource10String = surowce[18];
                var Resource10 = db.Table<Surowiec>().Where(c => c.Name == resource10String).FirstOrDefault();
                var resource10Previous = Resource10.Count;
                if (IsEnoughResource(Resource10, produkt, Convert.ToDouble(surowce[19])))
                {
                    Resource10.Count -= (produkt.Count * Convert.ToDouble(surowce[19]));
                    db.Update(Resource10);
                }
                else
                {
                    double iloscBrakuje = -(Resource10.Count - (produkt.Count * Convert.ToDouble(surowce[19])));
                    string brakujeSurowca = "Brakuje " + Resource10.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    db.Delete(produkt);
                }

                string resource11String = surowce[20];
                var Resource11 = db.Table<Surowiec>().Where(c => c.Name == resource11String).FirstOrDefault();
                var resource11Previous = Resource11.Count;
                if (IsEnoughResource(Resource11, produkt, Convert.ToDouble(surowce[21])))
                {
                    Resource11.Count -= (produkt.Count * Convert.ToDouble(surowce[21]));
                    db.Update(Resource11);
                }
                else
                {
                    double iloscBrakuje = -(Resource11.Count - (produkt.Count * Convert.ToDouble(surowce[21])));
                    string brakujeSurowca = "Brakuje " + Resource11.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    db.Delete(produkt);
                }

                string resource12String = surowce[22];
                var Resource12 = db.Table<Surowiec>().Where(c => c.Name == resource12String).FirstOrDefault();
                var resource12Previous = Resource12.Count;
                if (IsEnoughResource(Resource12, produkt, Convert.ToDouble(surowce[23])))
                {
                    Resource12.Count -= (produkt.Count * Convert.ToDouble(surowce[23]));
                    db.Update(Resource12);
                }
                else
                {
                    double iloscBrakuje = -(Resource12.Count - (produkt.Count * Convert.ToDouble(surowce[23])));
                    string brakujeSurowca = "Brakuje " + Resource12.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    db.Delete(produkt);
                }

                string resource13String = surowce[24];
                var Resource13 = db.Table<Surowiec>().Where(c => c.Name == resource13String).FirstOrDefault();
                var resource13Previous = Resource13.Count;
                if (IsEnoughResource(Resource13, produkt, Convert.ToDouble(surowce[25])))
                {
                    Resource13.Count -= (produkt.Count * Convert.ToDouble(surowce[25]));
                    db.Update(Resource13);
                }
                else
                {
                    double iloscBrakuje = -(Resource13.Count - (produkt.Count * Convert.ToDouble(surowce[25])));
                    string brakujeSurowca = "Brakuje " + Resource13.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    db.Delete(produkt);
                }

                string resource14String = surowce[26];
                var Resource14 = db.Table<Surowiec>().Where(c => c.Name == resource14String).FirstOrDefault();
                var resource14Previous = Resource14.Count;
                if (IsEnoughResource(Resource14, produkt, Convert.ToDouble(surowce[27])))
                {
                    Resource14.Count -= (produkt.Count * Convert.ToDouble(surowce[27]));
                    db.Update(Resource14);
                }
                else
                {
                    double iloscBrakuje = -(Resource14.Count - (produkt.Count * Convert.ToDouble(surowce[27])));
                    string brakujeSurowca = "Brakuje " + Resource14.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    db.Delete(produkt);
                }

                string resource15String = surowce[28];
                var Resource15 = db.Table<Surowiec>().Where(c => c.Name == resource15String).FirstOrDefault();
                var resource15Previous = Resource15.Count;
                if (IsEnoughResource(Resource15, produkt, Convert.ToDouble(surowce[29])))
                {
                    Resource15.Count -= (produkt.Count * Convert.ToDouble(surowce[29]));
                    db.Update(Resource15);
                }
                else
                {
                    double iloscBrakuje = -(Resource15.Count - (produkt.Count * Convert.ToDouble(surowce[29])));
                    string brakujeSurowca = "Brakuje " + Resource15.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    db.Delete(produkt);
                }

                string resource16String = surowce[30];
                var Resource16 = db.Table<Surowiec>().Where(c => c.Name == resource16String).FirstOrDefault();
                var resource16Previous = Resource16.Count;
                if (IsEnoughResource(Resource16, produkt, Convert.ToDouble(surowce[31])))
                {
                    Resource16.Count -= (produkt.Count * Convert.ToDouble(surowce[31]));
                    db.Update(Resource16);
                }
                else
                {
                    double iloscBrakuje = -(Resource16.Count - (produkt.Count * Convert.ToDouble(surowce[31])));
                    string brakujeSurowca = "Brakuje " + Resource16.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    Resource15.Count = resource15Previous;
                    db.Update(Resource15);
                    db.Delete(produkt);
                }

                string resource17String = surowce[32];
                var Resource17 = db.Table<Surowiec>().Where(c => c.Name == resource17String).FirstOrDefault();
                var resource17Previous = Resource17.Count;
                if (IsEnoughResource(Resource17, produkt, Convert.ToDouble(surowce[33])))
                {
                    Resource17.Count -= (produkt.Count * Convert.ToDouble(surowce[33]));
                    db.Update(Resource17);
                }
                else
                {
                    double iloscBrakuje = -(Resource17.Count - (produkt.Count * Convert.ToDouble(surowce[33])));
                    string brakujeSurowca = "Brakuje " + Resource17.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    Resource15.Count = resource15Previous;
                    db.Update(Resource15);
                    Resource16.Count = resource16Previous;
                    db.Update(Resource16);
                    db.Delete(produkt);
                }

                string resource18String = surowce[34];
                var Resource18 = db.Table<Surowiec>().Where(c => c.Name == resource18String).FirstOrDefault();
                var resource18Previous = Resource18.Count;
                if (IsEnoughResource(Resource18, produkt, Convert.ToDouble(surowce[35])))
                {
                    Resource18.Count -= (produkt.Count * Convert.ToDouble(surowce[35]));
                    db.Update(Resource18);
                }
                else
                {
                    double iloscBrakuje = -(Resource18.Count - (produkt.Count * Convert.ToDouble(surowce[35])));
                    string brakujeSurowca = "Brakuje " + Resource18.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    Resource15.Count = resource15Previous;
                    db.Update(Resource15);
                    Resource16.Count = resource16Previous;
                    db.Update(Resource16);
                    Resource17.Count = resource17Previous;
                    db.Update(Resource17);
                    db.Delete(produkt);
                }

                string resource19String = surowce[36];
                var Resource19 = db.Table<Surowiec>().Where(c => c.Name == resource19String).FirstOrDefault();
                var resource19Previous = Resource19.Count;
                if (IsEnoughResource(Resource19, produkt, Convert.ToDouble(surowce[37])))
                {
                    Resource19.Count -= (produkt.Count * Convert.ToDouble(surowce[37]));
                    db.Update(Resource19);
                }
                else
                {
                    double iloscBrakuje = -(Resource19.Count - (produkt.Count * Convert.ToDouble(surowce[37])));
                    string brakujeSurowca = "Brakuje " + Resource19.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    Resource15.Count = resource15Previous;
                    db.Update(Resource15);
                    Resource16.Count = resource16Previous;
                    db.Update(Resource16);
                    Resource17.Count = resource17Previous;
                    db.Update(Resource17);
                    Resource18.Count = resource18Previous;
                    db.Update(Resource18);
                    db.Delete(produkt);
                }

                string resource20String = surowce[38];
                var Resource20 = db.Table<Surowiec>().Where(c => c.Name == resource20String).FirstOrDefault();
                var resource20Previous = Resource20.Count;
                if (IsEnoughResource(Resource20, produkt, Convert.ToDouble(surowce[39])))
                {
                    Resource20.Count -= (produkt.Count * Convert.ToDouble(surowce[39]));
                    db.Update(Resource20);
                }
                else
                {
                    double iloscBrakuje = -(Resource20.Count - (produkt.Count * Convert.ToDouble(surowce[39])));
                    string brakujeSurowca = "Brakuje " + Resource20.Name + " W ilosci: " + iloscBrakuje;
                    await DisplayAlert(null, brakujeSurowca, "OK");
                    Resource1.Count = resource1Previous;
                    db.Update(Resource1);
                    Resource2.Count = resource2Previous;
                    db.Update(Resource2);
                    Resource3.Count = resource3Previous;
                    db.Update(Resource3);
                    Resource4.Count = resource4Previous;
                    db.Update(Resource4);
                    Resource5.Count = resource5Previous;
                    db.Update(Resource5);
                    Resource6.Count = resource6Previous;
                    db.Update(Resource6);
                    Resource7.Count = resource7Previous;
                    db.Update(Resource7);
                    Resource8.Count = resource8Previous;
                    db.Update(Resource8);
                    Resource9.Count = resource9Previous;
                    db.Update(Resource9);
                    Resource10.Count = resource10Previous;
                    db.Update(Resource10);
                    Resource11.Count = resource11Previous;
                    db.Update(Resource11);
                    Resource12.Count = resource12Previous;
                    db.Update(Resource12);
                    Resource13.Count = resource13Previous;
                    db.Update(Resource13);
                    Resource14.Count = resource14Previous;
                    db.Update(Resource14);
                    Resource15.Count = resource15Previous;
                    db.Update(Resource15);
                    Resource16.Count = resource16Previous;
                    db.Update(Resource16);
                    Resource17.Count = resource17Previous;
                    db.Update(Resource17);
                    Resource18.Count = resource18Previous;
                    db.Update(Resource18);
                    Resource19.Count = resource19Previous;
                    db.Update(Resource19);
                    db.Delete(produkt);
                }
                //await DisplayAlert(null, "Dodano produkt i zaktualizowano surowce", "OK");
                await Navigation.PopAsync();
            }
            catch
            {
                //await DisplayAlert(null, "Dodano produkt i zaktualizowano surowce", "OK");
                await Navigation.PopAsync();
            }

        }
    }
}