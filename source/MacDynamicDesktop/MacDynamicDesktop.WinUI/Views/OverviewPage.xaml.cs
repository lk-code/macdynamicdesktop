using CommunityToolkit.WinUI.UI.Controls;

using MacDynamicDesktop.WinUI.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace MacDynamicDesktop.WinUI.Views;

public sealed partial class OverviewPage : Page
{
    public OverviewViewModel ViewModel
    {
        get;
    }

    public OverviewPage()
    {
        ViewModel = App.GetService<OverviewViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
