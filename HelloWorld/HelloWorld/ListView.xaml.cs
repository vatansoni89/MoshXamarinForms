using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
            var names = new List<ContactGroup> {
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
            lstNames.ItemsSource = names;
        }
    }
}