using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using TauMira.UIJson;

namespace TauMira.UserCtrls
{
    /// <summary>
    /// Interaction logic for UserControlDomain.xaml
    /// </summary>
    public partial class UserControlDomain : UserControl
    {
        public UserControlDomain(string Name_)
        {
            InitializeComponent();
            TextBlockName.Text = Regex.Replace(Name_, "(\\B[A-Z])", " $1");
        }

       

    }
}
