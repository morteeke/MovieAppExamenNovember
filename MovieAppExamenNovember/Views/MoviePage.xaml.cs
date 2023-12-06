using MovieAppExamenNovember.ViewModels;

namespace MovieAppExamenNovember.Views;

public partial class MoviePage : ContentPage
{
	public MoviePage(MoviePageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}