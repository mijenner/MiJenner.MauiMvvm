using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvm.Views;
using MiJenner.ServicesMAUI;

namespace MauiMvvm.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel(ISettingsService settingsService, FilePathService filePathService) : base(settingsService, filePathService)
        {
            Title = "Main"; 
        }

        [RelayCommand]
        public async Task TestIsBusyAsync()
        {
            IsBusy = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            IsBusy = false; 
        }

        [RelayCommand]
        public async Task GotoConfigAsync()
        {
            await Shell.Current.GoToAsync(nameof(ConfigPage));
        }

        [RelayCommand]
        public async Task GotoDetailsAsync()
        {
            await Shell.Current.GoToAsync(nameof(DetailsPage));
        }
    }
}
