using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Ejercicio1_3PMO2.Models;

namespace Ejercicio1_3PMO2
{
    public partial class App : Application
    {

        static PersonaDB basedatos;

        public static PersonaDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new PersonaDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PersonaDB.db3"));
                }
                return basedatos;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
