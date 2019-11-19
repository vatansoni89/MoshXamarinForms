using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new StacklayoutExercize1();
            //MainPage = new Instagram();
            //MainPage = new NavigationPage(new ContactsPage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.Yellow
            //};
            MainPage = new MDContactsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}