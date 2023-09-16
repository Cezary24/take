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
    /// Interaction logic for NewReaderWindow.xaml
    /// </summary>
    public partial class NewReaderWindow : Window, IReaderWindow
    {

        private NewReaderDto reader;

        private readonly IReaderService readerService;

        public NewReaderWindow(IReaderService readerService)
        {
            this.readerService = readerService;
            InitializeComponent();
            reader = new NewReaderDto();
            DataContext = reader;
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private void TxtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }



        private void SetButtonEnabled()
        {
            if (!string.IsNullOrEmpty(TxtName.Text) && !string.IsNullOrEmpty(TxtSurname.Text))
                BtnSave.IsEnabled = true;
        }

        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            await readerService.AddReaderAsync(reader);
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
            TxtName.Text = "";
            TxtSurname.Text = "";


        }
    }
}
