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
            StartPageAnimations();
        }

        // Fonction pour démarrer les animations sur la page de démarrage
        private async void StartPageAnimations()
        {
            // Animation du logo (fade-in)
            LogoImage.Opacity = 0;
            await LogoImage.FadeInAsync(1000);  // Fade-in du logo en 1 seconde

            // Animation du texte de bienvenue (fade-in)
            WelcomeText.Opacity = 0;
            await WelcomeText.FadeInAsync(500);  // Fade-in du texte en 1.5 secondes
        }

        // Action de clic sur le bouton "Commencer"
        private void OnStartButtonClick(object sender, RoutedEventArgs e)
        {
            // Navigation vers la page principale (Dashboard)
            this.Frame.Navigate(typeof(Dashboard));  
        }

        // Action quand la souris entre dans le bouton
        private void StartButton_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            // Animation de changement de couleur au survol
            var animation = new DoubleAnimation
            {
                From = 1.0,
                To = 0.5,
                Duration = new Duration(TimeSpan.FromMilliseconds(200))
            };

            Storyboard.SetTarget(animation, StartButton);
            Storyboard.SetTargetProperty(animation, "Opacity");

            var storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        // Action quand la souris quitte le bouton
        private void StartButton_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            // Animation pour revenir à la transparence initiale
            var animation = new DoubleAnimation
            {
                From = 0.5,
                To = 1.0,
                Duration = new Duration(TimeSpan.FromMilliseconds(200))
            };

            Storyboard.SetTarget(animation, StartButton);
            Storyboard.SetTargetProperty(animation, "Opacity");

            var storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }
    }

    // Extension pour l'animation de fondu
    public static class UIExtensions
    {
        public static async Task FadeInAsync(this UIElement element, double duration)
        {
            var fadeIn = new Windows.UI.Xaml.Media.Animation.DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Windows.UI.Xaml.Duration(TimeSpan.FromMilliseconds(duration))
            };

            var storyboard = new Windows.UI.Xaml.Media.Animation.Storyboard();
            storyboard.Children.Add(fadeIn);
            Windows.UI.Xaml.Media.Animation.Storyboard.SetTarget(fadeIn, element);
            Windows.UI.Xaml.Media.Animation.Storyboard.SetTargetProperty(fadeIn, "Opacity");

            storyboard.Begin();
            await Task.Delay((int)duration);
        }
    }
}

