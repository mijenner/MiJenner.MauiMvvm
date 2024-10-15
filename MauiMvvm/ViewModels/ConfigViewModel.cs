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
        }

        public async Task LoadPageData()
        {
            try
            {
                await FetchUserSettingsAsync(); 
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Read-problem", "Problems reading user settings", "Ok"); 
                throw;
            }
        }

        [RelayCommand]
        public async Task SaveUserSettingsAsync()
        {
            await settingsService.Save(nameof(UserName), UserName);
            await settingsService.Save(nameof(WantNotifications), WantNotifications);
            await Shell.Current.DisplayAlert("Saved!", "User settings saved", "Ok"); 
        }

        [RelayCommand]
        public async Task FetchUserSettingsAsync()
        {
            UserName = await settingsService.Get(nameof(UserName), "UserName");
            WantNotifications = await settingsService.Get(nameof(WantNotifications), false);
        }
    }
}
