using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Contact> {
                    new Contact(){ Name = "Matan", Status = "Status1", ImageUrl = "http://lorempixel.com/100/100/city/1/" },
                    new Contact(){ Name = "Matan1", Status = "Status11", ImageUrl = "http://lorempixel.com/100/100/city/1/" },
                    new Contact(){ Name = "Jonali", Status = "Status2", ImageUrl = "http://lorempixel.com/100/100/city/2/" }
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Navigation.PushAsync(new ContactDetailPage(contact));
        }
    }
}