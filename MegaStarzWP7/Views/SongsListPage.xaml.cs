using System;
using MegaStarzWP7.ViewModels;
using Microsoft.Phone.Controls;

namespace MegaStarzWP7.Views
{
    public partial class SongsListPage : PhoneApplicationPage
    {
        /// <summary>
        /// Main page of the application 
        /// Show all the songs lists
        /// </summary>
        public SongsListPage()
        {
            DataContext = new SongsViewModel();
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/KaraokePage.xaml", UriKind.Relative));
        }
    }
}