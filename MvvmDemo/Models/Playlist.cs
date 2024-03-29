﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MvvmDemo
{
	public class Playlist : BaseViewModel
	{

		public string Title { get; set; }

		private bool _isFavorite;
		public bool IsFavorite
		{
			get { return _isFavorite; }
			set
			{
				if (_isFavorite == value)
					return;

				_isFavorite = value;

				OnPropertyChanged();

				OnPropertyChanged(nameof(Color));
			}
		}

		public Color Color
		{
			get { return IsFavorite ? Color.Pink : Color.Black; }
		}
	}
}