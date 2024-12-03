using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using System.Windows;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPApplication
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>


    public sealed partial class CloudPage : Page
    {
        private DispatcherTimer progressTimer;
        private double progressValue = 75; // Valeur initiale de la barre de progression

        public CloudPage()
        {
            this.InitializeComponent();
        }
        // Gestion du clic sur le bouton "Dashboard"
        private void OnDashboardButtonClick(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la page de tableau de bord
            Frame.Navigate(typeof(Dashboard));
        }

        // Gestion du clic sur le bouton "Cloud"
        private void OnCloudButtonClick(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la page des projets
            Frame.Navigate(typeof(CloudPage));
        }

        // Gestion du clic sur le bouton "Paramètres"
        private void OnSettingsButtonClick(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la page des paramètres
            Frame.Navigate(typeof(Dashboard));
        }

        // Gestion du clic sur le bouton "Déconnexion"
        private void OnLogoutButtonClick(object sender, RoutedEventArgs e)
        {
            // Effectuer la déconnexion et revenir à la page d'accueil
            Frame.Navigate(typeof(MainPage));
        }
    }
}
