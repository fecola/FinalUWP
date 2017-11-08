using MyFavoriteWeb.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFavoriteWeb
{
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; } = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Initialize();
        }

        private void WebView_Click(object sender, RoutedEventArgs e)
        {
            frameNavigation.Navigate(typeof(Views.NavegadorWebView));
        }

        private void ListaSites_Click(object sender, RoutedEventArgs e)
        {
            frameNavigation.Navigate(typeof(Views.ListaSitesView));
        }

        private void Cadastro_Click(object sender, RoutedEventArgs e)
        {
            frameNavigation.Navigate(typeof(Views.CadastroView));
        }

        private void Sobre_Click(object sender, RoutedEventArgs e)
        {
            frameNavigation.Navigate(typeof(Views.SobreView));
        }

        private void Configuracao_Click(object sender, RoutedEventArgs e)
        {
            frameNavigation.Navigate(typeof(Views.SobreView));
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}
