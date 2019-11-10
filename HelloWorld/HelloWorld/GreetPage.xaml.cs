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
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            //To set padding considering different platforms.
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;

                case Device.iOS:
                    Padding = new Thickness(0, 30, 0, 0);
                    break;
            }
        }
    }
}