using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Forms1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Ingresar_Clicked(object sender, EventArgs e)
        {
            var nombre = inputNombre.Text;
            if (!String.IsNullOrEmpty(nombre)) {
                this.Navigation.PushModalAsync(new UserPage(nombre));
            }
        }
    }
}
