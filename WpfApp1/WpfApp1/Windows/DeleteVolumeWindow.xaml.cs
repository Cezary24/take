using Library.Core.Models.Reader;
using Library.Core.Models.Volume;
using Library.Services.Interfaces;
using Library.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Data.Browsing;
using Library.Core.Models.Volume;
using Library.Services.Interfaces;
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

using System;
using System.Threading.Tasks;
using System.Windows;
using Library.Core.Models.Rental;
using System.Xml.Linq;

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for DeleteVolumeWindow.xaml
    /// </summary>
    public partial class DeleteVolumeWindow : Window, IDeleteWindow
    {
        private readonly IVolumeService volumeService;

        public DeleteVolumeWindow(IVolumeService volumeService)
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
            this.volumeService.deleteVolumeByIdAsync((CbVolumes.SelectedItem as VolumeDto).Id.ToString());
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
            if (CbVolumes.SelectedIndex != -1 )
                BtnSave.IsEnabled = true;
        }

    }
}
