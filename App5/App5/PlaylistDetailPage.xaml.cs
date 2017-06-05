using App5.Models;
using App5.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetailPage : ContentPage
	{
	    private PlaylistViewModel _playlist;
        public PlaylistDetailPage ()
		{
			InitializeComponent ();
		}

	    public PlaylistDetailPage(PlaylistViewModel playlist)
	    {
	        _playlist = playlist;

	        InitializeComponent();

	        title.Text = _playlist.Title;
	    }
    }
}