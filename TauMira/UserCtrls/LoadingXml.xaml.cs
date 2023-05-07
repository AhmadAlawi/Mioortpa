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
    /// Interaction logic for LoadingXml.xaml
    /// </summary>
    public partial class LoadingXml : UserControl
    {
        public LoadingXml()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("FileName", typeof(string), typeof(LoadingXml), new PropertyMetadata("Default "));
        public string FileName { get { return (string)GetValue(TitleProperty); } set { SetValue(TitleProperty, value); } }

        public static readonly DependencyProperty SizeProp = DependencyProperty.Register("FileSize", typeof(string), typeof(LoadingXml), new PropertyMetadata("Default "));
        public string FileSize { get { return (string)GetValue(SizeProp); } set { SetValue(SizeProp, value); } }


    }
}
