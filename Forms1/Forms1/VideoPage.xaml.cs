
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
    public partial class VideoPage : ContentPage
    {
        String nombre; //Variable tipo String
        public VideoPage(String nombre) //Constructor con un parametro tipo String
        {
            InitializeComponent();
            //Asigna a la variable 'nombre' creada por fuera del constructor el valor ingresado por el paramentro String 'nombre'
            this.nombre = nombre; 
            webView.Source = "https://www.youtube.com/embed/IzDOrn77fGs"; //Asigna la url que se va a mostrar en el WebView
            labelNombreUsuario.Text = "Hello " + nombre + " watch the video!"; //Mensaje que se muestra en labelNombreUsuario
        }

        //Método que al dar click al botón abre la ventana MainPage(HomePage)
        private void IrAHome_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new MainPage());  // Realiza la navegación a la ventana MainPage(HomePage)
        }

        //Método que al dar click al botón abre la ventana UserPage
        private void IrAUserPage_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new UserPage(nombre)); // Realiza la navegación a la ventana MainPage
        }
    }
}