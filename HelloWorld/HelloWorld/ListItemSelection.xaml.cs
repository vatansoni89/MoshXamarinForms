using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListItemSelection : ContentPage
    {
        public ObservableCollection<Contact> ListContact { get; set; }
        public string SearchString { get; set; }

        public ListItemSelection()
        {
            InitializeComponent();
            ListContact = GetAllContacts();
            listContact.ItemsSource = ListContact;
        }

        public ObservableCollection<Contact> GetAllContacts()
        {
            ListContact = new ObservableCollection<Contact> {
                    new Contact(){ Name = "Matan", Status = "Status1", ImageUrl = "http://lorempixel.com/100/100/city/1/" },
                    new Contact(){ Name = "Matan1", Status = "Status11", ImageUrl = "http://lorempixel.com/100/100/city/1/" },

                    new Contact(){ Name = "Jonali", Status = "Status2", ImageUrl = "http://lorempixel.com/100/100/city/2/" }
            };
            return ListContact;
        }

        private void listContact_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listContact_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            ListContact.Remove(contact);
            GetSearchedContacts(SearchString);
        }

        private void listContact_Refreshing(object sender, EventArgs e)
        {
            listContact.ItemsSource = GetAllContacts();
            listContact.EndRefresh(); // listContact.IsRefreshing = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchString = e.NewTextValue;
            GetSearchedContacts(SearchString);
        }

        public void GetSearchedContacts(string str)
        {
            if (!string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str))
            {
                var tempList = ListContact.Where(x => x.Name.ToLower().Contains(str.ToLower()));
                listContact.ItemsSource = tempList;
            }
            else
            {
                listContact.ItemsSource = ListContact;
            }
        }
    }
}