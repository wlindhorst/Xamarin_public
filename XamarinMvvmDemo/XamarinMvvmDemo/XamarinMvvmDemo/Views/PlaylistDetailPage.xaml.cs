﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinMvvmDemo
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist; 

        public PlaylistDetailPage (PlaylistViewModel playlist)
        {
            _playlist = playlist; 
            
            InitializeComponent ();

            title.Text = _playlist.Title;
        }
    }
}
