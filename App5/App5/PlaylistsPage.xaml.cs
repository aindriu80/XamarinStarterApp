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
            ViewModel = new PlaylistsViewModel(new PageService());
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {

	        base.OnAppearing();
	    }


	    void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
	    {
	     (BindingContext as PlaylistsViewModel).SelectPlaylistCommand.Execute(e.SelectedItem);
	     }

	    private PlaylistsViewModel ViewModel
	    {
	        get { return BindingContext as PlaylistsViewModel;}
            set { BindingContext = value; }
	    }
    }
}