using Ejercicio1_3PMO2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_3PMO2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {

            var emple = new Models.Persona
            {
                id = Convert.ToInt32(txtid.Text),
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text,
                direccion = txtdireccion.Text
            };

            var result = await App.BaseDatos.StoreEmple(emple);


            var pagina = new Views.PageLista();
            pagina.BindingContext = emple;
            await Navigation.PushAsync(pagina);
        }

        
    }
}
