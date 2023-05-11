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
    /// Interaction logic for UserControlItemField.xaml
    /// </summary>
    public partial class UserControlItemField : UserControl
    {
        enum Type_
        {
            STRING, INT, DROPDOWN, DATE
        }
        Type_ type_;

        object parentObj;
        int PropertyIndex = 0;
        object Property;
        public UserControlItemField(ref System.Reflection.PropertyInfo Property, ref object obj, int i)
        {



            this.parentObj = obj;
            this.PropertyIndex = i;
            this.Property = Property;



            InitializeComponent();
            FieldName.Content = Property.Name;
            Init(Property.Name, Property.GetValue(obj));

        }

        public UserControlItemField(string Name_, object obj)
        {
            InitializeComponent();
            FieldName.Content = Name_;
            Init(Name_, obj);

        }
        void Init(string Name_, object obj)
        {
            type_ = Type_.STRING;
            string gettype = obj.GetType().ToString().ToLower();
            switch (gettype)
            {

                case "system.boolean":
                    {
                        ComboBox comboBox = new ComboBox();
                        {
                            ComboBoxItem comboBoxItem = new ComboBoxItem();
                            comboBox.Items.Add(true);
                            comboBox.Items.Add(false);
                            type_ = Type_.DROPDOWN;

                        }
                        comboBox.MinWidth = 200;
                        comboBox.Text = obj.ToString();
                        comboBox.SelectionChanged += ComboBox_BooleanSelectionChanged;
                        GBody.Children.Add(comboBox);
                        return;
                    }
                case "system.string":
                case "system.int32":
                    {

                        if (MainWindow.keyValuePairs.ContainsKey(Name_.ToUpper()))
                        {

                            var domain = MainWindow.keyValuePairs[Name_.ToUpper()];
                            FieldName.Content = domain.Name.Get();

                            if (domain.Type.ToLower() == "dropdown")
                            {
                                type_ = Type_.DROPDOWN;
                                ComboBox comboBox = new ComboBox();
                                foreach (var item in domain.Values)
                                {

                                    ComboBoxItem comboBoxItem = new ComboBoxItem();
                                    comboBoxItem.Content = item.Descriptions.Get();
                                    comboBox.Items.Add(comboBoxItem);
                                }
                                comboBox.Text = obj.ToString();
                                comboBox.MinWidth = 200;
                                comboBox.SelectionChanged += ComboBox_SelectionChanged;
                                GBody.Children.Add(comboBox);


                            }


                        }
                        else
                        {
                            //double hanle
                            if (gettype == "system.int32")
                                type_ = Type_.INT;

                            TextBox textBox = new TextBox();

                            textBox.Text = obj.ToString();
                            textBox.MinWidth = 200;

                            textBox.TextChanged += TextChanged;
                            GBody.Children.Add(textBox);

                        }


                        return;
                    }
                case "system.datetime":
                    {
                        DatePicker datePicker = new DatePicker();
                        datePicker.SelectedDateChanged += DatePicker_SelectedDateChanged;
                        GBody.Children.Add(datePicker);
                        datePicker.Text = obj.ToString();
                        type_ = Type_.DATE;
                        return;
                    }

            }


            return;
            //if (obj.GetType().ToString().ToLower().Contains("system.collections.generic.list"))
            //{
            //    Button button = new Button();
            //    button.Content = "Add " + Name_;
            //    button.Height = 30;
            //    button.Cursor = Cursors.Hand;


            //    var someVar = Activator.CreateInstance((obj.GetType().GetGenericArguments().First<Type>()));

            //    button.Tag = someVar;

            //  //  button.Click += ButtonAdder;

            // //   StackPanelData.Children.Add(button);
            //  //  MainWindow.mainWindow.AddButton(button, Name_ + " " + PName_);
            //    return;
            //}
            //foreach (var item in obj.GetType().GetProperties())
            //{
            //    StackPanelData.Children.Add(new SegmentUserControl(item.GetValue(obj), item.Name, Name_));
            //}
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker tb = (DatePicker)sender;

            try
            {

                ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, tb.SelectedDate);
            }
            catch (Exception)
            {
            }
        }

        private void ComboBox_BooleanSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            try
            {
                ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, tb.SelectedItem);
            }
            catch (Exception)
            {
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox tb = (ComboBox)sender;
            try
            {
                var selectedValue = (tb.SelectedItem as ComboBoxItem).Content.ToString();
                var name = ((System.Reflection.PropertyInfo)this.Property).Name;
                var propertyDesc = parentObj.GetType().GetProperty(name + "Desc");
                var code = MainWindow.keyValuePairs[name.ToUpper()].Values.Where(v => v.Descriptions.En == selectedValue).ToList().First().Code;

                if (propertyDesc != null)
                {
                    propertyDesc.SetValue(parentObj, (tb.SelectedItem as ComboBoxItem).Content.ToString());
                }
                ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, code.ToString());

            }
            catch (Exception)
            {
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox tb = ((TextBox)sender);

            if (tb.Text.Length == 0) return;

            try
            {

                if (type_ == Type_.INT)
                {
                    int data_ = 0;
                    int.TryParse(tb.Text, out data_);
                    ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, data_);
                }
                else
                {
                    ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, tb.Text);
                }

            }
            catch (Exception)
            {
            }

            switch (type_)
            {
                case Type_.STRING:
                    break;
                case Type_.INT:
                    int result = 0;
                    if (!int.TryParse(tb.Text, out result))
                    {
                        MessageBox.Show("Input Error \n [The Input] Should be number", "Error", MessageBoxButton.OK);
                        tb.Clear();
                    }

                    break;
                default:
                    break;
            }
        }



        public void clearData()
        {
            for (int i = 0; i < GBody.Children.Count; i++)
            {
                switch (type_)
                {
                    case Type_.STRING:
                    case Type_.INT:
                        ((TextBox)GBody.Children[0]).Clear();
                        break;
                    case Type_.DROPDOWN:
                        ((ComboBox)GBody.Children[0]).SelectedIndex = -1;

                        break;
                    case Type_.DATE:
                        ((DatePicker)GBody.Children[0]).Text = "";
                        break;
                    default:
                        break;
                }
            }
        }
        private void ClearButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            clearData();
        }
    }
}
