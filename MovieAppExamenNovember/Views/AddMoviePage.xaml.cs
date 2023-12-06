using MovieAppExamenNovember.ViewModels;

namespace MovieAppExamenNovember.Views;

public partial class AddMoviePage : ContentPage
{
	public AddMoviePage(MoviePageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}