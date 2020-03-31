using ListView_Edson_Estados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView_Edson_Estados
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lista.ItemsSource = new List<Estados>
            {
                new Estados {Nome = "São Paulo", Capital = "São Paulo", ImagemUrl = "sp.png"},
                new Estados {Nome = "Pernambuco", Capital = "Recife", ImagemUrl = "pe.png"},
                new Estados {Nome = "Rio Grande do Norte", Capital = "Natal", ImagemUrl = "rn.png"},
                new Estados {Nome = "Minas Gerais", Capital = "Belo Horizonte", ImagemUrl = "mg.png"},
                new Estados {Nome = "Bahia", Capital = "Salvador", ImagemUrl = "ba.png"}
            };           
        }

        public void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var estado = e.SelectedItem as Estados;
            DisplayAlert($"Estado: {estado.Nome}", $"Capital: {estado.Capital}", "Ok");
        }
        public void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var estado = e.Item as Estados;
            DisplayAlert($"Estado: {estado.Nome}", $"Capital: {estado.Capital}", "Ok");
        }

        ListView HeaderList = new ListView()
        {
            Header = "Header",
            Footer = "Footer"
        };
    }
}
