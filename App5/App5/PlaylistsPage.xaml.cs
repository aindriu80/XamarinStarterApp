using App5.Models;
using App5.ViewModels;
using Xamarin.Forms;

namespace App5
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
	{
	  
        public PlaylistsPage ()
		{
            BindingContext = new PlaylistViewModel();
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {

	        base.OnAppearing();
	    }

	    void OnAddPlaylist(object sender, System.EventArgs e)
	    {
	     (BindingContext as PlaylistViewModel).AddPlaylist();

	    }

	    void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
	    {
	     (BindingContext as PlaylistViewModel).SelectPlaylist(e.SelectedItem as PlaylistViewModel);

	     
	    }
    }
}