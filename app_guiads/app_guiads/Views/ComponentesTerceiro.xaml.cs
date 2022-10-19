using app_guiads.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_guiads.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação  ",
                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação. ",
                    ValoresAtitudes = "Estimular atitudes respeitosas; \nIncentivar comportamentos éticos; \nDesenvolver a criticidade.  "
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
                    Nome = "Programação de Aplicativos Mobile II ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis. ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações; \nIncentivar a criatividade; \nEstimular a organização "
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
                    Nome = "Programação Web III  ",
                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para web ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações; \nFortalecer a persistência e o interesse na resolução de situações-problema; \nIncentivar a criatividade. "
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
                    Nome = "Qualidade e Teste de Software  ",
                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. • Elaborar registros e planilhas de acompanhamento e controle das atividades.  ",
                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações; \nEstimular a proatividade; \nDesenvolver criticidade; \nIncentivar comportamentos éticos "
                };

                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas   ",
                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.  ",
                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas; \nDemonstrar comprometimento com equipe e o trabalho.  "
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