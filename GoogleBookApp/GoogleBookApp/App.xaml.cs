using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GoogleBookApp.Services;
using GoogleBookApp.Pages;
using Xamarin.Essentials;

namespace GoogleBookApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            if(!Preferences.ContainsKey("GoogleUrl"))
                Preferences.Set("GoogleUrl", "https://www.googleapis.com");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
