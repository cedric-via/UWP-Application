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
        private DispatcherTimer _timer;
        private int _progressValue = 0;

        public MainPage()
        {
            this.InitializeComponent();

            // Initialisation du timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(25);  // Mise à jour toutes les 100 ms
            _timer.Tick += Timer_Tick;

            // Démarrer le timer pour animer la barre de progression
            _timer.Start();
        }

        // Cette fonction est appelée à chaque "Tick" du timer
        private void Timer_Tick(object sender, object e)
        {
            _progressValue += 2;  // Augmenter la valeur de la barre de progression

            // Mettre à jour la barre de progression et le texte
            ProgressBar.Value = _progressValue;
            PercentageText.Text = $"Chargement . . . {_progressValue}%";

            // Si la barre atteint 100%, arrêter le timer et naviguer vers le dashboard
            if (_progressValue >= 100)
            {
                _timer.Stop();
                NavigateToDashboard();
            }
        }

        // Fonction pour rediriger vers le tableau de bord
        private void NavigateToDashboard()
        {
            // Vous pouvez remplacer cette ligne par votre propre logique de navigation
            this.Frame.Navigate(typeof(DashboardPage));
        }
    }
}

