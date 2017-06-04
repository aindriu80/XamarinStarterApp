using App5.Models;
using App5.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieDetailsPage : ContentPage
	{
	    private MovieService _movieService = new MovieService();
	    private Movie_Netflix _movie;

         
		public MovieDetailsPage (Movie_Netflix movie)
		{
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));
		    _movie = movie;

			InitializeComponent ();
		}
	    protected override async void OnAppearing()
	    {
	        BindingContext = await _movieService.GetMovie(_movie.Title);

	        base.OnAppearing();
	    }
    }
}