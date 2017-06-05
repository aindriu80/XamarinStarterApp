﻿using App5.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetailPage : ContentPage
	{
	    private Playlist _playlist;
        public PlaylistDetailPage ()
		{
			InitializeComponent ();
		}

	    public PlaylistDetailPage(Playlist playlist)
	    {
	        _playlist = playlist;

	        InitializeComponent();

	        title.Text = _playlist.Title;
	    }
    }
}