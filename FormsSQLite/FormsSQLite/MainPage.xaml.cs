using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FormsSQLite;
using System.IO;

namespace FormsSQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn1.Clicked += Btn1clicked;
            btn2.Clicked += Btn2clicked;
            btn3.Clicked += Btn3clicked;
            btnView.Clicked += BtnVWclicked;

        }

       
        private void Btn3clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //LocationItem item = new LocationItem();
        }

        private void Btn1clicked(object sender, EventArgs e)
        {
            LocationItem item1 = new LocationItem()
            {
                Spay = 3000,
                Day = DateTime.Now
            };
            Save(item1);
        }

        public async void Save(LocationItem item1)
        {
            await App.Database.SaveItemAsync(item1);
            await DisplayAlert("DATA1","RECORDED","OK");
        }

        private void Btn2clicked(object sender, EventArgs e)
        {
            LocationItem item2 = new LocationItem()
            {
                Spay = 3000,
                Day = DateTime.Now
            };
            Save(item2);
        }
        public async void Delete(LocationItem item1)
        {
            await App.Database.DeleteItemAsync(item1);
            await DisplayAlert("削除", "", "OK");
        }

        private void BtnVWclicked(object sender, EventArgs e)
        {
                        Navigation.PushModalAsync(new NavigationPage(new ResultPage()));

        }
    }
}
