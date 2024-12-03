using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApplication
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            StartProgressBar();
        }

        // Lancer la progression et rediriger après
        private async void StartProgressBar()
        {
            // Initialisation du pourcentage
            double value = 0;
            ProgressBar.Value = value;
            PercentageText.Text = $"{value}%";

            // Animation de la barre de progression sur 5 secondes
            while (value < 100)
            {
                value += 1;
                ProgressBar.Value = value;
                PercentageText.Text = $"{value}%";  // Mise à jour du texte du pourcentage
                await System.Threading.Tasks.Task.Delay(20);  // Délai de 50ms pour l'animation
            }

            // Après la fin de la progression, rediriger vers la page Dashboard
            Frame.Navigate(typeof(Dashboard));
        }
    }
}

