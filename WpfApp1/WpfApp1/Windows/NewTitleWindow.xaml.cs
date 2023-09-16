using Library.Core.Models.Reader;
using Library.Core.Models.Title;
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
    /// Interaction logic for NewTitleWindow.xaml
    /// </summary>
    public partial class NewTitleWindow : Window, ITitleWindow
    {

        private NewTitleDto title;

        private readonly ITitleService titleService;

        public NewTitleWindow(ITitleService titleService)
        {
            this.titleService = titleService;
            InitializeComponent();
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetButtonEnabled();
        }

        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            await titleService.AddTitleAsync(title);
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
        }

        private void SetButtonEnabled()
        {
            if (!string.IsNullOrEmpty(TxtName.Text))
                BtnSave.IsEnabled = true;
        }
    }
}
