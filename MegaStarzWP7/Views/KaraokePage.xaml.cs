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

        private FileSink m_sink;
        private CaptureSource m_captureSource;
        private string m_capturedFileName = "myVideo.mp4";

        #endregion

        #region CTOR

        public KaraokePage()
        {
            InitializeComponent();
            videoPlayer.Volume = 1;
        }

        #endregion


        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if ((videoPlayer.CurrentState == MediaElementState.Stopped) || (videoPlayer.CurrentState == MediaElementState.Paused)
                || (videoPlayer.CurrentState == MediaElementState.Opening))
            {
                StartRecordig();
                videoPlayer.Play();
//                try
//                {
//                    StartRecordig();
//                    videoPlayer.Play();                    
//                }
//                catch (Exception exception)
//                {
//                    MessageBox.Show(exception.Message);
//                }
            }else if (videoPlayer.CurrentState == MediaElementState.Playing)
            {
                videoPlayer.Stop();
                m_captureSource.Stop();
            }
            else
            {
                MessageBox.Show("Undeclared Video Player State");
            }
        }
        
        #region Recording Method

        private void StartRecordig()
        {
            if (m_captureSource == null)
            {
                m_captureSource = new CaptureSource();
                m_captureSource.VideoCaptureDevice = CaptureDeviceConfiguration.GetDefaultVideoCaptureDevice();
                m_captureSource.AudioCaptureDevice = CaptureDeviceConfiguration.GetDefaultAudioCaptureDevice();

                m_sink = new FileSink();
                m_sink.CaptureSource = m_captureSource;
                m_sink.IsolatedStorageFileName = m_capturedFileName;
            }

            VideoBrush brush = new VideoBrush();
            brush.SetSource(m_captureSource);
            CameraPreview.Fill = brush;

            m_captureSource.Start();

        }

        #endregion

    }
}