using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerControlExample : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public PickerControlExample()
        {
            InitializeComponent();
            _contactMethods = GetContactMethods();
            foreach (var method in GetContactMethods())
            {
                pkrContactMethod.Items.Add(method.Name);
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = pkrContactMethod.Items[pkrContactMethod.SelectedIndex];

            //If we wnat to get id then
            var contactItem = _contactMethods.Single(x => x.Name == name);

            DisplayAlert("Selection", name + " ID:" + contactItem.Id, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod> {
                new ContactMethod { Id=101, Name="SMS"},
                new ContactMethod { Id=102, Name="Email"},
                new ContactMethod { Id=103, Name="Pager"},
            };
        }
    }
}