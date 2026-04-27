using DormChef.Services;
using DormChef.Views;
using DormChef.ViewModels;

namespace DormChef
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Services
            builder.Services.AddSingleton<AppStateService>();
            builder.Services.AddSingleton<DatabaseService>();
            builder.Services.AddSingleton<MealDataService>();

            // Pages
            builder.Services.AddSingleton<SignUpPage>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<FavoritesPage>();
            builder.Services.AddSingleton<ProfilePage>();
            builder.Services.AddTransient<CategoryPage>();
            builder.Services.AddTransient<MealDetailPage>();

            // ViewModels
            builder.Services.AddTransient<SignupViewModel>();
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<FavoritesViewModel>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<CategoryViewModel>();
            builder.Services.AddTransient<MealDetailViewModel>();

            return builder.Build();
        }
    }
}