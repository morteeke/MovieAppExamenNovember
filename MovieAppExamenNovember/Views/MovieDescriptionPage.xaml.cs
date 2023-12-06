using MovieAppExamenNovember.ViewModels;

namespace MovieAppExamenNovember.Views;

public partial class MovieDescriptionPage : ContentPage
{
	public MovieDescriptionPage(MovieDescriptionPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}