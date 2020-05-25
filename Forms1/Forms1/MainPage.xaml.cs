using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Forms1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage //Constructor con un parametro tipo String
    {
        public MainPage() //Constructor
        {
            InitializeComponent(); //Compila el archivo MainPage.xaml
        }

        //Método que al dar click al botón abre la ventana UserPage
        private void Ingresar_Clicked(object sender, EventArgs e)
        {
            var nombre = inputNombre.Text; //Variable de tipo implicito
            if (!String.IsNullOrEmpty(nombre)) { //Verifica que el nombre escrito sea diferente de nulo o vacio
                this.Navigation.PushModalAsync(new UserPage(nombre)); // Realiza la navegación a la ventana UserPage
            }
        }
    }
}
