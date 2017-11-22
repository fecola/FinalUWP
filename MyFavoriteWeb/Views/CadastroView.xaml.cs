using MyFavoriteWeb.Services;
using System;
using Windows.Foundation;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

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

        private async void OpenCamera(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.AllowCropping = true;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(300, 300);
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;

            var storageFile = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (storageFile == null)
            {
                //operação cancelada
            }
            else
            {
                using (var stream = await storageFile.OpenReadAsync())
                {
                    var bitmap = new BitmapImage();
                    await bitmap.SetSourceAsync(stream);
                    imgAvatar.Source = bitmap;
                }
            }
        }

        private void imgFoto_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            Image img = sender as Image;
            BitmapImage fallbackImage = new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png"));
            img.Width = 100;
            img.Source = fallbackImage;
        }
    }
}
