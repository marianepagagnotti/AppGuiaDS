using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using app_guiads.Models;

namespace app_guiads.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento de Sistemas",
                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.  ",
                    ValoresAtitudes = "Estimular a organização; \nIncentivar a criatividade; \nFortalecer a persistência e o interesse na resolução de situações-problema.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados II ",
                    AtribuicoesResponsabilidades = "Implementar banco de dados. ",
                    ValoresAtitudes = "Incentivar a criatividade; \nDesenvolver a criticidade;\n Fortalecer a persistência e o interesse na resolução de situações-problema "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas Embarcados  ",
                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados.  ",
                    ValoresAtitudes = "Fortalecer a persistência e o interesse na resolução de situações-problema; \nEstimular a organização; \nIncentivar a criatividade. "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile I ",
                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas móveis. ",
                    ValoresAtitudes = "Incentivar a criatividade; \nResponsabilizar-se pela produção, utilização e divulgação de informações; \nEstimular a organização.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web II",
                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações; \nFortalecer a persistência e o interesse na resolução de situações-problema; \nIncentivar a criatividade.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional  ",
                    AtribuicoesResponsabilidades = "Atuar de acordo com princípios éticos nas relações de trabalho.  ",
                    ValoresAtitudes = "Estimular atitudes respeitosas; \nIncentivar comportamentos éticos; \nComprometer-se com a igualdade de direitos.  "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}