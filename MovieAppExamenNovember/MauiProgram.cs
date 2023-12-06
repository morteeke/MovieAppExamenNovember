using MovieAppExamenNovember.ViewModels;
using MovieAppExamenNovember.Views;

namespace MovieAppExamenNovember;

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

        builder.Services.AddSingleton<MoviePage>();
        builder.Services.AddSingleton<MoviePageViewModel>();

        builder.Services.AddTransient<MovieDescriptionPage>();
        builder.Services.AddTransient<MovieDescriptionPageViewModel>();

		builder.Services.AddTransient<AddMoviePage>();

		return builder.Build();
	}
}
