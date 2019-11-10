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
    public partial class QuotesPage : ContentPage
    {
        public string[] Arr { get; set; }
        public int count { get; set; } = 0;

        public QuotesPage()
        {
            InitializeComponent();
            Arr = new string[] { "This is statement 1", "This is statement 2" };
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            lblNext.Text = Arr[count % 2];
            count++;
        }
    }
}