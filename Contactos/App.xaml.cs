using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static string RUTA_DB;
        public App(string ruta_bd)
        {
            InitializeComponent();
            MainPage = new MainPage();
            RUTA_DB = ruta_bd;
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
