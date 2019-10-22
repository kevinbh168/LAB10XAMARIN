using Ejercicio08.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio08
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage = new Operaciones();
            //MainPage = new Views.Operaciones();
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
