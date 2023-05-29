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
using System.Windows.Shapes;
using TauMira.UIXML;

namespace TauMira.UserCtrls
{
    /// <summary>
    /// Interaction logic for SubjectInfoWindow.xaml
    /// </summary>
    public partial class SubjectInfoWindow : Window
    {
        int Count = 0;
        public SubjectInfoWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(CountTextbox.Text, out Count))
            {
                MessageBox.Show("the input should be integar");
                return;
            }
            Close();
        }
        public int GetCount()
        {
            return Count;
        }
    }
}
