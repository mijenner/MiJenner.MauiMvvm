using CommunityToolkit.Mvvm.ComponentModel;

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

        public BaseViewModel()
        {            
        }

    }
}
