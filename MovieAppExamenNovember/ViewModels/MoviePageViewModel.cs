
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieAppExamenNovember.Models;
using MovieAppExamenNovember.Views;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MovieAppExamenNovember.ViewModels
{
    public partial class MoviePageViewModel:BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Movie> movieList = new();

        [ObservableProperty]
        Movie movie;

        [ObservableProperty]
        bool isLoadingAPI = false;

        [ObservableProperty]
        bool isNotLoadingAPI = true;

        MovieSearchResult MovieSearchResult = new();

        HttpClient client;

        Character Character = new();

        public MoviePageViewModel()
        {
            client = new HttpClient();
            movie = new();
        }

        [RelayCommand]
        public async Task GetMovies()
        {
            //Set to true so the label shows
            IsLoadingAPI = true;
            IsNotLoadingAPI = false;

            //Start with clearing the MovieList before we add new Movies to the list
            MovieList.Clear();

            //Api url
            var url = "https://swapi.dev/api/films";

            //When we make an api call we will have to wait for a response from the HttpClient
            var response = await client.GetStringAsync(url);
            //We initialize the object MovieSearchResult using JsonSerializer with the response from client
            MovieSearchResult = JsonSerializer.Deserialize<MovieSearchResult>(response);

            //Take every movie from MovieSearchResult and put it in MovieList
            foreach(var movie in MovieSearchResult.results)
            {
                MovieList.Add(movie);
            }
            //Set to false so the label dissapears
            IsLoadingAPI = false;
            IsNotLoadingAPI = true;
        }

        [RelayCommand]
        public async Task LoadMovieDescriptionPage(Movie movie)
        {
            IsNotLoadingAPI = false;
            IsLoadingAPI = true;

            movie.characterObjects.Clear();

            foreach (var characterUrl in movie.characters)
            {

                
                string url = characterUrl;

                var response = await client.GetStringAsync(url);
                Character = JsonSerializer.Deserialize<Character>(response);

                movie.characterObjects.Add(Character);
            }


            await Shell.Current.GoToAsync(nameof(MovieDescriptionPage), true, new Dictionary<string, object>
            {
                {"Movie", movie }
                
            });

            IsLoadingAPI = false;
            IsNotLoadingAPI = true;
        }

        [RelayCommand]
        public void RemoveMovie(Movie movie)
        {
            MovieList.Remove(movie);
        }

        [RelayCommand]
        public void AddMovie()
        {
            //go to different page using the Shell
            Shell.Current.GoToAsync(nameof(AddMoviePage), true);
        }

        [RelayCommand]
        public async Task SaveMovie()
        {
            if(Movie == null)
            {
                return;
            }

            MovieList.Add(Movie);
            await GoBackAsync();
        }
    }
}
