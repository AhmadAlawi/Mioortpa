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

namespace TauMira.UserCtrls
{
    /// <summary>
    /// Interaction logic for WindowMessageBox.xaml
    /// </summary>
    public partial class WindowMessageBox : Window
    {
       
        public WindowMessageBox(string sectionName)
        {
            InitializeComponent();
            LabelMessage.Content = "You are trying to remove section '"+ sectionName + "'\nAre you sure you want to proceed? ";
        }
    }
}
