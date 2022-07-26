using CommunityToolkit.Maui;
using TestNewMAUIApp.ViewModels;

namespace TestNewMAUIApp;

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

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<MainViewModel>();

		builder.UseMauiApp<App>().UseMauiCommunityToolkit();

		return builder.Build();
	}
}
