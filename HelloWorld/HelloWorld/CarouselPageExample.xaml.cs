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
    public partial class CarouselPageExample : CarouselPage
    {
        public CarouselPageExample()
        {
            InitializeComponent();

            //Children.Add(Only Content Page Can be added.)
        }
    }
}