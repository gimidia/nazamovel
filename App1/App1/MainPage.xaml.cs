using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MostraLista(Object sender, EventArgs e)
        {
            //ListaRefeicoes tela = new ListaRefeicoes();
            if (edtNomeEmail.Text == "giba" && edtSenha.Text == "123")
            {
                await DisplayAlert("Aviso", "Login Aceito", "Ok");
                await Navigation.PushAsync(new ListaRefeicoes());
            }
            else
            {
                //if (edtNomeEmail.Text != "giba" & edtSenha.Text != "123")
                await DisplayAlert("Aviso", "Login não Aceito", "Ok");
            }
                       
                       
            
        }
    }
}
