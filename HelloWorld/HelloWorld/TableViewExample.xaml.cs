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
    public partial class TableViewExample : ContentPage
    {
        public TableViewExample()
        {
            InitializeComponent();
        }

        private void EntryCell_Completed(object sender, EventArgs e)
        {
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}