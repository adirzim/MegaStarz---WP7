using System.ComponentModel;

namespace MegaStarzWP7.Models
{
    public class SongModel : INotifyPropertyChanged
    {


        #region CTOR

        public SongModel(string artist, string name, string length, string pictureUrl, string songUrl)
        {
            this.artist = artist;
            this.name = name;
            this.length = length;
            this.pictureUrl = pictureUrl;
            this.songUrl = songUrl;
        }

        #endregion


        #region Properties

        private string artist;
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                if (value != artist)
                {
                    artist = value;
                    NotifyPropertyChanged("Artist");
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string length;
        public string Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value != length)
                {
                    length = value;
                    NotifyPropertyChanged("Length");
                }
            }
        }

        private string pictureUrl;
        public string PictureUrl
        {
            get
            {
                return pictureUrl;
            }
            set
            {
                if (value != pictureUrl)
                {
                    pictureUrl = value;
                    NotifyPropertyChanged("PictureUrl");
                }
            }
        }

        private string songUrl;
        public string SongUrl
        {
            get
            {
                return songUrl;
            }
            set
            {
                if (value != songUrl)
                {
                    songUrl = value;
                    NotifyPropertyChanged("SongUrl");
                }
            }
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
