using MauiMvvm.ViewModels;

namespace MauiMvvm.Views;

public partial class DetailsPage : ContentPage
{
	DetailsViewModel viewModel; 

	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		this.viewModel = viewModel;
	}
}
