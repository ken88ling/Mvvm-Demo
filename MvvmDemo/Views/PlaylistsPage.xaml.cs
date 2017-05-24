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
			(BindingContext as PlaylistsViewModel).AddPlaylist();

			// remove this count of title
			//this.Title = $"Total {_playlists.Count} Playlists";
		}

		void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			(BindingContext as PlaylistsViewModel).SelectPlaylist(e.SelectedItem as Playlist);			
		}
	}
}
