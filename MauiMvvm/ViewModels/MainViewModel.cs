namespace MauiMvvm.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        public ObservableCollection<Item> items;
        ISettingsService settingsService;
        FilePathService filePathService;
        ICrudIdService<Item> crudIdService;

        public MainViewModel(ICrudIdService<Item> crudIdService, ISettingsService settingsService, FilePathService filePathService) : base(settingsService, filePathService)
        {
            Title = "Main";
            this.settingsService = settingsService;
            this.filePathService = filePathService;
            this.crudIdService = crudIdService;
            items = new ObservableCollection<Item>();
        }

        [RelayCommand]
        public async Task GetItemsAsync()
        {
            if (Items is null) return;

            int num = 12;
            await PopulateSystematically(num);
            // await PopulateWithRandomItems(num); 
            var data = await crudIdService.ReadAllAsync();
            if (data is null) return;

            Items.Clear();
            foreach (var item in data)
            {
                Items.Add(item);
            }
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
        public async Task GotoDetailsAsync(Item selectedItem)
        {
            if (selectedItem is null) return;

            Shell.Current?.GoToAsync(nameof(DetailsPage), true,
                new Dictionary<string, object> 
                {
                     { "Item", selectedItem }
                });
        }

        private readonly Random random = new Random();

        private readonly string[] names = {
        "Apples", "Bananas", "Cherries", "Dates", "Elderberries",
        "Figs", "Grapes", "Honeydew", "Kiwi", "Lemons"
    };

        private readonly string[] quotes = {
        "The journey of a thousand miles begins with one step.",
        "To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.",
        "Life is really simple, but we insist on making it complicated.",
        "In the end, we will remember not the words of our enemies, but the silence of our friends.",
        "What lies behind us and what lies before us are tiny matters compared to what lies within us."
    };

        public async Task PopulateWithRandomItems(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var newItem = new Item
                {
                    Id = Guid.NewGuid(),
                    Name = names[random.Next(names.Length)],
                    Description = quotes[random.Next(quotes.Length)]
                };
                await crudIdService.CreateAsync(newItem);
            }
        }

        public async Task PopulateSystematically(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var newItem = new Item
                {
                    Id = Guid.NewGuid(),
                    Name = $"Name-{i}",
                    Description = $"Descr-{i}"
                };
                await crudIdService.CreateAsync(newItem);
            }

        }
    }
}
