﻿using MacDynamicDesktop.WinUI.Core.Models;

namespace MacDynamicDesktop.WinUI.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
