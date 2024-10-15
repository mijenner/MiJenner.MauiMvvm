using MauiMvvm.ViewModels;

namespace MauiMvvm
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            this.viewModel = viewModel;
        }
    }
}
