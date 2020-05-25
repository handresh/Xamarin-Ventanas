using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        String nombre; //Variable tipo String
        public UserPage(String nombre) //Constructor
        { 
            InitializeComponent(); //Compila el archivo MainPage.xaml
            //Asigna a la variable 'nombre' creada por fuera del constructor el valor ingresado por el paramentro String 'nombre'
            this.nombre = nombre; 
            labelNombre.Text = "Welcome " + nombre; //Mensaje que se muestra en labelNombre
        }

        //Método que al dar click al botón regresa al MainPage(HomePage)
        private void Atras_Clicked(object sender, EventArgs e) {
            this.Navigation.PushModalAsync(new MainPage()); // Realiza la navegación a la ventana MainPage(HomePage)
        }

        //Método que al dar click al botón abre la venta de VideoPage
        private void VerVideo_Clicked(object sender, EventArgs e) {
            this.Navigation.PushModalAsync(new VideoPage(nombre)); // Realiza la navegación a la ventana VideoPage
        }
    }
}