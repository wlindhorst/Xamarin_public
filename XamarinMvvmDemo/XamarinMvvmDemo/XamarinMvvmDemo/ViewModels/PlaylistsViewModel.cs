using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinMvvmDemo
{
    public class PlaylistsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> PlayLists { get; private set; } = new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel _selectedPlayList;
        public PlaylistViewModel SelectedPlaylist
        {
            get { return _selectedPlayList; }
            set
            {
                SetValue(ref _selectedPlayList, value);
                
            }
        }
        public ICommand AddPlaylistCommand { get; private set; }
        public ICommand SelectPlaylistCommand { get; private set; }

        private readonly IPageService _pageService;
        public PlaylistsViewModel(IPageService pageService)
        {
            _pageService = pageService;
            AddPlaylistCommand = new Command(AddPlaylist);
            SelectPlaylistCommand = new Command<PlaylistViewModel>(async vm => await SelectPlaylist(vm));
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (PlayLists.Count + 1);

            PlayLists.Add(new PlaylistViewModel { Title = newPlaylist });

        }

        private async Task SelectPlaylist(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            SelectedPlaylist = null;

            await _pageService.PushAsync(new PlaylistDetailPage(playlist));
        }
    }

}
