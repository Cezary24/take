using Library.Core.Models.Reader;
using Library.Core.Models.Volume;
using Library.Services.Interfaces;
using Library.Services.Web;
using Library.Windows.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class VolumesPage : Page
    {


        private VolumesDto volumes;
        private readonly IVolumeService volumeService;
        private readonly IVolumeWindow volumeWindow;

        public VolumesPage(IVolumeService volumeService, IVolumeWindow volumeWindow)
        {
            this.volumeService = volumeService;
            this.volumeWindow = volumeWindow;
            InitializeComponent(); 
        }

        private async Task GetDataAsync()
        {
            volumes = await volumeService.GetVolumesAsync();
            DgVolumes.ItemsSource = volumes.Volumes;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private async void BtnAddVolume_Click(object sender, RoutedEventArgs e)
        {
            volumeWindow.ShowDialog();
            await GetDataAsync();
        }

        private async void Page_Initialized(object sender, System.EventArgs e)
        {
            await GetDataAsync();
        }

        private void DgStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
