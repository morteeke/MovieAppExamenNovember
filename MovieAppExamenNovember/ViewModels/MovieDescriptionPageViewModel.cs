using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovieAppExamenNovember.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace MovieAppExamenNovember.ViewModels
{
    [QueryProperty(nameof(Movie), "Movie")]

    public partial class MovieDescriptionPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Movie movie;


        public MovieDescriptionPageViewModel() 
        {

            //On page load we need to call API.
        }
    }
}
