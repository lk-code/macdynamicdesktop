using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Configuration;

namespace MacDynamicDesktop.SharedViewModels.Management
{
    public abstract partial class OverviewViewModelBase : ObservableObject
    {
        private readonly IConfiguration _configuration;

        [ObservableProperty]
        ObservableCollection<WallpaperArchiveViewModel> _wallpaperCollection = new ObservableCollection<WallpaperArchiveViewModel>();

        protected OverviewViewModelBase(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [RelayCommand]
        public async Task OnViewAppearingAsync(CancellationToken cancellationToken)
        {
            // TODO: load
            this.WallpaperCollection.Clear();

            this.WallpaperCollection.Add(new WallpaperArchiveViewModel("Windows 11", "/path/to/image"));
            this.WallpaperCollection.Add(new WallpaperArchiveViewModel("Windows 10", "/path/to/image"));
            this.WallpaperCollection.Add(new WallpaperArchiveViewModel("macOS", "/path/to/image"));
        }
    }
}