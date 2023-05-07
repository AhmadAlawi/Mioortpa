using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for UserControlTreeItem.xaml
    /// </summary>
    public partial class UserControlTreeItem : UserControl
    {

        public UserControlTreeItem(string title,Visibility add)
        {
            InitializeComponent();

            labelTitle.Content = title;
            AddCTRL.Visibility = add;
            ItemsList.SelectionChanged += MainWindow.mainWindow.ItemsControlDomains_SelectionChanged;
        }



        public Visibility visa_
        {
            get
            {
                return AddCTRL.Visibility;
            }
            set
            {
                AddCTRL.Visibility = value;


            }
        }
        public string name_
        {

            get
            {
                return labelTitle.Content.ToString();
            }
            set
            {
                labelTitle.Content = value;
            }
        }



        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register(
                "number_",
                typeof(string),
                typeof(UserControlTreeItem),
                new UIPropertyMetadata(null));




        private string number_p = "";
        public string number_
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
            //get
            //{
            //    return number_p;
            //}
            //set
            //{
            //    number_p = value;
            //}
        }

        public bool add_ = false;


        string ChildName = "";
        //public void AddItem(string Title, string childName = "")
        //{
        //    Title += (ItemsList.Items.Count + 1);
        //    var x = new UserControlTreeItem(Title, childName==""?Visibility.Collapsed:Visibility.Visible);

        //    if (childName != "")
        //        x.AddItem(childName);
      
        //    AddItem(x);
        //    ChildName = childName;
        //}

        public void AddItem(UserControlTreeItem userControlTreeItem)
        {
            userControlTreeItem.labelTitle.Content += (ItemsList.Items.Count + 1) + "";
            ItemsList.Items.Add(userControlTreeItem);
            GridItemsList.Visibility = Visibility.Visible;
        }
    }
}
