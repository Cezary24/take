using Library.Core.Models.Reader;
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

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for ReadersPage.xaml
    /// </summary>
    public partial class ReadersPage : Page
    {

        private ReadersDto readers;
        private readonly IRentalService rentalService;
        private readonly IReaderWindow readerWindow;

        public ReadersPage(IRentalService rentalService, IReaderWindow readerWindow)
        {
            this.rentalService = rentalService;
            this.readerWindow = readerWindow;
            InitializeComponent();
            DataContext = this;
        }
    }
}
