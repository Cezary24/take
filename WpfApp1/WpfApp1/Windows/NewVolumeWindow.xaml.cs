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
    /// Interaction logic for NewVolumeWindow.xaml
    /// </summary>
    public partial class NewVolumeWindow : Window, IVolumeWindow
    {


        private NewVolumeDto volume;

        private readonly IVolumeService volumeService;
        private readonly ITitleService titleService;
        private readonly IRentalService rentalService;
        private readonly ITitleWindow titleWindow;

        public NewVolumeWindow(IVolumeService volumeService, ITitleService titleService, IRentalService rentalService, ITitleWindow titleWindow)
        {
            this.volumeService = volumeService;
            this.titleService = titleService;
            this.rentalService = rentalService;
            this.titleWindow = titleWindow;
            InitializeComponent();
            volume = new NewVolumeDto();
            DataContext = volume;
        }


        private void TxtAuthor_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private void TxtPublicationDate_TextChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SetButtonEnabled();
        }


        private void TxtPublishingHouse_TextChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private void Title_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private void LblNewTitle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            titleWindow.ShowDialog();
        }

        private void SetButtonEnabled()
        {
            if (!string.IsNullOrEmpty(TxtTitle.Text) && !string.IsNullOrEmpty(TxtAuthor.Text) && TxtPublishingHouse.SelectedDate.HasValue && TxtPublicationDate.SelectedDate.HasValue)
                BtnSave.IsEnabled = true;
        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            await volumeService.AddVolumeAsync(volume);
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
            TxtTitle.Text = "";
            TxtAuthor.Text = "";
            TxtPublishingHouse.Text = "";
            TxtPublicationDate.Text = "";
       
        }


    }
}
