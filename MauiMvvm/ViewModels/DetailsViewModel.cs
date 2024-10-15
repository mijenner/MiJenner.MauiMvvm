namespace MauiMvvm.ViewModels
{
    [QueryProperty("Item", "Item")]
    public partial class DetailsViewModel : BaseViewModel
    {
        ICrudIdService<Item> crudIdService;
        ISettingsService settingsService; 
        FilePathService filePathService; 

        [ObservableProperty]
        Item item; 

        public DetailsViewModel(ICrudIdService<Item> crudIdService, ISettingsService settingsService, FilePathService filePathService) : base(settingsService, filePathService)
        {
            Title = "Details"; 
            this.crudIdService = crudIdService;
            this.settingsService = settingsService;
            this.filePathService = filePathService;
        }

        [RelayCommand]
        public async Task SaveItem()
        {
            if (item is null) return; 
            await crudIdService.UpdateAsync(item);
        }

    }
}
