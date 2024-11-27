using Microsoft.Extensions.Localization;
using LibraryManagement.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LibraryManagement.Web;

[Dependency(ReplaceServices = true)]
public class LibraryManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LibraryManagementResource> _localizer;

    public LibraryManagementBrandingProvider(IStringLocalizer<LibraryManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
