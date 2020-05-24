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
        String nombre;
        public UserPage(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            labelNombre.Text = "Welcome " + nombre;
        }

        private void Atras_Clicked(object sender, EventArgs e) {
            this.Navigation.PushModalAsync(new MainPage());
        }

        private void VerVideo_Clicked(object sender, EventArgs e) {
            this.Navigation.PushModalAsync(new VideoPage(nombre));
        }
    }
}