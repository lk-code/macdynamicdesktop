using CommunityToolkit.Mvvm.ComponentModel;

namespace MacDynamicDesktop.SharedViewModels.Management
{

    public partial class WallpaperArchiveViewModel : ObservableObject
    {
        [ObservableProperty]
        string name = string.Empty;

        [ObservableProperty]
        string thumbnailImage = string.Empty;

        public WallpaperArchiveViewModel(string name,
            string thumbnailImage)
        {
            Name = name;
            ThumbnailImage = thumbnailImage;
        }
    }
}