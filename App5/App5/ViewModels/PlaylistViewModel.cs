using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App5.Models;

namespace App5.ViewModels
{
    public class PlaylistViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; }= new ObservableCollection<Playlist>();
        public Playlist SelectedPlaylist { get; set; }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);

            Playlists.Add(new Playlist { Title = newPlaylist });
        }

        public void SelectPlaylist(Playlist playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
