using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFavoriteWeb.Views
{
    public sealed partial class NavegadorWebView : Page
    {
        public NavegadorWebView()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webView.Source = new Uri(txtSite.Text);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog($"A página {webView.Source} foi salva com sucesso!", "Página da web");
            await msg.ShowAsync();
        }
    }
}
