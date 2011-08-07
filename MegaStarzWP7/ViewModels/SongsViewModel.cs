using System.Collections.ObjectModel;
using System.ComponentModel;
using MegaStarzWP7.Models;

namespace MegaStarzWP7.ViewModels
{
    public class SongsViewModel : INotifyPropertyChanged
    {

        #region Properties

        private ObservableCollection<SongModel> songs;
        public ObservableCollection<SongModel> Songs
        {
            get
            {
                return songs;
            }
            set
            {
                if (value != songs)
                {
                    songs = value;
                    NotifyPropertyChanged("Songs");
                }
            }
        }


        private SongModel selectedSongs;
        public SongModel SelectedSongs
        {
            get
            {
                return selectedSongs;
            }
            set
            {
                if (value != selectedSongs)
                {
                    selectedSongs = value;
                    NotifyPropertyChanged("SelectedSongs");
                }
            }
        }


        #endregion

        #region CTOR

        public SongsViewModel()
        {
            songs = new ObservableCollection<SongModel>();
            LoadData();
        }

        #endregion

        #region 

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            for (int i = 0; i < 10; i++)
            {
                songs.Add(new SongModel("Artist " + i,"Song " +i,"00:00:0" + i,"pictureUrl " + i,"songUrl" + i));
            }

            IsDataLoaded = true;
        }


        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
