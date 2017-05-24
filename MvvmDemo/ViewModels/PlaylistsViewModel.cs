﻿using System;
using System.Collections.ObjectModel;

namespace MvvmDemo
{
	public class PlaylistsViewModel
	{
		public ObservableCollection<Playlist> Playlists { get; private set; } = new ObservableCollection<Playlist>();

		public void AddPlaylist()
		{
			var newPlaylist = "Playlist " + (Playlists.Count + 1);

			Playlists.Add(new Playlist { Title = newPlaylist });
		}
	}
}
