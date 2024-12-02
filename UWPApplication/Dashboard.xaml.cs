using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPApplication
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();
        }
        // Gestion du clic sur le bouton "Dashboard"
        private void OnDashboardButtonClick(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la page de tableau de bord
            Frame.Navigate(typeof(Dashboard));
        }

        // Gestion du clic sur le bouton "Projets"
        private void OnProjectsButtonClick(object sender, RoutedEventArgs e)
        {
            // Naviguer vers la page des projets
            Frame.Navigate(typeof(Dashboard));
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
