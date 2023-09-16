using Library.Core.Models.Rental;
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

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for VolumeReturningWindow.xaml
    /// </summary>
    public partial class VolumeReturningWindow : Window, IVolumeReturningWindow
    {
        private readonly IVolumeService volumeService;

        public VolumeReturningWindow(IVolumeService volumeService)
        {
            this.volumeService = volumeService;
            InitializeComponent();
        }


        private void CbVolumes_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            SetButtonEnabled();
        }

        private async void Window_Initialized(object sender, EventArgs e)
        {

            await GetVolumesAsync();
        }

        private async Task GetVolumesAsync()
        {
            CbVolumes.ItemsSource = (System.Collections.IEnumerable)await volumeService.GetVolumesAsync();
        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            // kod do 

            CleanControls();
            Hide();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            CleanControls();
            Hide();
        }

        private void CleanControls()
        {
            if (CbVolumes.SelectedIndex != -1)
                BtnSave.IsEnabled = true;

        }

        private void SetButtonEnabled()
        {
            if (CbVolumes.SelectedIndex != -1)
                BtnSave.IsEnabled = true;
        }
    }
}
