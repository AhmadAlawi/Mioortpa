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
    /// Interaction logic for UserControlSection.xaml
    /// </summary>
    public partial class UserControlSection : UserControl
    {
        //public UserControlSection(string Name_, List<UserControlItemField> userControlItemFields)
        //{
        //    InitializeComponent();
        //    SectionName.Content = Name_;

        //    if (userControlItemFields == null) return;
        //    for (int i = 0; i < userControlItemFields.Count; i++)
        //    {
        //        userControlItemFields[i].Margin = new Thickness(0, 0, 5, 0);
        //        WrapPanelData.Children.Add(userControlItemFields[i]);
        //    }
        //}

        StackPanel parent_;
        public static List<string> types = new List<string>() { "system.string", "system.int32", "system.datetime", "system.boolean", "system.int64" };
        public UserControlSection(string Name_, object obj, Visibility removeVisable = Visibility.Collapsed, StackPanel parent_ = null)
        {
            InitializeComponent();
            this.parent_ = parent_;
            Remove_.Visibility = removeVisable;


            SectionName.Content = Name_;

            if (obj == null) return;


            var Properties = obj.GetType().GetProperties();


            for (int i = 0; i < Properties.Length; i++)
            {
                try
                {

                if (types.Contains(Properties[i].GetValue(obj).GetType().ToString().ToLower()))
                {
                    UserControlItemField userControlItemField = new UserControlItemField(ref Properties[i], ref obj, i);
                    userControlItemField.Margin = new Thickness(0, 0, 5, 0);
                        if (!userControlItemField.FieldName.Content.ToString().EndsWith("Desc"))
                            WrapPanelData.Children.Add(userControlItemField);
                }
                }
                catch { }
            }

            return;
            foreach (var item in obj.GetType().GetProperties())
            {


                if (types.Contains(item.GetValue(obj).GetType().ToString().ToLower()))
                {

                    UserControlItemField userControlItemField = new UserControlItemField(item.Name, item.GetValue(obj));

                    userControlItemField.Margin = new Thickness(0, 0, 5, 0);
                    WrapPanelData.Children.Add(userControlItemField);
                }

            }
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < WrapPanelData.Children.Count; i++)
            {
                if (WrapPanelData.Children[i].GetType().ToString().ToLower().Contains(("UserControlItemField".ToLower())))
                {
                    ((UserControlItemField)(WrapPanelData.Children[i])).clearData();
                }
            }
        }



        private void Remove_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (parent_ == null) return;
            parent_.Children.Remove(this);
        }
    }
}
