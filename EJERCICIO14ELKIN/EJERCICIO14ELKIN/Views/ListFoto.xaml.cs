using EJERCICIO14ELKIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EJERCICIO14ELKIN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFoto : ContentPage
    {
        public ListFoto()
        {
            InitializeComponent();
        }

        private async void ListaFoto_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var foto = (Foto)e.Item;
            Photo pagFoto = new Photo();
            pagFoto.BindingContext = foto;
            await Navigation.PushAsync(pagFoto);


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();//recargara de nuevo la lista
            ListaFoto.ItemsSource = await App.DBase.getListFoto();//Espera coleccion de elementos para enumerar en la forma que queramos
        }

        private async void mRegistro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}