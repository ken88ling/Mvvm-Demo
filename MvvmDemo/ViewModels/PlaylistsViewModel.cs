using System;
using System.Collections.ObjectModel;

namespace MvvmDemo
{
	public class PlaylistsViewModel
	{
		public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();
		public Playlist SelectedPlaylist { get; set; } //binding in xaml 

		public void AddPlaylist()
		{
			var newPlaylist = "Playlist " + (Playlists.Count + 1);

			Playlists.Add(new Playlist { Title = newPlaylist });
		}

		// this is use on code behind
		public void SelectPlaylist(Playlist playlist)
		{
			if (playlist == null)
				return;

			playlist.IsFavorite = !playlist.IsFavorite;

			// this need be public selecteditem
			SelectedPlaylist = null;
		}
	}
}
