﻿using Library.Windows.Interfaces;
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
    public partial class NewTitleWindow : Page, ITitleWindow
    {
        public NewTitleWindow()
        {
            InitializeComponent();
        }

        public bool? ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
