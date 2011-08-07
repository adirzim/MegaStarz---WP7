using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Phone.Controls;

namespace MegaStarzWP7.Views
{
    public partial class KaraokePage : PhoneApplicationPage
    {
        #region Members

//        private TimeSpan duration;
//        private DispatcherTimer timer;

        #endregion

        #region CTOR

        public KaraokePage()
        {
            InitializeComponent();
        }

        #endregion

//        void timer_Tick(object sender, EventArgs e)
//        {
//            if (meVideo.CurrentState == MediaElementState.Playing)
//            {
//                double currentPostition = meVideo.Position.TotalMilliseconds;
//                double progressPosition = (currentPostition * 100) / duration.TotalMilliseconds;
//                sPosition.Value = progressPosition;
//            }
//        }
//
//        void meVideo_MediaEnded(object sender, RoutedEventArgs e)
//        {
//            meVideo.Position = TimeSpan.Zero;
//            sPosition.Value = 0;
//            btnPlay.IconUri = new Uri("/Images/appbar.transport.play.rest.png", UriKind.Relative);
//        }
//
//        void meVideo_MediaOpened(object sender, RoutedEventArgs e)
//        {
//            duration = meVideo.NaturalDuration.TimeSpan;
//        }
//
//        void meVideo_CurrentStateChanged(object sender, RoutedEventArgs e)
//        {
//            if (meVideo.CurrentState == MediaElementState.Playing)
//                btnPlay.IconUri = new Uri("/Images/appbar.transport.pause.rest.png", UriKind.Relative);
//            else
//                btnPlay.IconUri = new Uri("/Images/appbar.transport.play.rest.png", UriKind.Relative);
//        }
//
//        void meVideo_BufferingProgressChanged(object sender, RoutedEventArgs e)
//        {
//            tbBuffering.Text = string.Format("Buffering...{0:P}", meVideo.BufferingProgress);
//        }
//
//        private void btnPlay_Click(object sender, EventArgs e)
//        {
//            if (meVideo.CurrentState == MediaElementState.Playing)
//            {
//                meVideo.Pause();
//                timer.Stop();
//            }
//            else
//            {
//                timer.Start();
//                meVideo.Play();
//            }
//        }
//
//        private void btnStop_Click(object sender, EventArgs e)
//        {
//            meVideo.Stop();
//        }

    }
}