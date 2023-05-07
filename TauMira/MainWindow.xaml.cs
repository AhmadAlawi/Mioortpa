
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml.Serialization;

using TauMira.UIJson;
using TauMira.UserCtrls;
using static TauMira.UIJson.UICompTemp;

namespace TauMira
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public class TreeItem
        //{
        //    public TreeItem()
        //    {
        //        add = true;
        //        Visa = Visibility.Visible;
        //        Title = "";
        //        Count = "";

        //        Subordinates = new List<TreeItem>();
        //    }
        //    public string Title { get; set; }

        //    public void test_click(object sender, MouseButtonEventArgs e)
        //    {
        //        MessageBox.Show("asd");
        //    }



        //    public string Count
        //    {
        //        get;
        //        set;
        //    }
        //    public Visibility Visa { get; set; }
        //    public bool add { get; set; }

        //    public event PropertyChangedEventHandler PropertyChanged;

        //    public List<TreeItem> _Subordinates;




        //    public List<TreeItem> Subordinates { get; set; }


        //}
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {




        }

        List<UserControlTreeItem> MainItems = new List<UserControlTreeItem>();
        Dictionary<string, UserControlTreeItem> MainItemsPairs = new Dictionary<string, UserControlTreeItem>();

        void Add(string title, Visibility add = Visibility.Visible, object tag = null)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem(title, add);
            userControlTreeItem.Tag = tag;
            MainItems.Add(userControlTreeItem);
            MainItemsPairs.Add(title, userControlTreeItem);
            AddInex.Add(title, new cart());


        }
        public TauMira.UIXML.UIXMLTemp.Envelope mainEnvelope = new UIXML.UIXMLTemp.Envelope();

        StackPanel InstallmentContract()
        {

            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract));

            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract.GrantedInstallment));

            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract.Maximum));

            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();


            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            return stackPanel;


        }

        StackPanel NonInstallment()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.NumbersSummary));

            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary));

            stackPanel.Children.Add(new UserControlSection("BC Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("GA Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary.GAmounts));

            return stackPanel;

        }
        StackPanel NonInstallmentContract()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedContract.Maximum));
            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            return stackPanel;
        }


        StackPanel CreditCards()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("BC Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("GA Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary.GAmounts));
            return stackPanel;
        }
        StackPanel CreditCardsContract()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract.Maximum));
            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            return stackPanel;
        }

        StackPanel Services()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("BC Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("GA Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary.GAmounts));
            return stackPanel;
        }
        StackPanel ServicesContract()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract.Maximum));
            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            return stackPanel;
        }



        void FootPrint(StackPanel stackPanel)
        {
            UIXML.UIXMLTemp.FootPrint footPrint = new UIXML.UIXMLTemp.FootPrint();
            stackPanel.Children.Add(new UserControlSection("FootPrint", footPrint, Visibility.Visible, stackPanel));
        }

        List<UIXML.UIXMLTemp.Profile> Profile(int Months, ref StackPanel stackPanel)
        {
            var lastmonth = DateTime.Today.AddMonths(0);
            List<UIXML.UIXMLTemp.Profile> profiles = new List<UIXML.UIXMLTemp.Profile>();
            for (int i = 0; i < Months; i++)
            {
                UIXML.UIXMLTemp.Profile profile = new UIXML.UIXMLTemp.Profile();
                profile.ReferenceYear = lastmonth.Year;
                profile.ReferenceMonth = lastmonth.Month;
                profile.OverduePaymentsNumber = 0;
                profile.DaysPastDue = 1;
                profile.DaysPastDueDesc = "Paid as agreed";
                profile.Status = "B";
                profile.StatusDesc = "No info";
                lastmonth = lastmonth.AddMonths(-1);
                profiles.Add(profile);
                stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
            }
            return profiles;
        }

        StackPanel Installment()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("BC Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("GA Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary.GAmounts));
            return stackPanel;
        }
        StackPanel Subject()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Individual", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual));
            stackPanel.Children.Add(new UserControlSection("Individual Name", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.individualName));
            stackPanel.Children.Add(new UserControlSection("BirthData Desc", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.birthData2));
            stackPanel.Children.Add(new UserControlSection("BirthData", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.birthData2.BirthData));
            stackPanel.Children.Add(new UserControlSection("Address", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.address));
            stackPanel.Children.Add(new UserControlSection("Individual Name", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.individualName));
            return stackPanel;
        }
        public MainWindow()
        {
            InitializeComponent();
            //System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            //openFileDialog.ShowDialog();

            //OpenFileDialog ofd = new OpenFileDialog
            //{
            //    AddExtension = true,
            //    Multiselect = false,
            //    Filter = "Xml files | *.xml"
            //};
            //if (ofd.ShowDialog() == true)
            //{
            //    using (StreamReader stream = new StreamReader(ofd.FileName))
            //    {
            //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(UIXML.UIXMLTemp.Envelope));
            //     mainEnvelope=   (UIXML.UIXMLTemp.Envelope)xmlSerializer.Deserialize(stream);
            //    }
            //}
            mainWindow = this;
            DomainsInitializer();
            Add("Subject", Visibility.Collapsed, Subject());
            Add("Installments", Visibility.Visible, Installment());
            Add("NonInstallments", Visibility.Visible, NonInstallment());
            Add("CreditCards", Visibility.Visible, CreditCards());
            Add("Services", Visibility.Visible, Services());
            Add("FootPrints", Visibility.Visible, new StackPanel());
            for (int i = 0; i < MainItems.Count; i++)
            {
                ItemsControlDomains.Items.Add(MainItems[i]);
            }
            //mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.NumbersSummary
            //mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments;
            return;
            TauMira.UIXML.UIXMLTemp.Envelope envelope = new UIXML.UIXMLTemp.Envelope();
            //  xmlSerliser.Serialize(textWriter, envelope);
            DomainsInitializer();
            TagsInitializer();
            Add("Credit Report", Visibility.Collapsed);
            Add("Matched Subject", Visibility.Collapsed);
            Add("Installments");
            Add("NonInstallments");
            Add("Credit Cards");
            Add("Services");
            Add("Foot Prints");
            for (int i = 0; i < MainItems.Count; i++)
            {
                ItemsControlDomains.Items.Add(MainItems[i]);
            }
        }
        public static MainWindow mainWindow;
        private void TagsInitializer()
        {
            TauMira.UIXML.UIXMLTemp.Envelope envelope = new UIXML.UIXMLTemp.Envelope();
            SegmentUserControl segmentUserControl = new SegmentUserControl(envelope, "Envelope");
            StackPanelData.Children.Add(segmentUserControl);
        }
        public static Dictionary<string, Domain> keyValuePairs = new Dictionary<string, Domain>();
        private void DomainsInitializer()
        {
            UICompTemp uICompTemp;
            using (StreamReader r = new StreamReader(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/UIJson/UIJson.json"))
            {
                string json = r.ReadToEnd();
                uICompTemp = JsonConvert.DeserializeObject<UICompTemp>(json);
            }
            foreach (var item in uICompTemp.Domains)
            {
                keyValuePairs.Add(item.Name.En.ToUpper(), item);
            }
        }
        public void AddButton(Button action, string Name_)
        {
            UserControlDomain domainButton = new UserControlDomain(Name_);
            domainButton.MouseUp += DomainButton_MouseUp;
            domainButton.Cursor = Cursors.Hand;
            domainButton.Tag = action;
            ItemsControlDomains.Items.Add(domainButton);
        }
        private void DomainButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Button domainButtonAction = (Button)(((UserControlDomain)sender).Tag);
            if (domainButtonAction != null)
            {
                domainButtonAction.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }
        private void ExpandAll(ItemsControl items, bool expand)
        {
            foreach (object obj in items.Items)
            {
                ItemsControl childControl = items.ItemContainerGenerator.ContainerFromItem(obj) as ItemsControl;
                if (childControl != null)
                {
                    ExpandAll(childControl, expand);
                }
                TreeViewItem item = childControl as TreeViewItem;
                if (item != null)
                    item.IsExpanded = true;
            }
        }
        public class cart
        {
            public int count;
            public cart()
            {
                this.count = 0;
            }
        }
        Dictionary<string, cart> AddInex = new Dictionary<string, cart>();

        private void Add_Installment_Click(object sender, RoutedEventArgs e)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["Installments"].count, Visibility.Collapsed);
            userControlTreeItem.Margin = new Thickness(20, 0, 0, 0);
            userControlTreeItem.Tag = InstallmentContract();
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["Installments"]) + AddInex["Installments"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
            //  WindowProfileData windowProfileData = new WindowProfileData(addProfiles, (StackPanel)userControlTreeItem.Tag);
            // windowProfileData.ShowDialog();
        }



        private void Add_FootPrints_Click(object sender, RoutedEventArgs e)
        {
            FootPrint((StackPanel)(MainItemsPairs["FootPrints"].Tag));
        }
        private void Add_NonInstallment_Click(object sender, RoutedEventArgs e)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["NonInstallments"].count, Visibility.Collapsed);
            userControlTreeItem.Margin = new Thickness(20, 0, 0, 0);
            userControlTreeItem.Tag = NonInstallmentContract();
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["NonInstallments"]) + AddInex["NonInstallments"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
        }
        private void Add_CreditCards_Click(object sender, RoutedEventArgs e)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["CreditCards"].count, Visibility.Collapsed);
            userControlTreeItem.Margin = new Thickness(20, 0, 0, 0);
            userControlTreeItem.Tag = CreditCardsContract();
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["CreditCards"]) + AddInex["CreditCards"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
        }
        private void Add_Services_Click(object sender, RoutedEventArgs e)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["Services"].count, Visibility.Collapsed);
            userControlTreeItem.Margin = new Thickness(20, 0, 0, 0);
            userControlTreeItem.Tag = ServicesContract();
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["Services"]) + AddInex["Services"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
        }
        public class SectionsTag
        {
            public SectionsTag()
            {
                sectionTags = new List<SectionTag>();
            }
            public List<SectionTag> sectionTags;

            public class SectionTag
            {
                public SectionTag(string title, object obj)
                {
                    Title = title;
                    userControlItemFields = new List<UserControlItemField>();
                    UserControlItemField ucif = new UserControlItemField(Title, obj);
                    userControlItemFields.Add(ucif);
                }
                public string Title = "";
                public List<UserControlItemField> userControlItemFields;
            }
        }
        public void Select(UserControlTreeItem userControlTreeItem)
        {
            if (userControlTreeItem.Tag != null)
            {
                StackPanelData.Children.Add((StackPanel)(userControlTreeItem.Tag));
            }
        }

        public void ItemsControlDomains_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StackPanelData.Children.Clear();
            try
            {
                if (sender == null) return;
                if (((ListBox)sender) == null) return;
                if ((((ListBox)sender).SelectedItem) == null) return;
                if (((UserControlTreeItem)(((ListBox)sender).SelectedItem)) == null) return;
            var tag = (((UserControlTreeItem)(((ListBox)sender).SelectedItem)).Tag);
            if (tag != null)
            {
                StackPanelData.Children.Add((StackPanel)tag);
            }
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer xmlSerliser = new XmlSerializer(typeof(TauMira.UIXML.UIXMLTemp.Envelope));
            var sfd = new SaveFileDialog();
            sfd.Filter = "xml|*.xml";
            if (sfd.ShowDialog() == true)
            {
                TextWriter textWriter = new StreamWriter(sfd.FileName);
                xmlSerliser.Serialize(textWriter, mainEnvelope);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void ImportXml_Click(object sender, RoutedEventArgs e)
        {

            var ofd = new Microsoft.Win32.OpenFileDialog
            {
                AddExtension = true,
                Multiselect = false,
                Filter = "Xml files | *.xml"
            };
            if (ofd.ShowDialog() == true)
            {
                StackPanelData.Children.Clear();
                using (StreamReader stream = new StreamReader(ofd.FileName))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(UIXML.UIXMLTemp.Envelope));

                    mainEnvelope = (UIXML.UIXMLTemp.Envelope)xmlSerializer.Deserialize(stream);
                    var loadingPanel = new LoadingXml();
                    loadingPanel.FileName = ofd.FileName;
                    var fileinfo = new FileInfo(ofd.FileName);
                    loadingPanel.FileSize = ((double)fileinfo.Length * 1).ToString() + "MB";
                    StackPanelData.Children.Add(loadingPanel);

                }
                ItemsControlDomains.Items.Clear();
                mainWindow = this;
                AddInex = new Dictionary<string, cart>();
                keyValuePairs = new Dictionary<string, Domain>();
                MainItems = new List<UserControlTreeItem>();
                MainItemsPairs = new Dictionary<string, UserControlTreeItem>();
                DomainsInitializer();
                Add("Subject", Visibility.Collapsed, Subject());
                Add("Installments", Visibility.Visible, Installment());
                Add("NonInstallments", Visibility.Visible, NonInstallment());
                Add("CreditCards", Visibility.Visible, CreditCards());
                Add("Services", Visibility.Visible, Services());
                Add("FootPrints", Visibility.Visible, new StackPanel());





                for (int i = 0; i < MainItems.Count; i++)
                {
                    ItemsControlDomains.Items.Add(MainItems[i]);
                }
            }
        }
    }
}
