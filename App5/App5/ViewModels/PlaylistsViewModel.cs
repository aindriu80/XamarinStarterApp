using App5.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Windows.Input;

namespace App5.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        private PlaylistViewModel _selectedPlaylist;
        private readonly IPageService _pageService;


        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; }= new ObservableCollection<PlaylistViewModel>();
        
        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlaylist; }
            set { SetValue(ref _selectedPlaylist, value); }
        }

        public ICommand AddPlayListCommand { get; private set; }
        public ICommand SelectPlaylistCommand { get; private set; }


        public PlaylistsViewModel(IPageService pageService)
        {
            _pageService = pageService;

            AddPlayListCommand = new Command(AddPlaylist);
            SelectPlaylistCommand = new Command<PlaylistViewModel>(async vm => await SelectPlaylist(vm));
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        private async Task SelectPlaylist(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            await _pageService.PushAsync (new PlaylistDetailPage(playlist));
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
