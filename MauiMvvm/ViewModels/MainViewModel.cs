using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MiJenner.ServicesMAUI;

namespace MauiMvvm.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        string filePath; 

        FilePathService filePathService; 

        public MainViewModel(FilePathService filePathService) 
        {
            this.filePathService = filePathService;
        }

        [RelayCommand]
        public async Task GetFilePathAsync()
        {
            FilePath = this.filePathService.GetFilePath(FileTypeEnum.Settings);
        }

        [RelayCommand]
        public async Task TestIsBusyAsync()
        {
            IsBusy = true;
            await Task.Delay(TimeSpan.FromSeconds(2));
            IsBusy = false; 
        }
    }
}
