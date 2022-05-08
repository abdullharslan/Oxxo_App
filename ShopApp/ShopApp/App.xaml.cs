using ShopApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TappedHome()); 
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
