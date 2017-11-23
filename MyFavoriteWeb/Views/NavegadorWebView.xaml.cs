using System;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MyFavoriteWeb.Views
{
    public sealed partial class NavegadorWebView : Page
    {
        public NavegadorWebView()
        {
            InitializeComponent();
            //webView.ContainsFullScreenElementChanged += (WebView sender, object args) =>
            //{
            //    var applicationView = ApplicationView.GetForCurrentView();

            //    if (sender.ContainsFullScreenElement)
            //    {
            //        applicationView.TryEnterFullScreenMode();
            //    }
            //    else if (applicationView.IsFullScreenMode)
            //    {
            //        applicationView.ExitFullScreenMode();
            //    }
            //};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webView.Source = new Uri(site.Text);
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog($"A página {webView.Source} foi salva com sucesso!", "Página da web");
            await msg.ShowAsync();
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double remainingWidth = Window.Current.Bounds.Width;
            webView.Width = remainingWidth;
            webView.Height = e.NewSize.Height;
        }
    }
}
