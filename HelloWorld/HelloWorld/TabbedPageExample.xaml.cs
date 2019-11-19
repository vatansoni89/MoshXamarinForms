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
    public partial class TabbedPageExample : TabbedPage
    {
        public TabbedPageExample()
        {
            InitializeComponent();
            ///
            //Add method add to ICollection of Page so any type of page can be added.
            ///
            //this.Children.Add(new ContentPage());
            //this.Children.Add(new NavigationPage(new ContentPage()));
            //this.Children.Add(new GridPage());
        }
    }
}