using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinMvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {
        private ObservableCollection<Playlist> _playlists = new ObservableCollection<Playlist> ();

        public PlaylistsPage ()
        {
            ViewModel = new PlaylistsViewModel(new PageService());

            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            // playlistsListView.ItemsSource = _playlists; // no longer needed due to the BindingContext being set in the view model
            
            base.OnAppearing ();
        }

        void OnAddPlaylist (object sender, System.EventArgs e)
        {
            #region Move refactored stuff to Viewmodel
            // Moving this code to the viewmodel
            //var newPlaylist = "Playlist " + (_playlists.Count + 1);
            //_playlists.Add (new Playlist { Title = newPlaylist });

            // this.Title = $"{_playlists.Count} Playlists"; // use binding to viewmodel 
            #endregion

            //(BindingContext as PlaylistsViewModel).AddPlaylist();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            #region Move this stuff to view model
            // also move this to the viewmodel
            //if (e.SelectedItem == null)
            //    return;

            //var playlist = e.SelectedItem as Playlist;
            //playlist.IsFavorite = !playlist.IsFavorite;

            //playlistsListView.SelectedItem = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
            #endregion

            ViewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }
        private PlaylistsViewModel ViewModel
        {
            get { return BindingContext as PlaylistsViewModel; }
            set { BindingContext = value; }
        }
    }
}
