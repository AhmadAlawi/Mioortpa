using Microsoft.VisualBasic.CompilerServices;
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

namespace TauMira.UIJson
{
    /// <summary>
    /// Interaction logic for SegmentUserControl.xaml
    /// </summary>
    public partial class SegmentUserControl : UserControl
    {
        static int colorIndex = 0;
        static IList<Brush> _colors = new[]
{
           new SolidColorBrush( Colors.White), 
            new SolidColorBrush( Colors.Yellow), 
            new SolidColorBrush(  Color.FromArgb(255, 0, 128, 128)),
             new SolidColorBrush( Color.FromArgb(255, 176, 196, 222)),
             new SolidColorBrush( Color.FromArgb(255, 255, 182, 193)),
             new SolidColorBrush( Colors.Purple),
             new SolidColorBrush( Color.FromArgb(255, 245, 222, 179)),
             new SolidColorBrush( Color.FromArgb(255, 173, 216, 230)),
             new SolidColorBrush( Color.FromArgb(255, 250, 128, 114)),
             new SolidColorBrush( Color.FromArgb(255, 144, 238, 144)),
             new SolidColorBrush( Colors.Orange),
             new SolidColorBrush( Color.FromArgb(255, 192, 192, 192)),
             new SolidColorBrush( Color.FromArgb(255, 255, 99, 71)),
             new SolidColorBrush( Color.FromArgb(255, 205, 133, 63)),
             new SolidColorBrush( Color.FromArgb(255, 64, 224, 208)),
             new SolidColorBrush( Color.FromArgb(255, 244, 164, 96))
        };
        public SegmentUserControl(object obj, string Name_ ,string PName_="")
        {
            
            InitializeComponent();
           // GroupBoxSeg.BorderBrush= _colors[colorIndex % 16];
           // Random random = new Random();
           // GroupBoxSeg.BorderBrush = new SolidColorBrush(Color.FromArgb((byte)random.Next(1,255), (byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 255)));
         //   colorIndex++;
            GroupBoxSeg.Header = Name_;
            switch (obj.GetType().ToString().ToLower())
            {
                case "system.string":
                case "system.int32":
                    {
                        if (MainWindow.keyValuePairs.ContainsKey(Name_.ToUpper()))
                        {
                            var domain = MainWindow.keyValuePairs[Name_.ToUpper()];
                            GroupBoxSeg.Header = domain.Name.Get();
                            if (domain.Type.ToLower() == "dropdown")
                            {
                                ComboBox comboBox = new ComboBox();
                                foreach (var item in domain.Values)
                                {

                                    ComboBoxItem comboBoxItem = new ComboBoxItem();
                                    comboBoxItem.Content = item.Descriptions.Get();
                                    comboBox.Items.Add(comboBoxItem);
                                }
                                comboBox.MinWidth = 200;
                                StackPanelData.Children.Add(comboBox);

                            }


                        }
                        else
                        {
                            TextBox textBox = new TextBox();
                            textBox.MinWidth = 200;
                            StackPanelData.Children.Add(textBox);

                        }


                        return;
                    }
                case "system.datetime":
                    {
                        DatePicker datePicker = new DatePicker();
                        StackPanelData.Children.Add(datePicker);

                        return;
                    }
            }
            if (obj.GetType().ToString().ToLower().Contains("system.collections.generic.list"))
            {
                Button button = new Button();
                button.Content = "Add " + Name_;
                button.Height = 30;
                button.Cursor = Cursors.Hand;

            
                var someVar = Activator.CreateInstance((obj.GetType().GetGenericArguments().First<Type>()));

                button.Tag = someVar;
              
                button.Click += ButtonAdder;

                StackPanelData.Children.Add(button);
                MainWindow.mainWindow.AddButton(button, Name_+" "+PName_);
                return;
            }
            foreach (var item in obj.GetType().GetProperties())
            {
                StackPanelData.Children.Add(new SegmentUserControl(item.GetValue(obj), item.Name,Name_));
            }

        }

        private void ButtonAdder(object sender, RoutedEventArgs e)
        {
            Button btnAdd = (Button)sender;
            SegmentUserControl segmentUserControl = new SegmentUserControl(btnAdd.Tag,"");
            StackPanelData.Children.Add(segmentUserControl);
        }

        private void GroupBoxSeg_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

     
        //   public SegmentUserControl(UICompTemp.Domain domain)
        //{
        //    InitializeComponent();
        //    GroupBoxSeg.Header = domain.Name.Get();
        //    if (domain.Type.ToLower() == "dropdown")
        //    {
        //        ComboBox comboBox=  new ComboBox();
        //        foreach (var item in domain.Values)
        //        {

        //            ComboBoxItem comboBoxItem = new ComboBoxItem();
        //            comboBoxItem.Content = item.Descriptions.Get();
        //            comboBox.Items.Add(comboBoxItem);
        //        }
        //        GroupBoxSeg.Content = comboBox;

        //    }
        //}
    }
}
