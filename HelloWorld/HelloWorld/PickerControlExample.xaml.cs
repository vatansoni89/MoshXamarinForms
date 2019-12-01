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
    public partial class PickerControlExample : ContentPage
    {
        public PickerControlExample()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = pkrContactMethod.Items[pkrContactMethod.SelectedIndex];
            DisplayAlert("Selection", contactMethod, "OK");
        }
    }
}