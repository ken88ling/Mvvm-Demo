using System;
using System.Collections.ObjectModel;

namespace MvvmDemo
{
	public class PlaylistsViewModel : BaseViewModel
	{
		public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();

		private Playlist _SelectedPlaylist;
		public Playlist SelectedPlaylist
		{
			get
			{
				return _SelectedPlaylist;
			}
			set
			{
				if (_SelectedPlaylist == null)
					return;

				_SelectedPlaylist = value;

				OnPropertyChanged();
			}
		}

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
