using MyFavoriteWeb.Services;
using Windows.UI.Xaml.Controls;

namespace MyFavoriteWeb
{
    public sealed partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            NavigationService.Navigate<MainPage>();
        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            NavigationService.Navigate<Views.CadastroView>();
        }

        private void HyperlinkButton_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            NavigationService.Navigate<Views.SobreView>();
        }
    }
}
