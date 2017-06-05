using App5.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App5.ViewModels
{
    public class PlaylistViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; }= new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel _selectedPlaylist;
        
        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set { SetValue(ref _selectedPlaylist, value); }
        }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        public void SelectPlaylist(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }


        public string Title { get; set; }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return _isFavorite; }
            set
            {
                SetValue(ref _isFavorite, value);
                OnPropertyChanged(nameof(Color));
            }
        }

        public Color Color
        {
            get { return IsFavorite ? Color.Pink : Color.Black; }
        }



    }
}
