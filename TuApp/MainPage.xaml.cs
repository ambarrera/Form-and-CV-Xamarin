using System.Collections.Generic;
using System;
using Xamarin.Forms;

namespace TuApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            string nombre = entryNombre.Text;
            string apellido = entryApellido.Text;
            DateTime fechaNacimiento = datePickerFechaNacimiento.Date;
            string ocupacion = entryOcupacion.Text;
            string telefono = entryTelefono.Text;
            string email = entryEmail.Text;
            string nacionalidad = pickerNacionalidad.SelectedItem.ToString();
            string nivelIngles = pickerNivelIngles.SelectedItem.ToString();
            List<string> lenguajes = new List<string>();
            foreach (var item in listViewLenguajes.SelectedItems)
            {
                lenguajes.Add(item.ToString());
            }
            List<string>
                aptitudes = new List<string>
                    ();
            foreach (var item in listViewAptitudes.SelectedItems)
            {
                aptitudes.Add(item.ToString());
            }
            List<string>
                   habilidades = new List<string>
                       ();
            foreach (var item in listViewHabilidades.SelectedItems)
            {
                habilidades.Add(item.ToString());
            }
            string perfil = editorPerfil.Text;

            await DisplayAlert("CV Creado", "¡Se ha creado tu CV personalizado!", "OK");
        }
    }
}

