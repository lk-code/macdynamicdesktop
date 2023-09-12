using MacDynamicDesktop.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace MacDynamicDesktop.WinUI.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class GalleryPage : Page
{
    public GalleryViewModel ViewModel
    {
        get;
    }

    public GalleryPage()
    {
        ViewModel = App.GetService<GalleryViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
