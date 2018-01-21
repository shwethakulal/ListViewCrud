using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewCrud
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddBtn(object sender, EventArgs e)
        {
            Item additem = new Item();
            additem.ItemName = entryText.Text;
            await App.Database.SaveItemAsync(additem);
            RefreshListView();
        }
        private async void DeleteItem(object sender,EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            int itemId = (Int32)clickedBtn.CommandParameter;
            Item item = await App.Database.GetItemAsync(itemId);
            await App.Database.DeleteItemAsync(item);
            RefreshListView();
        }

        private async void RefreshListView()
        {
            //To get data from Database
            List<Item> allitems = await App.Database.GetItemsAsync();           
            listView.ItemsSource = allitems;

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            RefreshListView();
        }
    }
}
