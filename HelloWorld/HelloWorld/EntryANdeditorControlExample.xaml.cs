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
    public partial class EntryANdeditorControlExample : ContentPage
    {
        public EntryANdeditorControlExample()
        {
            InitializeComponent();
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            lblName.Text = "Completed";
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblName.Text = e.NewTextValue;
        }
    }
}