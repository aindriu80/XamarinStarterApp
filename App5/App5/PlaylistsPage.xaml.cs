﻿using App5.Models;
using App5.ViewModels;
using Xamarin.Forms;

namespace App5
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
	{
	  
        public PlaylistsPage ()
		{
            BindingContext = new PlaylistsViewModel(new PageService());
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {

	        base.OnAppearing();
	    }

	    void OnAddPlaylist(object sender, System.EventArgs e)
	    {
	     (BindingContext as PlaylistsViewModel).AddPlaylist();

	    }

	    void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
	    {
	     (BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as PlaylistViewModel);

	     
	    }
    }
}