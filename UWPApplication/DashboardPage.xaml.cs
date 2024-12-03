using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPApplication
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class DashboardPage : Page
    {
        private DispatcherTimer _timer;

        public DashboardPage()
        {
            this.InitializeComponent();
            // Animer l'apparition du message de bienvenue
            AnimateWelcomeMessage();

            // Timer pour afficher le contenu dynamique après 2 secondes
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(0.5);  // 2 secondes avant de dévoiler le contenu dynamique
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        // Animation du message de bienvenue
        private void AnimateWelcomeMessage()
        {
            // Créer une animation pour l'élément WelcomeMessage
            var fadeInAnimation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            Storyboard.SetTarget(fadeInAnimation, WelcomeMessage);
            Storyboard.SetTargetProperty(fadeInAnimation, "Opacity");

            // Créer un storyboard pour l'animation
            var storyboard = new Storyboard();
            storyboard.Children.Add(fadeInAnimation);
            storyboard.Begin();
        }

        // Lorsque le timer expire, afficher le contenu dynamique
        private void Timer_Tick(object sender, object e)
        {
            _timer.Stop(); // Arrêter le timer

            // Rendre le contenu dynamique visible
            DynamicContent.Visibility = Visibility.Visible;

            // Créer une animation d'apparition pour le contenu dynamique
            var slideInAnimation = new DoubleAnimation
            {
                From = 100,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };

            Storyboard.SetTarget(slideInAnimation, DynamicContent);
            Storyboard.SetTargetProperty(slideInAnimation, "(UIElement.RenderTransform).(TranslateTransform.Y)");

            // Appliquer une transformation pour déplacer le contenu dynamique
            DynamicContent.RenderTransform = new TranslateTransform();
            var storyboard = new Storyboard();
            storyboard.Children.Add(slideInAnimation);
            storyboard.Begin();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}