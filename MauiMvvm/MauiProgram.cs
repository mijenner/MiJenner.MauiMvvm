using CommunityToolkit.Maui;
using MauiMvvm.ViewModels;
using MauiMvvm.Views;
using Microsoft.Extensions.Logging;
using MiJenner.ServicesMAUI;

namespace MauiMvvm
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()  // Ads CommunityToolkit.Maui functionality. 
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Services: 
            builder.Services.AddSingleton<FilePathService>();
            builder.Services.AddSingleton<ISettingsService, SettingsService>(); 
            // Pages: 
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<ConfigPage>();
            builder.Services.AddTransient<DetailsPage>(); 
            // Viewmodels: 
            builder.Services.AddSingleton<BaseViewModel>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<ConfigViewModel>();
            builder.Services.AddTransient<DetailsViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
