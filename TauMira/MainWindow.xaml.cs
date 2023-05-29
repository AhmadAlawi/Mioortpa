
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
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
using System.Xml;
using System.Xml.Serialization;

using TauMira.UIJson;
using TauMira.UIXML;
using TauMira.UserCtrls;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TauMira.UIJson.UICompTemp;
using static TauMira.UIXML.UIXMLTemp;

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

        void AddUserControlTreeItem(string title, Visibility add = Visibility.Visible, object tag = null)
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem(title, add)
            {
                Tag = tag
            };

            MainItems.Add(userControlTreeItem);
            MainItemsPairs.Add(title, userControlTreeItem);
            AddInex.Add(title, new cart());
        }

        public TauMira.UIXML.UIXMLTemp.Envelope mainEnvelope = new UIXML.UIXMLTemp.Envelope();

        StackPanel Installment()
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("Borrower/Co-Borrower Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("Guarantor Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.AmountsSummary.GAmounts));


            //UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["Installments"].count, Visibility.Collapsed)
            //{
            //    Margin = new Thickness(20, 0, 0, 0),
            //    Tag = InstallmentContract(true)
            //};

            //int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["Installments"]) + AddInex["Installments"].count;
            //ItemsControlDomains.Items.Insert(index + 1, userControlTreeItem);

            return stackPanel;
        }

        StackPanel InstallmentContract(bool isImported = false)
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Maximum));

            if (!isImported)
            {
                WindowProfileData windowProfileData = new WindowProfileData();
                windowProfileData.ShowDialog();
                int Months = windowProfileData.GetMonths();

                //mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
                mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GenerateProfile(Months, ref stackPanel);
            }
            else
            {
                //UIXMLTemp.Profile.ShowProfiles(mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile, ref stackPanel);
                // mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile.AddRange(mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile);
                var Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile;
                mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Installments.ShowProfiles(Profile, ref stackPanel);
            }
            return stackPanel;
        }

        StackPanel NonInstallment()
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("Borrower/Co-Borrower Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("Guarantor Amounts Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.AmountsSummary.GAmounts));

            return stackPanel;
        }
        StackPanel NonInstallmentContract()
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.Maximum));

            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();

            // mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.NonInstallments.GenerateProfile(Months, ref stackPanel);

            return stackPanel;
        }


        StackPanel CreditCards()
        {
            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("Borrower/Co-Borrower Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("Guarantor Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.AmountsSummary.GAmounts));

            return stackPanel;
        }
        StackPanel CreditCardsContract()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.Maximum));
            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            //mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.CreditCards.GenerateProfile(Months, ref stackPanel);
            return stackPanel;
        }

        StackPanel Services()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Numbers Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.NumbersSummary));
            stackPanel.Children.Add(new UserControlSection("Amounts Summary", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary));
            stackPanel.Children.Add(new UserControlSection("Borrower/Co-Borrower Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary.BCAmounts));
            stackPanel.Children.Add(new UserControlSection("Guarantor Amounts", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.AmountsSummary.GAmounts));
            return stackPanel;
        }
        StackPanel ServicesContract()
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.Maximum));
            WindowProfileData windowProfileData = new WindowProfileData();
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            // mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GenerateProfile(Months, ref stackPanel);
            return stackPanel;
        }



        //void FootPrint(StackPanel stackPanel)
        //{
        //    UIXML.UIXMLTemp.FootPrint footPrint = new UIXML.UIXMLTemp.FootPrint();
        //    stackPanel.Children.Add(new UserControlSection("FootPrint", footPrint, Visibility.Visible, stackPanel));
        //}

        protected StackPanel CBScoreStackPanel = new StackPanel();

        StackPanel CBScore()
        {
            CBScoreStackPanel.Children.Clear();
            CBScoreStackPanel.Children.Add(new UserControlSection("CBSGlocal", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CBScore.CBSGlocal));
            return CBScoreStackPanel;
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
                // profile.OverduePaymentsNumber = 0;
                //profile.DaysPastDue = 1;
                //profile.DaysPastDueDesc = "Paid as agreed";
                profile.Status = "B";
                profile.StatusDesc = "No info";
                lastmonth = lastmonth.AddMonths(-1);
                profiles.Add(profile);
                stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
            }
            return profiles;
        }


        StackPanel SubjectstackPanel = new StackPanel();
        StackPanel Subject()
        {
            SubjectstackPanel.Children.Clear();
            SubjectstackPanel.Children.Add(new UserControlSection("Individual", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual));
            SubjectstackPanel.Children.Add(new UserControlSection("Individual Name", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.individualName));
            // stackPanel.Children.Add(new UserControlSection("BirthData Desc", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.birthData2));
            SubjectstackPanel.Children.Add(new UserControlSection("BirthData", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.birthData2.BirthData));
            SubjectstackPanel.Children.Add(new UserControlSection("Address", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.EnquiredData.Subject.Individual.address));
            //stackPanel.Children.Add(new UserControlSection("Ahmad", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.SubjectInfo.NegativeEvent));
            return SubjectstackPanel;
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
            AddUserControlTreeItem("Subject", Visibility.Collapsed, Subject());
            AddUserControlTreeItem("Installments", Visibility.Visible, Installment());
            AddUserControlTreeItem("NonInstallments", Visibility.Visible, NonInstallment());
            AddUserControlTreeItem("CreditCards", Visibility.Visible, CreditCards());
            AddUserControlTreeItem("Services", Visibility.Visible, Services());
            AddUserControlTreeItem("CBScore", Visibility.Visible, CBScore());
            AddUserControlTreeItem("NegativeEvent/BouncedCheque", Visibility.Visible, SubjectInfoStackPanel);
            //Add("FootPrints", Visibility.Visible, new StackPanel());
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
            AddUserControlTreeItem("Credit Report", Visibility.Collapsed);
            AddUserControlTreeItem("Matched Subject", Visibility.Collapsed);
            AddUserControlTreeItem("Installments");
            AddUserControlTreeItem("NonInstallments");
            AddUserControlTreeItem("Credit Cards");
            AddUserControlTreeItem("Services");
            AddUserControlTreeItem("Foot Prints");
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
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["Installments"].count, Visibility.Collapsed)
            {
                Margin = new Thickness(20, 0, 0, 0),
                Tag = InstallmentContract(sender == null)
            };
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["Installments"]) + AddInex["Installments"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
            //  WindowProfileData windowProfileData = new WindowProfileData(addProfiles, (StackPanel)userControlTreeItem.Tag);
            // windowProfileData.ShowDialog();
        }

        //private void Add_FootPrints_Click(object sender, RoutedEventArgs e)
        //{
        //    FootPrint((StackPanel)(MainItemsPairs["FootPrints"].Tag));
        //}
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
            //XmlTypeMapping xmlTypeMapping = new SoapReflectionImporter().ImportTypeMapping(typeof(TauMira.UIXML.UIXMLTemp.Envelope));
            XmlSerializer xmlSerliser = new XmlSerializer(typeof(TauMira.UIXML.UIXMLTemp.Envelope));
            var xmlns = new XmlSerializerNamespaces();

            xmlns.Add("s", "http://schemas.xmlsoap.org/soap/envelope/");
            xmlns.Add("cb", "urn:crif-creditbureau:v1");

            // xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            //xmlns.Add("xsd", "http://www.w3.org/2001/XMLSchema");

            //XmlSerializer xmlSerliser = new XmlSerializer(xmlTypeMapping);

            var sfd = new SaveFileDialog
            {
                Filter = "xml|*.xml"
            };

            if (sfd.ShowDialog() == true)
            {
                using (var textWriter = new NoTypeAttributeXmlWriter(sfd.FileName, Encoding.UTF8))
                    xmlSerliser.Serialize(textWriter, mainEnvelope, xmlns);

                MakeEnhancements(sfd.FileName);
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        void MakeEnhancements(string fileName)
        {
            string content;
            using (var reader = new StreamReader(fileName))
                content = reader.ReadToEnd();

            //   content = FixXmlSoapMistakes(content);

            using (var writer = new StreamWriter(fileName))
                writer.Write(content, FileMode.Truncate);
        }

        string FixXmlSoapMistakes(string content)
        {
            Dictionary<string, string> crifMistakes = new Dictionary<string, string>
            {
                { "<?xml version=\"1.0\" encoding=\"utf-8\"?>", "" },
                { "ContractStatusLastUpdateDesc", "ContractStatusLastUpdatDesc" },
                { "<s:Body>", "<s:Body xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">" },
                { "<s:Envelope xmlns:cb=\"urn:crif-creditbureau:v1\" xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\">", "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\">" },
                { "<cb:CB_NAE_ProductOutput>", "<cb:CB_NAE_ProductOutput xmlns:cb=\"urn:crif-creditbureau:v1\">" },
                { "<cb:CB_ME_ProductOutput>", "<cb:CB_ME_ProductOutput xmlns:cb=\"urn:crif-creditbureau:v1\">" },
            };

            foreach (var item in crifMistakes)
            {
                content = content.Replace(item.Key, item.Value);
            }

            return content;
        }

        private void ImportXml_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                AddExtension = true,
                Multiselect = false,
                Filter = "Xml files | *.xml"
            };

            if (ofd.ShowDialog() == false)
                return;

            StackPanelData.Children.Clear();

            using (var stream = new StreamReader(ofd.FileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(UIXML.UIXMLTemp.Envelope));

                mainEnvelope = (Envelope)xmlSerializer.Deserialize(stream);
                var loadingPanel = new LoadingXml
                {
                    FileName = ofd.FileName
                };

                var fileInfo = new FileInfo(ofd.FileName);
                loadingPanel.FileSize = ConvertBytesToSize(fileInfo.Length);
                StackPanelData.Children.Add(loadingPanel);
            }

            ItemsControlDomains.Items.Clear();
            mainWindow = this;
            AddInex = new Dictionary<string, cart>();
            keyValuePairs = new Dictionary<string, Domain>();
            MainItems = new List<UserControlTreeItem>();
            MainItemsPairs = new Dictionary<string, UserControlTreeItem>();

            DomainsInitializer();
            AddUserControlTreeItem("Subject", Visibility.Collapsed, Subject());
            AddUserControlTreeItem("Installments", Visibility.Visible, Installment());
            AddUserControlTreeItem("NonInstallments", Visibility.Visible, NonInstallment());
            AddUserControlTreeItem("CreditCards", Visibility.Visible, CreditCards());
            AddUserControlTreeItem("Services", Visibility.Visible, Services());
            //Edit Here Please
            opentestProfile();
            //To Here
            AddUserControlTreeItem("CBScore", Visibility.Visible, CBScore());
            AddUserControlTreeItem("NegativeEvent/BouncedCheque", Visibility.Visible, ImportExistSubjectInfo());
            //AddUserControlTreeItem("Subject", Visibility.Collapsed, ImportExistSubject());
            // Add("FootPrints", Visibility.Visible, new StackPanel());

            for (int i = 0; i < MainItems.Count; i++)
            {
                ItemsControlDomains.Items.Add(MainItems[i]);
            }
        }
        //From Here
        private void opentestProfile()
        {
            UserControlTreeItem userControlTreeItem = new UserControlTreeItem("Contract" + ++AddInex["Services"].count, Visibility.Collapsed);
            userControlTreeItem.Margin = new Thickness(20, 0, 0, 0);
            userControlTreeItem.Tag = TestProfiles();
            int index = ItemsControlDomains.Items.IndexOf(MainItemsPairs["Services"]) + AddInex["Services"].count;
            ItemsControlDomains.Items.Insert(index, userControlTreeItem);
        }

        StackPanel TestProfiles()
        {

            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new UserControlSection("Granted Contract", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract));
            stackPanel.Children.Add(new UserControlSection("Granted Installment", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedInstallment));
            stackPanel.Children.Add(new UserControlSection("Maximum", mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.Maximum));

            int Months = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.Profile.Count();
            // mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.GrantedContract.Profile = Profile(Months, ref stackPanel);
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GrantedContract.Profile = mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.ContractsHistory.Services.GenerateProfile(Months, ref stackPanel);
            return stackPanel;
        }
        //To Here
        StackPanel ImportExistSubjectInfo()
        {
            SubjectInfoStackPanel.Children.Clear();

            foreach (var item in mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.SubjectInfo)
            {
                //SubjectInfoStackPanel.Children.Add(new UserControlSection(item.SubjectInfoCategoryDesc, mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.SubjectInfo));
                CreateSubjectInfoStack(1, ref SubjectInfoStackPanel, item);
            }

            return SubjectInfoStackPanel;
        }
        
        string ConvertBytesToSize(float size)
        {
            int unit = 0;
            string[] units = new string[] {
                "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"
            };

            while (size >= 1024)
            {
                size /= 1024;
                unit++;
            }

            return $"{size:0.00} {units[unit]}";
        }

        private void AddPositiveEvent_Click(object sender, RoutedEventArgs e)
        {
            WindowProfileData windowProfileData = new WindowProfileData("Set the number of PositiveScoreFactors", "Number");
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CBScore.CBSGlocal.PositiveScoreFactors = CreatePositiveStack(Months, ref CBScoreStackPanel);

        }
        private void AddNegativeEvent_Click(object sender, RoutedEventArgs e)
        {
            WindowProfileData windowProfileData = new WindowProfileData("Set the number of NegativeScoreFactors", "Number");
            windowProfileData.ShowDialog();
            int Months = windowProfileData.GetMonths();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CBScore.CBSGlocal.NegativeScoreFactors = CreateNegativeStack(Months, ref CBScoreStackPanel);
        }

        public List<UIXMLTemp.NegativeScoreFactors> CreateNegativeStack(int months, ref StackPanel stackPanel)
        {
            var NegativeScoreFactors = new List<UIXMLTemp.NegativeScoreFactors>();

            for (int i = 0; i < months; i++)
            {
                var Negative = new UIXMLTemp.NegativeScoreFactors();
                NegativeScoreFactors.Add(Negative);
                NegativeScoreFactors[i].Description = "";

                stackPanel.Children.Add(new UserControlSection("NegativeScoreFactors", Negative, Visibility.Visible, stackPanel));
            }
            return NegativeScoreFactors;
        }

        public List<UIXMLTemp.PositiveScoreFactors> CreatePositiveStack(int number, ref StackPanel stackPanel)
        {
            var positiveScoreFactors = new List<UIXMLTemp.PositiveScoreFactors>();

            for (int i = 0; i < number; i++)
            {
                var positive = new UIXMLTemp.PositiveScoreFactors();
                positiveScoreFactors.Add(positive);
                positiveScoreFactors[i].Description = "";

                stackPanel.Children.Add(new UserControlSection("PositiveScoreFactors", positive, Visibility.Visible, stackPanel));
            }
            return positiveScoreFactors;
        }

        StackPanel SubjectInfoStackPanel = new StackPanel();
        private void AddSubjectInfo_Click(object sender, RoutedEventArgs e)
        {
            var subjectInfo = new UIXMLTemp.SubjectInfo();
            SubjectInfoWindow subjectInfoWindow = new SubjectInfoWindow();
            subjectInfoWindow.MainStackPanel.Children.Add(new UserControlSection("SubjectInfo", subjectInfo));
            subjectInfoWindow.ShowDialog();
            int Count = subjectInfoWindow.GetCount();
            mainEnvelope.Body.MGResponse.ProductResponse.CBNAEProductOutput.CreditReport.SubjectInfo.AddRange(CreateSubjectInfoStack(Count, ref SubjectInfoStackPanel, subjectInfo));
        }




        public List<UIXMLTemp.SubjectInfo> CreateSubjectInfoStack(int count, ref StackPanel stackPanel, SubjectInfo subjectInfoReference)
        {
            var subjects = new List<UIXMLTemp.SubjectInfo>();
            string name = subjectInfoReference.SubjectInfoCategory;

            for (int i = 0; i < count; i++)
            {
                var subjectInfo = new UIXMLTemp.SubjectInfo
                {
                    SubjectInfoCategory = subjectInfoReference.SubjectInfoCategory,
                    SubjectInfoTypeCode = subjectInfoReference.SubjectInfoTypeCode,
                    SubjectInfoCategoryDesc = subjectInfoReference.SubjectInfoCategoryDesc,
                    SubjectInfoTypeCodeDesc = subjectInfoReference.SubjectInfoTypeCodeDesc,
                    ProviderCodeEncrypted = subjectInfoReference.ProviderCodeEncrypted,
                };

                string userControlName = "";
                subjectInfo.BouncedCheque = null;
                subjectInfo.NegativeEvent = null;

                switch (name)
                {
                    case "BC":
                        userControlName = "BouncedCheque";
                        subjectInfo.BouncedCheque = new UIXMLTemp.BouncedCheque();
                        subjectInfo.BouncedCheque = subjectInfoReference.BouncedCheque;
                        stackPanel.Children.Add(new UserControlSection(userControlName, subjectInfo.BouncedCheque, Visibility.Visible, stackPanel));
                        break;
                    case "NE":
                        userControlName = "NegativeEvent";
                        subjectInfo.NegativeEvent = new UIXMLTemp.NegativeEvent();
                        subjectInfo.NegativeEvent = subjectInfoReference.NegativeEvent;
                        stackPanel.Children.Add(new UserControlSection(userControlName, subjectInfo.NegativeEvent, Visibility.Visible, stackPanel));
                        break;
                }

                subjects.Add(subjectInfo);
            }
            return subjects;
        }



    }
}
