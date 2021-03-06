﻿using App5.Models;
using App5.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MoviesPage : ContentPage
	{
	    private MovieService _service = new MovieService();

	    private BindableProperty IsSearchingProperty = BindableProperty.Create("IsSearching", typeof(bool), typeof(MoviesPage), false);
	    public bool IsSearching
	    {
	        get { return (bool)GetValue(IsSearchingProperty); }
	        set { SetValue(IsSearchingProperty, value); }
	    }

        public MoviesPage ()
	    {
	        BindingContext = this;
			InitializeComponent ();
		}

	   async void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	        //throw new NotImplementedException();
	        if (e.NewTextValue == null || e.NewTextValue.Length < MovieService.minMovieLength)
	            return;
	        await FindMovies(actor: e.NewTextValue);
	    }

	    async Task FindMovies(string actor)
	    {
	        try
	        {
	            IsSearching = true;

	            var movies = await _service.FindMoviesByActor(actor);
	            moviesListView.ItemsSource = movies;
	            moviesListView.IsVisible = movies.Any();
	           // notFound.IsVisible = !moviesListView.IsVisible;
	        }
	        catch (Exception)
	        {
	            await DisplayAlert("Error", "Could not retrieve the list of movies.", "OK");
	        }
	        finally
	        {
	            IsSearching = false;
	        }
        }



	   async void MovieSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        if (e.SelectedItem == null)
	            return;
	        var movie = e.SelectedItem as Movie_Netflix;

	        moviesListView.SelectedItem = null;

	        await Navigation.PushAsync(new MovieDetailsPage(movie));
	    }
	}
}