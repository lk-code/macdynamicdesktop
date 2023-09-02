using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Configuration;

namespace MacDynamicDesktop.SharedViewModels.Management;

public abstract partial class OverviewViewModelBase : ObservableObject
{
    private readonly IConfiguration _configuration;

    [ObservableProperty]
    ObservableCollection<WallpaperArchiveViewModel> _wallpaperCollection = new();
    
    protected OverviewViewModelBase(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    [RelayCommand]
    public async Task OnViewAppearingAsync(CancellationToken cancellationToken)
    {
        // TODO: load
        this.WallpaperCollection.Clear();
        
        this.WallpaperCollection.Add(new ("Windows 11", "/path/to/image"));
        this.WallpaperCollection.Add(new ("Windows 10", "/path/to/image"));
        this.WallpaperCollection.Add(new ("macOS", "/path/to/image"));
    }
}