using MacDynamicDesktop.SharedViewModels.Management;
using Microsoft.Extensions.Configuration;

namespace MacDynamicDesktop.ViewModels.Management;

public partial class OverviewViewModel : OverviewViewModelBase
{
    public OverviewViewModel(IConfiguration configuration)
        : base(configuration)
    {
    }
}