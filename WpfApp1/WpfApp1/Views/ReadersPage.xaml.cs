using Library.Core.Models.Reader;
using Library.Services.Interfaces;
using Library.Windows.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for ReadersPage.xaml
    /// </summary>
    public partial class ReadersPage : Page
    {

        private ReadersDto readers;
        private readonly IReaderService readerService;
        private readonly IReaderWindow readerWindow;

        public ReadersPage(IReaderService readerService, IReaderWindow readerWindow)
        {
            this.readerService = readerService;
            this.readerWindow = readerWindow;
            InitializeComponent();
            readers = new ReadersDto();
            DataContext = this;
        }


        private async Task GetDataAsync()
        {
            readers = await readerService.GetReadersAsync();
            DgReaders.ItemsSource = readers.readers;
        }

        private async void BtnNewReader_Click(object sender, RoutedEventArgs e)
        {
            readerWindow.ShowDialog();
            await GetDataAsync();
        }

        private async void Page_Initialized(object sender, System.EventArgs e)
        {
            await GetDataAsync();
        }
    }
}
