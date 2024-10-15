using CommunityToolkit.Mvvm.Input;
using MiJenner.ServicesMAUI;

namespace MauiMvvm.ViewModels
{
    public partial class ConfigViewModel : BaseViewModel
    {
        ISettingsService settingsService;
        FilePathService filePathService; 

        public ConfigViewModel(ISettingsService settingsService, FilePathService filePathService) : base(settingsService, filePathService)
        {
            Title = "Config";
            this.settingsService = settingsService;
            this.filePathService = filePathService;
            // SaveUserSettingsAsync(); 
            FetchUserSettingsAsync();

        }

        [RelayCommand]
        public async Task SaveUserSettingsAsync()
        {
            await settingsService.Save(nameof(UserName), UserName);
            await settingsService.Save(nameof(WantNotifications), WantNotifications);
        }

        [RelayCommand]
        public async Task FetchUserSettingsAsync()
        {
            UserName = await settingsService.Get(nameof(UserName), "UserName");
            WantNotifications = await settingsService.Get(nameof(WantNotifications), false);
        }
    }
}
