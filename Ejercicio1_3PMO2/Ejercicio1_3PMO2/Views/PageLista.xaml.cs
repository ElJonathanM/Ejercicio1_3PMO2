using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_3PMO2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLista : ContentPage
    {
        public PageLista()
        {
            InitializeComponent();
        }


        //Evento load de un Content Page
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listpersona.ItemsSource = await App.BaseDatos.ListaEmpleados();
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.Persona persona = (Models.Persona)e.CurrentSelection.FirstOrDefault();

            var pag = new PageEliminar();
            pag.BindingContext = persona;
            await Navigation.PushAsync(pag);

        }

    }
}