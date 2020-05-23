using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        int count = 0;

        private void BtnSumar_Clicked(object sender, EventArgs e)
        {
            count++;
            btnSumar.Text = count.ToString();
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxNombre.Text;
            if (!String.IsNullOrEmpty(nombre)) {
                DisplayAlert("Xamarin Forms", nombre, "Aceptar");
            }
        }
    }
}
