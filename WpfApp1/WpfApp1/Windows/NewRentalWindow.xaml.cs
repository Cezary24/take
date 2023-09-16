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

        private long volumeId;
       private readonly IVolumeService volumeService;
        private readonly IReaderService readerService;
      //  private readonly IRentalWindow rentalWindow;
        public NewRentalWindow(IVolumeService volumeService, IReaderService readerService)
        {
           this.volumeService = volumeService;
            this.readerService = readerService;
          //  this.rentalWindow = rentalWindow;
            InitializeComponent();
        }

        private async void Window_Initialized(object sender, EventArgs e)
        {
           
           
        }

        public void SetReaderIndex(string index)
        {
            throw new NotImplementedException();
        }

        

        private void CbRentals_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private void SetButtonEnabled()
        {
            if (CbRentals.SelectedIndex != -1 && !string.IsNullOrEmpty(readerId.Text))
                BtnSave.IsEnabled = true;
        }

        private void TxtReaderId_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }


        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           // await volumeService.AddVolumeAsync(volume);
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
            if (CbRentals.SelectedIndex != -1)
                BtnSave.IsEnabled = true;

        }
    }
}
