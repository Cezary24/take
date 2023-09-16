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
using System.Xml.Linq;

namespace Library.Windows
{
    /// <summary>
    /// Interaction logic for NewRentalWindow.xaml
    /// </summary>
    public partial class NewRentalWindow : Window, IRentalWindow
    {

        private RentalDto rental;
        private VolumeDto volume;
       private readonly IVolumeService volumeService;
        private readonly IReaderService readerService;
        private readonly IRentalService rentalService;
      //  private readonly IRentalWindow rentalWindow;
        public NewRentalWindow(IVolumeService volumeService, IReaderService readerService)
        {
           this.volumeService = volumeService;
            this.readerService = readerService;
            //  this.rentalWindow = rentalWindow;
            rental = new RentalDto();
            volume = new VolumeDto();
            InitializeComponent();
        }

        private async void Window_Initialized(object sender, EventArgs e)
        {

            await GetVolumesAsync();
        }

        private async Task GetVolumesAsync()
        {
            CbVolumes.ItemsSource = (System.Collections.IEnumerable)await volumeService.GetVolumesAsync();
        }

        public void SetReaderIndex(string index)
        {
            throw new NotImplementedException();
        }

        

        private void CbVolumes_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            SetButtonEnabled();
        }

        private void SetButtonEnabled()
        {
            if (CbVolumes.SelectedIndex != -1 && !string.IsNullOrEmpty(readerId.Text))
                BtnSave.IsEnabled = true;
        }

        private void TxtReaderId_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {

           var reader = await readerService.GetReaderByIndex(readerId.Text);


            reader.rentals.rentals.Add(rental);

            var newRental = new NewRentalDto
            {
                deliveryDate = rental.deliveryDate,
                reader = reader,
                rentalDate = rental.rentalDate,
                volume = CbVolumes.SelectedItem as VolumeDto
                

            };

            await rentalService.AddRentalAsync(newRental);
            
           
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
    }
}
