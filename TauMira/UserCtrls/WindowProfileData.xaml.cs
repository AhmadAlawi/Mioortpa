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
    /// Interaction logic for WindowProfileData.xaml
    /// </summary>
    public partial class WindowProfileData : Window
    {
        Action<int, StackPanel> fromtoMonths;
        StackPanel stackPanel;

        public WindowProfileData(string Titel="Set the number of profiles",string lable= "Months")
        {
            InitializeComponent();
            LabelProfileData.Content = Titel;
            LabelNumberOf.Content = lable;
        }
        public int GetMonths()
        {
            return Months;
        }
        public WindowProfileData(Action<int, StackPanel> fromtoMonths, StackPanel stackPanel)
        {
            InitializeComponent();
            this.fromtoMonths = fromtoMonths;
            this.stackPanel = stackPanel;
        }
        int Months = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
         
            if ( !int.TryParse(TextBoxTo.Text, out Months))
            {
                MessageBox.Show("the input should be integar");
                return;
            }

           
            Close();

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (!int.TryParse(TextBoxTo.Text, out Months))
                {
                    MessageBox.Show("the input should be integar");
                    return;
                }


                Close();
            }
        }
    }
}
