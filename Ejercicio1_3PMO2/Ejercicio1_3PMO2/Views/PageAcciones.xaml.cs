using Ejercicio1_3PMO2.Models;
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
    public partial class PageEliminar : ContentPage
    {
        public PageEliminar()
        {
            InitializeComponent();

        }

        private async void btnborrar_Clicked(object sender, EventArgs e)
        {
            var emple = await App.BaseDatos.ObtenerEmpleados(Convert.ToInt32(txtid.Text));
            if (emple != null)
            {
                await App.BaseDatos.DeleteEmple(emple);
                await DisplayAlert("Aviso", "Eliminado Correctamente", "OK");
                await Navigation.PopAsync();
            }
        }

        private async void btnactualizar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                Persona emple = new Persona()
                {
                    id = Convert.ToInt32(txtid.Text),
                    nombre = txtnombre.Text,
                    apellidos = txtapellido.Text,
                    edad = Convert.ToInt32(txtedad.Text),
                    correo = txtcorreo.Text,
                    direccion = txtdireccion.Text
                };
                await App.BaseDatos.StoreEmple(emple);
                await DisplayAlert("Aviso", "Actualizado Correctamente", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}