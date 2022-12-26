using QuetesApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuetesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WelcomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
