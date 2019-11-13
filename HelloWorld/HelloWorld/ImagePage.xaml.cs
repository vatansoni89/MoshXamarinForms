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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            var imgSource = (UriImageSource)ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));

            //below commented code also works.
            //var imgSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imgSource.CachingEnabled = false; //by default its true.
            imgSource.CacheValidity = TimeSpan.FromHours(1);

            img1.Source = imgSource;

            //img1.Source = "";
        }
    }
}