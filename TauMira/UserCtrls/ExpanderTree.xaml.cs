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

namespace TauMira.UserCtrls
{
    /// <summary>
    /// Interaction logic for ExpanderTree.xaml
    /// </summary>
    public partial class ExpanderTree : UserControl
    {
        public ExpanderTree(string header,object child, int Margin_)
        {
            InitializeComponent();
            mainExpander.Margin = new Thickness(Margin_, 0, 0, 0);
            mainExpander.Content = child;
            mainExpander.Header = header;
        }
    }
}
