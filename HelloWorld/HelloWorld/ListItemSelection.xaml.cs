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
    public partial class ListItemSelection : ContentPage
    {
        public ListItemSelection()
        {
            InitializeComponent();
            var contactGroups = new List<ContactGroup> {
                new ContactGroup("M","M")
                {
                    new Contact(){ Name = "Matan", Status = "Status1", ImageUrl = "http://lorempixel.com/100/100/city/1/" },
                    new Contact(){ Name = "Matan1", Status = "Status11", ImageUrl = "http://lorempixel.com/100/100/city/1/" },
                },

                new ContactGroup("J","J")
                {
                    new Contact(){ Name = "Jonali", Status = "Status2", ImageUrl = "http://lorempixel.com/100/100/city/2/" }
                }
            };
            listContactGroup.ItemsSource = contactGroups;
        }

        private void listContactGroup_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listContactGroup_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }
    }
}