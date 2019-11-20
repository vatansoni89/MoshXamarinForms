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
            //MainPage = new MDContactsPage();
            //MainPage = new TabbedPageExample();
            //MainPage = new PopupsExample();
            //MainPage = new NavigationPage(new ToolbarItemsExample());
            //MainPage = new ControlsExample();
            //MainPage = new SliderControlExample();
            //MainPage = new StepperControlExample();
            MainPage = new EntryANdeditorControlExample();
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