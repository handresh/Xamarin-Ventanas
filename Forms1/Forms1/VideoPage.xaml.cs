
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
        String nombre;
        public VideoPage(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
            webView.Source = "https://www.youtube.com/embed/IzDOrn77fGs";
            labelNombreUsuario.Text = "Hello " + nombre + " watch the video!";
        }
        private void IrAHome_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new MainPage());
        }
        private void IrAUserPage_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new UserPage(nombre));
        }
    }
}