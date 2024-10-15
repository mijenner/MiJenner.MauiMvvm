using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MiJenner.ServicesMAUI;

namespace MauiMvvm.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string companyName = "MyCompany a/s";
        [ObservableProperty]
        private string appName = "My Smart App";
        [ObservableProperty]
        private string version = "0.95beta";

        [ObservableProperty]
        private string title = string.Empty;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy = false;
        public bool IsNotBusy => !IsBusy;

        [ObservableProperty]
        string filePath;

        FilePathService filePathService;
        ISettingsService settingsService;

        [ObservableProperty]
        string userName;
        [ObservableProperty]
        bool wantNotifications; 

        public BaseViewModel(ISettingsService settingsService, FilePathService filePathService)
        {
            this.filePathService = filePathService;
            this.settingsService = settingsService;
            UserName = "Kurt"; 
            WantNotifications = true;
        }




        [RelayCommand]
        public async Task GetFilePathAsync()
        {
            FilePath = this.filePathService.GetFilePath(FileTypeEnum.Settings);
        }

        [RelayCommand]
        public async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
