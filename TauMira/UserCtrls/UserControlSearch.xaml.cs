﻿using System;
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

namespace TauMira.UserCtrls
{
    /// <summary>
    /// Interaction logic for UserControlSearch.xaml
    /// </summary>
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
        }

        private void TextBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SearchText.Text = string.Empty;
        }
    }
}
