using MiJenner.ServicesMAUI;

namespace MauiMvvm.ViewModels
{
    public partial class DetailsViewModel : BaseViewModel
    {
        public DetailsViewModel(ISettingsService settingsService, FilePathService filePathService) : base(settingsService, filePathService)
        {
            Title = "Details"; 
        }
    }
}
