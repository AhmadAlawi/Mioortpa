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
using System.Windows.Markup;
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
        enum TauMiraTypes
        {
            STRING, INT, DROPDOWN, DATE, LABEL
        }
        TauMiraTypes type;

        object parentObj;
        int PropertyIndex = 0;
        object Property;

        public UserControlItemField(ref System.Reflection.PropertyInfo property, ref object obj, int i)
        {
            InitializeComponent();

            parentObj = obj;
            PropertyIndex = i;
            Property = property;
            FieldName.Content = property.Name;
            Init(property.Name, property.GetValue(obj));
        }

        public UserControlItemField(string Name_, object obj)
        {
            InitializeComponent();
            FieldName.Content = Name_;
            Init(Name_, obj);

        }
        void Init(string name, object obj)
        {
            type = TauMiraTypes.STRING;
            string getType = obj.GetType().ToString().ToLower();

            switch (getType)
            {
                case "system.boolean":
                    {
                        ComboBox comboBox = new ComboBox();
                        {
                            ComboBoxItem comboBoxItem = new ComboBoxItem();
                            comboBox.Items.Add(true);
                            comboBox.Items.Add(false);
                            type = TauMiraTypes.DROPDOWN;

                        }
                        comboBox.MinWidth = 200;
                        comboBox.MinHeight = 40;
                        comboBox.Text = obj.ToString();
                        comboBox.SelectionChanged += ComboBox_BooleanSelectionChanged;
                        BooleanChange(comboBox, obj);

                        GBody.Children.Add(comboBox);
                        return;
                    }
                case "system.string":
                case "system.int32":
                    {
                        if (MainWindow.keyValuePairs.ContainsKey(name.ToUpper()))
                        {

                            var domain = MainWindow.keyValuePairs[name.ToUpper()];
                            FieldName.Content = domain.Name.Get();

                            if (domain.Type.ToLower() == "dropdown")
                            {
                                type = TauMiraTypes.DROPDOWN;
                                ComboBox comboBox = new ComboBox();
                                foreach (var item in domain.Values)
                                {

                                    ComboBoxItem comboBoxItem = new ComboBoxItem();
                                    comboBoxItem.Content = item.Descriptions.Get();
                                    comboBox.Items.Add(comboBoxItem);
                                }
                                comboBox.Text = obj.ToString();
                                comboBox.MinWidth = 200;
                                comboBox.MinHeight = 40;
                                comboBox.SelectionChanged += ComboBox_SelectionChanged;
                                TestChange(comboBox, obj);
                                GBody.Children.Add(comboBox);


                            }
                            else
                            {
                                if (domain.Type.ToLower() == "label")
                                {
                                    Label label = new Label();
                                    label.Content = obj.ToString();
                                    label.VerticalContentAlignment = VerticalAlignment.Center;
                                    label.MinWidth = 200;
                                    label.BorderThickness = new Thickness(1.0);
                                    label.BorderBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFAFAFAF"));
                                    GBody.Children.Add(label);
                                }
                            }


                        }
                        else
                        {
                            //double hanle
                            if (getType == "system.int32")
                                type = TauMiraTypes.INT;
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
                        DateTimeChange(datePicker, obj);
                        type = TauMiraTypes.DATE;

                        return;
                    }
                case "system.int64":
                    {
                        TextBox textBox = new TextBox();
                        textBox.Text = obj.ToString();
                        textBox.MinWidth = 200;
                        textBox.LostFocus += RawChanged;
                        Int64Change(textBox, obj);
                        GBody.Children.Add(textBox);
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

        private void RawChangedl(object sender, RoutedEventArgs e)
        {

        }

        private void RawChanged(object sender, RoutedEventArgs e)
        {
            var txtScoreRaw = sender as TextBox;
            string input = txtScoreRaw.Text;
            if (!input.All(c => char.IsDigit(c)) || input == "")
            {
                txtScoreRaw.Text = "";
                return;
            }
            var a = txtScoreRaw.Parent as Grid;
            var l = a.Parent as Grid;
            var d = l.Parent as TauMira.UserCtrls.UserControlItemField;
            var s = d.Parent as System.Windows.Controls.WrapPanel;

            var b = s.Children[1];
            var mk = b as TauMira.UserCtrls.UserControlItemField;
            var f = mk.Content as Grid;
            var gh = f.Children[1] as Grid;
            var RiskL = gh.Children[0] as System.Windows.Controls.Label;

            int scoreRaw = int.Parse(input);
            string riskLevel = ConvertScoreRawToRiskLevel(scoreRaw);
            RiskL.Content = riskLevel;
            RiskL.IsEnabled = false;
            if (riskLevel == "-")
                MessageBox.Show("scoreRaw should be between 300 and 900");
            (parentObj as UIXML.UIXMLTemp.CBSGlocal).RiskLevel = riskLevel;
            ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, scoreRaw);
        }

        // Convert ScoreRaw into RiskLevel
        string ConvertScoreRawToRiskLevel(int scoreRaw)
        {
            string result;

            switch (scoreRaw)
            {
                case int n when n >= 300 && n <= 564:
                    result = "The credit bureau score indicates a very high risk profile for the subject";
                    break;
                case int n when n >= 565 && n <= 654:
                    result = "The credit bureau score indicates a high risk profile for the subject";
                    break;
                case int n when n >= 655 && n <= 684:
                    result = "The credit bureau score indicates a medium risk profile for the subject";
                    break;
                case int n when n >= 685 && n <= 774:
                    result = "The credit bureau score indicates a low risk profile for the subject";
                    break;
                case int n when n >= 775 && n <= 900:
                    result = "The credit bureau score indicates a very low risk profile for the subject";
                    break;
                default:
                    result = "-";
                    break;
            }

            return result;
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

                object value = code;

                if (int.TryParse(code, out int converted))
                    value = converted;

                ((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, value);

            }
            catch (Exception)
            {
            }
        }

        private void TestChange(object sender, object obj)
        {
            ComboBox tb = (ComboBox)sender;
            try
            {

                // var selectedValue = (tb.SelectedItem as ComboBoxItem).Content.ToString();
                var name = ((System.Reflection.PropertyInfo)this.Property).Name;

                var propertyDesc = parentObj.GetType().GetProperty(name + "Desc");
                //var code = MainWindow.keyValuePairs[name.ToUpper()].Values.Where(v => v.Descriptions.En == selectedValue).ToList().First().Code;
                //var des = MainWindow.keyValuePairs[name.ToUpper()].Values.Where(v => v.Code = obj.ToString()).ToList().First().Code;
                var codeToDescriptionDict = MainWindow.keyValuePairs[name.ToUpper()].Values.ToDictionary(v => v.Code, v => v.Descriptions.En);
                var selectedCode = obj.ToString(); // Replace this with the actual code you want to select

                // var matchingDescription = codeToDescriptionDict.FirstOrDefault(kv => kv.Key == selectedCode).Value;

                //foreach (ComboBoxItem item in tb.Items)
                //{
                //    if (item.Content.ToString() == matchingDescription)
                //    {
                //        tb.SelectedItem = item;
                //        break;
                //    }
                //}
                if (codeToDescriptionDict.ContainsKey(selectedCode))
                {
                    var matchingDescription = codeToDescriptionDict[selectedCode];

                    tb.SelectedItem = matchingDescription.ToString();
                    tb.SelectedValue = matchingDescription.ToString();

                    foreach (ComboBoxItem item in tb.Items)
                    {
                        if (item.Content.ToString().ToLower() == matchingDescription.ToLower())
                        {
                            tb.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    // Handle case when the code is not found in the dictionary
                    // You can set a default selected item or display an error message
                }




                //((System.Reflection.PropertyInfo)this.Property).SetValue(parentObj, code.ToString());

            }
            catch (Exception)
            {
            }
        }

        private void BooleanChange(object sender, object obj)
        {
            ComboBox tb = (ComboBox)sender;
            foreach (ComboBoxItem item in tb.Items)
            {
                if (item.Content == obj.ToString())
                {
                    tb.SelectedItem = item;
                }
            }



        }

        private void Int64Change(object sender, object obj)
        {
            TextBox tb = (TextBox)sender;
            if (obj is string stringValue)
            {
                tb.Text = stringValue;
            }
            else if (obj is int intValue)
            {
                tb.Text = intValue.ToString();
            }
            else if (obj is long longValue)
            {
                tb.Text = longValue.ToString();
            }
        }

        private void DateTimeChange(object sender, object obj)
        {
            DatePicker datePicker = (DatePicker)sender;
            datePicker.SelectedDate = (DateTime)obj;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox tb = ((TextBox)sender);


            if (tb.Text.Length == 0) return;

            try
            {

                if (type == TauMiraTypes.INT)
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

            switch (type)
            {
                case TauMiraTypes.STRING:
                    break;
                case TauMiraTypes.INT:
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
                switch (type)
                {
                    case TauMiraTypes.STRING:
                    case TauMiraTypes.INT:
                        ((TextBox)GBody.Children[0]).Clear();
                        break;
                    case TauMiraTypes.DROPDOWN:
                        ((ComboBox)GBody.Children[0]).SelectedIndex = -1;

                        break;
                    case TauMiraTypes.DATE:
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
