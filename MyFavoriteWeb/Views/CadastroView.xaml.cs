using MyFavoriteWeb.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFavoriteWeb.Views
{
    public sealed partial class CadastroView : Page
    {
        public CadastroView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
