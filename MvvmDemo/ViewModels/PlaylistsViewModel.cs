using System;
using System.Collections.ObjectModel;

namespace MvvmDemo
{
	public class PlaylistsViewModel
	{
		public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();

	}
}
