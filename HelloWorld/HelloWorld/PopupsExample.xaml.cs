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
    public partial class PopupsExample : ContentPage
    {
        public PopupsExample()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "R u sure", "Yes", "No");
            if (response)
            {
                await DisplayAlert("Done", "Response wil be saved", "OK");
            }
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var clickedActionName = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Button1", "Button2", "Button3", "Email");
            await DisplayAlert("ClickedActionName", clickedActionName, "OK");
        }
    }
}