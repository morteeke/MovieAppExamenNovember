using MovieAppExamenNovember.Views;

namespace MovieAppExamenNovember;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MovieDescriptionPage), typeof(MovieDescriptionPage));
        Routing.RegisterRoute(nameof(AddMoviePage), typeof(AddMoviePage));
    }
}
