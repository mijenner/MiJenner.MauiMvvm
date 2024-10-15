using CommunityToolkit.Mvvm.Input;
using MauiMvvm.ViewModels;

namespace MauiMvvm.Views;

public partial class ConfigPage : ContentPage
{
	ConfigViewModel viewModel;

	public ConfigPage(ConfigViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext = viewModel; 
	}



}
