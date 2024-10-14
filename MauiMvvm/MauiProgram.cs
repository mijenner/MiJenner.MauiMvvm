using CommunityToolkit.Maui;
using MauiMvvm.ViewModels;
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

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<BaseViewModel>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<FilePathService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
