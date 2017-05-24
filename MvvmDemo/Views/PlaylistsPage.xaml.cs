using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MvvmDemo
{

	public partial class PlaylistsPage : ContentPage
	{

		public PlaylistsPage()
		{
			BindingContext = new PlaylistsViewModel();

			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			// remove this line because use PlaylistsViewModel() binding to list already
			//playlistsListView.ItemsSource = _playlists; 

			base.OnAppearing();
		}

		void OnAddPlaylist(object sender, System.EventArgs e)
		{
			var newPlaylist = "Playlist " + (_playlists.Count + 1);

			_playlists.Add(new Playlist { Title = newPlaylist });

			// remove this count of title
			//this.Title = $"Total {_playlists.Count} Playlists";
		}

		void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var playlist = e.SelectedItem as Playlist;
			playlist.IsFavorite = !playlist.IsFavorite;

			playlistsListView.SelectedItem = null;

			//await Navigation.PushAsync (new PlaylistDetailPage(playlist));
		}
	}
}
