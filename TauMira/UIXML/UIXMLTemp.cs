using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Xml.Serialization;
using TauMira.UserCtrls;
using System.Windows.Media;
using static TauMira.UIXML.UIXMLTemp;
using System.Xml.Linq;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TauMira.UIXML
{
    public class UIXMLTemp
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (Envelope)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "CredentialsResponse")]
        public class CredentialsResponse
        {
            public CredentialsResponse()
            {
                Domain =
                Id =
                Password =
                ResultLanguage =
                ResultCode =
                ResultDescription = "";
            }

            [XmlAttribute(AttributeName = "Domain")]
            public string Domain { get; set; }

            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }

            [XmlAttribute(AttributeName = "Password")]
            public string Password { get; set; }

            [XmlAttribute(AttributeName = "ResultLanguage")]
            public string ResultLanguage { get; set; }

            [XmlAttribute(AttributeName = "ResultCode")]
            public string ResultCode { get; set; }

            [XmlAttribute(AttributeName = "ResultDescription")]
            public string ResultDescription { get; set; }
        }

        [XmlRoot(ElementName = "MessageResponse")]
        public class MessageResponse
        {
            public MessageResponse()
            {
                CredentialsResponse = new CredentialsResponse();
                GroupId = ResultDescription = ResultCode = ResultCode = ResultLanguage = Idempotence = Id = "";
                TimeStamp = ExpirationTimeStamp = DateTime.Now;
            }

            [XmlElement(ElementName = "CredentialsResponse")]
            public CredentialsResponse CredentialsResponse { get; set; }

            [XmlAttribute(AttributeName = "GroupId")]
            public string GroupId { get; set; }

            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }

            [XmlAttribute(AttributeName = "TimeStamp")]
            public DateTime TimeStamp { get; set; }

            [XmlAttribute(AttributeName = "Idempotence")]
            public string Idempotence { get; set; }

            [XmlAttribute(AttributeName = "ExpirationTimeStamp")]
            public DateTime ExpirationTimeStamp { get; set; }

            [XmlAttribute(AttributeName = "ResultLanguage")]
            public string ResultLanguage { get; set; }

            [XmlAttribute(AttributeName = "ResultCode")]
            public string ResultCode { get; set; }

            [XmlAttribute(AttributeName = "ResultDescription")]
            public string ResultDescription { get; set; }
        }

        [XmlRoot(ElementName = "MessageId", Namespace = "urn:crif-creditbureau:v1")]
        public class MessageId
        {
            public MessageId()
            {
                CBSMessageId = "";
            }
            [XmlAttribute(AttributeName = "CBSMessageId")]
            public string CBSMessageId { get; set; }
        }

        [XmlRoot(ElementName = "IndividualName", Namespace = "urn:crif-creditbureau:v1")]
        public class IndividualName
        {
            public IndividualName()
            {
                FirstNameArabic = LastNameArabic = FirstNameEnglish = LastNameEnglish = MotherFirstNameEnglish = FatherFirstNameEnglish = GrandFatherFirstNameEnglish = MotherFirstNameArabic = FatherFirstNameArabic = GrandFatherFirstNameArabic = "";
            }

            [XmlAttribute(AttributeName = "FirstNameArabic")]
            public string FirstNameArabic { get; set; }

            [XmlAttribute(AttributeName = "LastNameArabic")]
            public string LastNameArabic { get; set; }

            [XmlAttribute(AttributeName = "FirstNameEnglish")]
            public string FirstNameEnglish { get; set; }

            [XmlAttribute(AttributeName = "LastNameEnglish")]
            public string LastNameEnglish { get; set; }

            [XmlAttribute(AttributeName = "MotherFirstNameEnglish")]
            public string MotherFirstNameEnglish { get; set; }

            [XmlAttribute(AttributeName = "FatherFirstNameEnglish")]
            public string FatherFirstNameEnglish { get; set; }

            [XmlAttribute(AttributeName = "GrandFatherFirstNameEnglish")]
            public string GrandFatherFirstNameEnglish { get; set; }

            [XmlAttribute(AttributeName = "MotherFirstNameArabic")]
            public string MotherFirstNameArabic { get; set; }

            [XmlAttribute(AttributeName = "FatherFirstNameArabic")]
            public string FatherFirstNameArabic { get; set; }

            [XmlAttribute(AttributeName = "GrandFatherFirstNameArabic")]
            public string GrandFatherFirstNameArabic { get; set; }
        }


        [XmlRoot(ElementName = "BirthData", Namespace = "urn:crif-creditbureau:v1")]
        public class BirthData
        {
            public BirthData()
            {
                Date = DateTime.Now;
                Place = Country = "";
            }
            [XmlAttribute(AttributeName = "Date")]
            public DateTime Date { get; set; }



            [XmlAttribute(AttributeName = "Place")]
            public string Place { get; set; }

            [XmlAttribute(AttributeName = "Country")]
            public string Country { get; set; }


        }

        [XmlRoot(ElementName = "BirthData", Namespace = "urn:crif-creditbureau:v1")]
        public class BirthData2
        {
            public BirthData2()
            {
                BirthData = new BirthData();
                BirthDataDesc = new BirthDataDesc();
            }


            [XmlElement(ElementName = "BirthData", Namespace = "urn:crif-creditbureau:v1")]
            public BirthData BirthData { get; set; }

            [XmlElement(ElementName = "BirthDataDesc", Namespace = "urn:crif-creditbureau:v1")]
            public BirthDataDesc BirthDataDesc { get; set; }
        }
        [XmlRoot(ElementName = "Address", Namespace = "urn:crif-creditbureau:v1")]
        public class Address
        {
            public Address()
            {
                Type = "MI";
                FullAddress = "";

                Region = Governorate = "";

            }
            [XmlAttribute(AttributeName = "Type")]
            public string Type { get; set; }

            [XmlAttribute(AttributeName = "FullAddress")]
            public string FullAddress { get; set; }

            [XmlAttribute(AttributeName = "Region")]
            public string Region { get; set; }

            [XmlAttribute(AttributeName = "Governorate")]
            public string Governorate { get; set; }


        }

        [XmlRoot(ElementName = "Address", Namespace = "urn:crif-creditbureau:v1")]
        public class Address2
        {
            public Address2()
            {
                Address = new Address();
                AddressDesc = new AddressDesc();
            }


            [XmlElement(ElementName = "Address", Namespace = "urn:crif-creditbureau:v1")]
            public Address Address { get; set; }

            [XmlElement(ElementName = "AddressDesc", Namespace = "urn:crif-creditbureau:v1")]
            public AddressDesc AddressDesc { get; set; }
        }

        [XmlRoot(ElementName = "AddressDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class AddressDesc
        {
            public AddressDesc()
            {
                TypeDesc = RegionDesc = GovernorateDesc = "";
            }
            [XmlAttribute(AttributeName = "TypeDesc")]
            public string TypeDesc { get; set; }

            [XmlAttribute(AttributeName = "RegionDesc")]
            public string RegionDesc { get; set; }

            [XmlAttribute(AttributeName = "GovernorateDesc")]
            public string GovernorateDesc { get; set; }
        }


        [XmlRoot(ElementName = "IdentificationCode", Namespace = "urn:crif-creditbureau:v1")]
        public class IdentificationCode
        {
            public IdentificationCode()
            {
                Type = 0;
                Number = 0;



            }
            [XmlAttribute(AttributeName = "Type")]
            public int Type { get; set; }

            [XmlAttribute(AttributeName = "Number")]
            public double Number { get; set; }



        }


        [XmlRoot(ElementName = "IdentificationCode", Namespace = "urn:crif-creditbureau:v1")]
        public class IdentificationCode2
        {
            public IdentificationCode2()
            {
                IdentificationCode = new IdentificationCode();
                IdentificationCodeDesc = new IdentificationCodeDesc();
                LastUpdateDate = DateTime.Now;
            }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
            [XmlElement(ElementName = "IdentificationCode", Namespace = "urn:crif-creditbureau:v1")]
            public IdentificationCode IdentificationCode { get; set; }

            [XmlElement(ElementName = "IdentificationCodeDesc", Namespace = "urn:crif-creditbureau:v1")]
            public IdentificationCodeDesc IdentificationCodeDesc { get; set; }


        }

        [XmlRoot(ElementName = "IdentificationCodeDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class IdentificationCodeDesc
        {
            public IdentificationCodeDesc()
            {
                TypeDesc = "";
            }
            [XmlAttribute(AttributeName = "TypeDesc")]
            public string TypeDesc { get; set; }
        }

        [XmlRoot(ElementName = "Contact", Namespace = "urn:crif-creditbureau:v1")]
        public class Contact
        {
            public Contact()
            {
                Type = 0;
                Value = "";


            }
            [XmlAttribute(AttributeName = "Type")]
            public int Type { get; set; }

            [XmlAttribute(AttributeName = "Value")]
            public string Value { get; set; }


        }

        [XmlRoot(ElementName = "Contact", Namespace = "urn:crif-creditbureau:v1")]
        public class Contact2
        {
            public Contact2()
            {
                Contact = new Contact();
                ContactDesc = new ContactDesc();
                LastUpdateDate = DateTime.Now;
            }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
            [XmlElement(ElementName = "Contact", Namespace = "urn:crif-creditbureau:v1")]
            public Contact Contact { get; set; }

            [XmlElement(ElementName = "ContactDesc", Namespace = "urn:crif-creditbureau:v1")]
            public ContactDesc ContactDesc { get; set; }


        }

        [XmlRoot(ElementName = "ContactDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class ContactDesc
        {
            public ContactDesc()
            {
                TypeDesc = "";
            }
            [XmlAttribute(AttributeName = "TypeDesc")]
            public string TypeDesc { get; set; }
        }

        [XmlRoot(ElementName = "Individual", Namespace = "urn:crif-creditbureau:v1")]
        public class Individual
        {
            public Individual()
            {
                Contact = new List<Contact2>();

                EmploymentData = new EmploymentData2();

                CompanyLink = new CompanyLink();

                individualName = new IndividualName();
                birthData2 = new BirthData2();
                Title =
                MaritalStatus =
                NumberOfLegalDependants = 0;

                address = new Address();



                Gender =
                GenderDesc =
                TitleDesc =
                Nationality =
                NationalityDesc =
                MaritalStatusDesc =
                NameOfSpouse = "";



                LastUpdateDate = DateTime.Now;
            }




            [XmlElement(ElementName = "IndividualName", Namespace = "urn:crif-creditbureau:v1")]
            public IndividualName individualName { get; set; }


            [XmlElement(ElementName = "BirthData", Namespace = "urn:crif-creditbureau:v1")]
            public BirthData2 birthData2 { get; set; }

            [XmlElement(ElementName = "Address", Namespace = "urn:crif-creditbureau:v1")]
            public Address address { get; set; }

            [XmlElement(ElementName = "Contact", Namespace = "urn:crif-creditbureau:v1")]
            public List<Contact2> Contact { get; set; }

            [XmlElement(ElementName = "EmploymentData", Namespace = "urn:crif-creditbureau:v1")]
            public EmploymentData2 EmploymentData { get; set; }

            [XmlElement(ElementName = "CompanyLink", Namespace = "urn:crif-creditbureau:v1")]
            public CompanyLink CompanyLink { get; set; }

            [XmlAttribute(AttributeName = "Gender")]
            public string Gender { get; set; }

            [XmlAttribute(AttributeName = "GenderDesc")]
            public string GenderDesc { get; set; }

            [XmlAttribute(AttributeName = "Title")]
            public int Title { get; set; }



            [XmlAttribute(AttributeName = "TitleDesc")]
            public string TitleDesc { get; set; }

            [XmlAttribute(AttributeName = "Nationality")]
            public string Nationality { get; set; }

            [XmlAttribute(AttributeName = "NationalityDesc")]
            public string NationalityDesc { get; set; }

            [XmlAttribute(AttributeName = "MaritalStatus")]
            public int MaritalStatus { get; set; }

            [XmlAttribute(AttributeName = "MaritalStatusDesc")]
            public string MaritalStatusDesc { get; set; }

            [XmlAttribute(AttributeName = "NameOfSpouse")]
            public string NameOfSpouse { get; set; }

            [XmlAttribute(AttributeName = "NumberOfLegalDependants")]
            public int NumberOfLegalDependants { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
        }

        [XmlRoot(ElementName = "Subject", Namespace = "")]
        public class Subject
        {
            public Subject()
            {
                Individual = new Individual();
            }
            [XmlElement(ElementName = "Individual", Namespace = "urn:crif-creditbureau:v1")]
            public Individual Individual { get; set; }
        }

        [XmlRoot(ElementName = "Installment", Namespace = "")]
        public class Installment
        {

            public Installment()
            {
                FinancedAmount = InstallmentsNumber = 0;
                PaymentPeriodicity = "";

            }
            [XmlAttribute(AttributeName = "FinancedAmount")]
            public int FinancedAmount { get; set; }

            [XmlAttribute(AttributeName = "InstallmentsNumber")]
            public int InstallmentsNumber { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }


        }

        [XmlRoot(ElementName = "Application", Namespace = "")]
        public class Application
        {
            public Application()
            {
                Installment = new Installment();

                ContractRequestDate = DateTime.Now;

                ContractType =
                CreditFacilityPurpose = 0;



                ContractPhase =
                Currency = "";

            }
            [XmlElement(ElementName = "Installment", Namespace = "urn:crif-creditbureau:v1")]
            public Installment Installment { get; set; }

            [XmlAttribute(AttributeName = "ContractType")]
            public int ContractType { get; set; }

            [XmlAttribute(AttributeName = "ContractPhase")]
            public string ContractPhase { get; set; }

            [XmlAttribute(AttributeName = "ContractRequestDate")]
            public DateTime ContractRequestDate { get; set; }

            [XmlAttribute(AttributeName = "Currency")]
            public string Currency { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurpose")]
            public int CreditFacilityPurpose { get; set; }
        }

        [XmlRoot(ElementName = "ApplicationDesc", Namespace = "")]
        public class ApplicationDesc
        {

            public ApplicationDesc()
            {
                ContractTypeDesc =
                ContractPhaseDesc =
                CurrencyDesc =
                PaymentPeriodicityDesc =
                CreditFacilityPurposeDesc = "";
            }
            [XmlAttribute(AttributeName = "ContractTypeDesc")]
            public string ContractTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractPhaseDesc")]
            public string ContractPhaseDesc { get; set; }

            [XmlAttribute(AttributeName = "CurrencyDesc")]
            public string CurrencyDesc { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurposeDesc")]
            public string CreditFacilityPurposeDesc { get; set; }
        }

        [XmlRoot(ElementName = "Link", Namespace = "")]
        public class Link
        {
            public Link()
            {
                Role = "";
            }
            [XmlAttribute(AttributeName = "Role")]
            public string Role { get; set; }
        }

        [XmlRoot(ElementName = "LinkDesc", Namespace = "")]
        public class LinkDesc
        {
            public LinkDesc()
            {
                RoleDesc = "";
            }
            [XmlAttribute(AttributeName = "RoleDesc")]
            public string RoleDesc { get; set; }
        }

        [XmlRoot(ElementName = "EnquiredData", Namespace = "urn:crif-creditbureau:v1")]
        public class EnquiredData
        {
            public EnquiredData()
            {
                Subject = new Subject();
                Application = new Application();
                ApplicationDesc = new ApplicationDesc();
                Link = new Link();
                LinkDesc = new LinkDesc();
                SubjectRefDate = DateTime.Now;
            }
            [XmlElement(ElementName = "Subject", Namespace = "urn:crif-creditbureau:v1")]
            public Subject Subject { get; set; }

            [XmlElement(ElementName = "Application", Namespace = "urn:crif-creditbureau:v1")]
            public Application Application { get; set; }

            [XmlElement(ElementName = "ApplicationDesc", Namespace = "urn:crif-creditbureau:v1")]
            public ApplicationDesc ApplicationDesc { get; set; }

            [XmlElement(ElementName = "Link", Namespace = "urn:crif-creditbureau:v1")]
            public Link Link { get; set; }

            [XmlElement(ElementName = "LinkDesc", Namespace = "urn:crif-creditbureau:v1")]
            public LinkDesc LinkDesc { get; set; }

            [XmlAttribute(AttributeName = "SubjectRefDate")]
            public DateTime SubjectRefDate { get; set; }
        }

        [XmlRoot(ElementName = "ApplicationCodes", Namespace = "")]
        public class ApplicationCodes
        {
            public ApplicationCodes()
            {
                ProviderApplicationNo = "";
                CBContractCode = "";
            }
            [XmlAttribute(AttributeName = "ProviderApplicationNo")]
            public string ProviderApplicationNo { get; set; }

            [XmlAttribute(AttributeName = "CBContractCode")]
            public string CBContractCode { get; set; }
        }

        [XmlRoot(ElementName = "BirthDataDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class BirthDataDesc
        {
            public BirthDataDesc()
            {
                CountryDesc = "";
            }
            [XmlAttribute(AttributeName = "CountryDesc")]
            public string CountryDesc { get; set; }
        }

        [XmlRoot(ElementName = "AddressHistory", Namespace = "urn:crif-creditbureau:v1")]
        public class AddressHistory
        {

            public AddressHistory()
            {
                Address = new Address2();
                AddressDesc = new AddressDesc();
                FlagCurrent = 0;
                LastUpdateDate = DateTime.Now;
            }

            [XmlElement(ElementName = "Address", Namespace = "urn:crif-creditbureau:v1")]
            public Address2 Address { get; set; }

            [XmlElement(ElementName = "AddressDesc", Namespace = "urn:crif-creditbureau:v1")]
            public AddressDesc AddressDesc { get; set; }

            [XmlAttribute(AttributeName = "FlagCurrent")]
            public int FlagCurrent { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
        }

        [XmlRoot(ElementName = "ID", Namespace = "urn:crif-creditbureau:v1")]
        public class ID
        {
            public ID()
            {


                Number =
                IssueCountry = "";

                Type = 0;


                IssueDate =
                ExpiryDate = DateTime.Now;



            }
            [XmlAttribute(AttributeName = "Type")]
            public int Type { get; set; }

            [XmlAttribute(AttributeName = "Number")]
            public string Number { get; set; }

            [XmlAttribute(AttributeName = "IssueDate")]
            public DateTime IssueDate { get; set; }

            [XmlAttribute(AttributeName = "IssueCountry")]
            public string IssueCountry { get; set; }

            [XmlAttribute(AttributeName = "ExpiryDate")]
            public DateTime ExpiryDate { get; set; }


        }

        [XmlRoot(ElementName = "ID", Namespace = "urn:crif-creditbureau:v1")]
        public class ID2
        {
            public ID2()
            {
                IDDesc = new IDDesc();

                ID = new ID();

                LastUpdateDate = DateTime.Now;



            }


            [XmlElement(ElementName = "ID", Namespace = "urn:crif-creditbureau:v1")]
            public ID ID { get; set; }

            [XmlElement(ElementName = "IDDesc", Namespace = "urn:crif-creditbureau:v1")]
            public IDDesc IDDesc { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
        }

        [XmlRoot(ElementName = "IDDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class IDDesc
        {
            public IDDesc()
            {
                TypeDesc = IssueCountryDesc = "";
            }
            [XmlAttribute(AttributeName = "TypeDesc")]
            public string TypeDesc { get; set; }

            [XmlAttribute(AttributeName = "IssueCountryDesc")]
            public string IssueCountryDesc { get; set; }
        }

        [XmlRoot(ElementName = "CompanyName", Namespace = "urn:crif-creditbureau:v1")]
        public class CompanyName
        {
            public CompanyName()
            {
                TradeName = "";
            }
            [XmlAttribute(AttributeName = "TradeName")]
            public string TradeName { get; set; }
        }

        [XmlRoot(ElementName = "CompanyAddress", Namespace = "urn:crif-creditbureau:v1")]
        public class CompanyAddress
        {
            public CompanyAddress()
            {
                EmployerAddress = "";
            }
            [XmlAttribute(AttributeName = "EmployerAddress")]
            public string EmployerAddress { get; set; }
        }

        [XmlRoot(ElementName = "EmployerData", Namespace = "urn:crif-creditbureau:v1")]
        public class EmployerData
        {
            public EmployerData()
            {
                CompanyName = new CompanyName();
                CompanyAddress = new CompanyAddress();
            }
            [XmlElement(ElementName = "CompanyName", Namespace = "urn:crif-creditbureau:v1")]
            public CompanyName CompanyName { get; set; }

            [XmlElement(ElementName = "CompanyAddress", Namespace = "urn:crif-creditbureau:v1")]
            public CompanyAddress CompanyAddress { get; set; }
        }

        [XmlRoot(ElementName = "EmploymentData", Namespace = "urn:crif-creditbureau:v1")]
        public class EmploymentData
        {
            public EmploymentData()
            {
                this.EmployerData = new UIXMLTemp.EmployerData();
                Currency =
                Occupation = "";
                GrossIncome = OccupationStatus = 0;
                DateHired = DateTime.Now;
            }
            [XmlElement(ElementName = "EmployerData", Namespace = "urn:crif-creditbureau:v1")]
            public EmployerData EmployerData { get; set; }

            [XmlAttribute(AttributeName = "GrossIncome")]
            public int GrossIncome { get; set; }

            [XmlAttribute(AttributeName = "Currency")]
            public string Currency { get; set; }

            [XmlAttribute(AttributeName = "OccupationStatus")]
            public int OccupationStatus { get; set; }

            [XmlAttribute(AttributeName = "DateHired")]
            public DateTime DateHired { get; set; }

            [XmlAttribute(AttributeName = "Occupation")]
            public string Occupation { get; set; }



        }

        [XmlRoot(ElementName = "EmploymentData", Namespace = "urn:crif-creditbureau:v1")]
        public class EmploymentData2
        {
            public EmploymentData2()
            {

                EmploymentData = new EmploymentData();
                this.EmploymentDataDesc = new UIXMLTemp.EmploymentDataDesc();
                LastUpdateDate = DateTime.Now;
            }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }
            [XmlElement(ElementName = "EmploymentData", Namespace = "urn:crif-creditbureau:v1")]
            public EmploymentData EmploymentData { get; set; }

            [XmlElement(ElementName = "EmploymentDataDesc", Namespace = "urn:crif-creditbureau:v1")]
            public EmploymentDataDesc EmploymentDataDesc { get; set; }


        }

        [XmlRoot(ElementName = "EmploymentDataDesc", Namespace = "urn:crif-creditbureau:v1")]
        public class EmploymentDataDesc
        {
            public EmploymentDataDesc()
            {
                OccupationStatusDesc = CurrencyDesc = "";
            }
            [XmlAttribute(AttributeName = "OccupationStatusDesc")]
            public string OccupationStatusDesc { get; set; }

            [XmlAttribute(AttributeName = "CurrencyDesc")]
            public string CurrencyDesc { get; set; }
        }

        [XmlRoot(ElementName = "CompanyLink", Namespace = "urn:crif-creditbureau:v1")]
        public class CompanyLink
        {
            public CompanyLink()
            {
                CBSubjectCode

               = Name

               = CompanyRole

               = CompanyRoleDesc = "";


                LastUpdateDate = DateTime.Now;

                ProviderCounter =
                ParentFlag = 0;
            }
            [XmlAttribute(AttributeName = "CBSubjectCode")]
            public string CBSubjectCode { get; set; }

            [XmlAttribute(AttributeName = "Name")]
            public string Name { get; set; }

            [XmlAttribute(AttributeName = "CompanyRole")]
            public string CompanyRole { get; set; }

            [XmlAttribute(AttributeName = "CompanyRoleDesc")]
            public string CompanyRoleDesc { get; set; }

            [XmlAttribute(AttributeName = "ProviderCounter")]
            public int ProviderCounter { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [XmlAttribute(AttributeName = "ParentFlag")]
            public int ParentFlag { get; set; }
        }

        [XmlRoot(ElementName = "MatchedSubject", Namespace = "urn:crif-creditbureau:v1")]
        public class MatchedSubject
        {
            public MatchedSubject()
            {
                Individual = new Individual();
                CBSubjectCode = "";
                FlagMatched = 0;
            }

            [XmlElement(ElementName = "Individual", Namespace = "urn:crif-creditbureau:v1")]
            public Individual Individual { get; set; }

            [XmlAttribute(AttributeName = "CBSubjectCode")]
            public string CBSubjectCode { get; set; }

            [XmlAttribute(AttributeName = "FlagMatched")]
            public int FlagMatched { get; set; }
        }

        [XmlRoot(ElementName = "NegativeEvent", Namespace = "urn:crif-creditbureau:v1")]
        public class NegativeEvent
        {
            public NegativeEvent()
            {
                EventDetail
                = ProviderNegativeEventNo
                = EventStatus
                = EventStatusDesc = "";

                LastUpdateDate =
                EventDate =
                EventStatusDate = DateTime.Now;
            }
            [XmlAttribute(AttributeName = "EventDetail")]
            public string EventDetail { get; set; }

            [XmlAttribute(AttributeName = "EventDate")]
            public DateTime EventDate { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [XmlAttribute(AttributeName = "ProviderNegativeEventNo")]
            public string ProviderNegativeEventNo { get; set; }

            [XmlAttribute(AttributeName = "EventStatus")]
            public string EventStatus { get; set; }

            [XmlAttribute(AttributeName = "EventStatusDesc")]
            public string EventStatusDesc { get; set; }

            [XmlAttribute(AttributeName = "EventStatusDate")]
            public DateTime EventStatusDate { get; set; }
        }

        [XmlRoot(ElementName = "BouncedCheque", Namespace = "urn:crif-creditbureau:v1")]
        public class BouncedCheque
        {
            public BouncedCheque()
            {
                BouncedChequeReferenceNumber = Currency = CurrencyDesc = ReasonCodeDesc = SettlementMethodDesc = "";
                ChequeNumber = MicrNumber = BouncedChequeAmount = ReasonCode = SettlementMethod = 0;
                DateOfIssue = SettlementDate = BouncedChequeReferenceDate = BouncedChequeDate = LastUpdatedDate = DateTime.Now;
            }

            [XmlAttribute(AttributeName = "BouncedChequeReferenceNumber")]
            public string BouncedChequeReferenceNumber { get; set; }

            [XmlAttribute(AttributeName = "BouncedChequeDate")]
            public DateTime BouncedChequeDate { get; set; }

            [XmlAttribute(AttributeName = "BouncedChequeReferenceDate")]
            public DateTime BouncedChequeReferenceDate { get; set; }

            [XmlAttribute(AttributeName = "MicrNumber")]
            public int MicrNumber { get; set; }

            [XmlAttribute(AttributeName = "ChequeNumber")]
            public int ChequeNumber { get; set; }

            [XmlAttribute(AttributeName = "DateOfIssue")]
            public DateTime DateOfIssue { get; set; }

            [XmlAttribute(AttributeName = "Currency")]
            public string Currency { get; set; }

            [XmlAttribute(AttributeName = "CurrencyDesc")]
            public string CurrencyDesc { get; set; }

            [XmlAttribute(AttributeName = "BouncedChequeAmount")]
            public int BouncedChequeAmount { get; set; }

            [XmlAttribute(AttributeName = "ReasonCode")]
            public int ReasonCode { get; set; }

            [XmlAttribute(AttributeName = "ReasonCodeDesc")]
            public string ReasonCodeDesc { get; set; }

            [XmlAttribute(AttributeName = "SettlementDate")]
            public DateTime SettlementDate { get; set; }

            [XmlAttribute(AttributeName = "SettlementMethod")]
            public int SettlementMethod { get; set; }

            [XmlAttribute(AttributeName = "SettlementMethodDesc")]
            public string SettlementMethodDesc { get; set; }

            [XmlAttribute(AttributeName = "LastUpdatedDate")]
            public DateTime LastUpdatedDate { get; set; }
        }

        [XmlRoot(ElementName = "SubjectInfo", Namespace = "urn:crif-creditbureau:v1")]
        public class SubjectInfo
        {
            public SubjectInfo()
            {
                NegativeEvent = new NegativeEvent();
                BouncedCheque = new BouncedCheque();
                SubjectInfoCategory = ProviderCodeEncrypted = SubjectInfoCategoryDesc = SubjectInfoTypeCode = SubjectInfoTypeCodeDesc = "";
            }

            [XmlElement(ElementName = "NegativeEvent", Namespace = "urn:crif-creditbureau:v1")]
            public NegativeEvent NegativeEvent { get; set; }

            [XmlElement(ElementName = "BouncedCheque", Namespace = "urn:crif-creditbureau:v1")]
            public BouncedCheque BouncedCheque { get; set; }

            [XmlAttribute(AttributeName = "SubjectInfoCategory")]
            public string SubjectInfoCategory { get; set; }

            [XmlAttribute(AttributeName = "SubjectInfoCategoryDesc")]
            public string SubjectInfoCategoryDesc { get; set; }

            [XmlAttribute(AttributeName = "SubjectInfoTypeCode")]
            public string SubjectInfoTypeCode { get; set; }

            [XmlAttribute(AttributeName = "SubjectInfoTypeCodeDesc")]
            public string SubjectInfoTypeCodeDesc { get; set; }

            [XmlAttribute(AttributeName = "ProviderCodeEncrypted")]
            public string ProviderCodeEncrypted { get; set; }
        }

        [XmlRoot(ElementName = "AggregatedData", Namespace = "urn:crif-creditbureau:v1")]
        public class AggregatedData
        {

            public AggregatedData()
            {
                ContractsNumber = ReportingProvidersNumber = FlagReciprocityMissingContracts = TotalPotentialExposure = TotalOutstanding = TotalOverdue = TotalRequestedAmount = NoActiveContracts = NewContractsLastYear = ClosedContractsLastYear = NoOfContractsInDeliquency = WorstDelinquencyLevel = MaxOverDueAmount = 0;

                ReportingProvidersType = Currency = CurrentSubjectStatus = CurrencyDesc = "";

            }

            [XmlAttribute(AttributeName = "ContractsNumber")]
            public int ContractsNumber { get; set; }

            [XmlAttribute(AttributeName = "ReportingProvidersNumber")]
            public int ReportingProvidersNumber { get; set; }

            [XmlAttribute(AttributeName = "ReportingProvidersType")]
            public string ReportingProvidersType { get; set; }

            [XmlAttribute(AttributeName = "FlagReciprocityMissingContracts")]
            public int FlagReciprocityMissingContracts { get; set; }

            [XmlAttribute(AttributeName = "TotalPotentialExposure")]
            public int TotalPotentialExposure { get; set; }

            [XmlAttribute(AttributeName = "TotalOutstanding")]
            public int TotalOutstanding { get; set; }

            [XmlAttribute(AttributeName = "TotalOverdue")]
            public int TotalOverdue { get; set; }

            [XmlAttribute(AttributeName = "TotalRequestedAmount")]
            public int TotalRequestedAmount { get; set; }

            [XmlAttribute(AttributeName = "Currency")]
            public string Currency { get; set; }

            [XmlAttribute(AttributeName = "CurrencyDesc")]
            public string CurrencyDesc { get; set; }

            [XmlAttribute(AttributeName = "NoActiveContracts")]
            public int NoActiveContracts { get; set; }

            [XmlAttribute(AttributeName = "NewContractsLastYear")]
            public int NewContractsLastYear { get; set; }

            [XmlAttribute(AttributeName = "ClosedContractsLastYear")]
            public int ClosedContractsLastYear { get; set; }

            [XmlAttribute(AttributeName = "CurrentSubjectStatus")]
            public string CurrentSubjectStatus { get; set; }

            [XmlAttribute(AttributeName = "NoOfContractsInDeliquency")]
            public int NoOfContractsInDeliquency { get; set; }

            [XmlAttribute(AttributeName = "WorstDelinquencyLevel")]
            public int WorstDelinquencyLevel { get; set; }

            [XmlAttribute(AttributeName = "MaxOverDueAmount")]
            public int MaxOverDueAmount { get; set; }
        }

        [XmlRoot(ElementName = "NumbersSummary", Namespace = "urn:crif-creditbureau:v1")]
        public class NumbersSummary
        {
            public NumbersSummary()
            {

                Requested = Active = Refused = Renounced = Closed = 0;
            }

            [XmlAttribute(AttributeName = "Requested")]
            public int Requested { get; set; }

            [XmlAttribute(AttributeName = "Active")]
            public int Active { get; set; }

            [XmlAttribute(AttributeName = "Refused")]
            public int Refused { get; set; }

            [XmlAttribute(AttributeName = "Renounced")]
            public int Renounced { get; set; }

            [XmlAttribute(AttributeName = "Closed")]
            public int Closed { get; set; }
        }

        [XmlRoot(ElementName = "BCAmounts", Namespace = "urn:crif-creditbureau:v1")]
        public class BCAmounts
        {
            public BCAmounts()
            {
                MonthlyPayments = OutstandingBalance = Overdue = CreditLimit = Utilization = Overdraft = BilledAmount = 0;
            }
            [XmlAttribute(AttributeName = "MonthlyPayments")]
            public int MonthlyPayments { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "Overdue")]
            public int Overdue { get; set; }

            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "Utilization")]
            public int Utilization { get; set; }

            [XmlAttribute(AttributeName = "Overdraft")]
            public int Overdraft { get; set; }

            [XmlAttribute(AttributeName = "BilledAmount")]
            public int BilledAmount { get; set; }
        }

        [XmlRoot(ElementName = "GAmounts", Namespace = "urn:crif-creditbureau:v1")]
        public class GAmounts
        {
            public GAmounts()
            {
                MonthlyPayments = OutstandingBalance = Overdue = CreditLimit = Utilization = Overdraft = BilledAmount = 0;
            }
            [XmlAttribute(AttributeName = "MonthlyPayments")]
            public int MonthlyPayments { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "Overdue")]
            public int Overdue { get; set; }

            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "Utilization")]
            public int Utilization { get; set; }

            [XmlAttribute(AttributeName = "Overdraft")]
            public int Overdraft { get; set; }

            [XmlAttribute(AttributeName = "BilledAmount")]
            public int BilledAmount { get; set; }
        }

        [XmlRoot(ElementName = "AmountsSummary", Namespace = "urn:crif-creditbureau:v1")]
        public class AmountsSummary
        {
            public AmountsSummary()
            {
                BCAmounts = new BCAmounts();

                GAmounts = new GAmounts();

                ContractsCounter = 0;

                OverdueFlag = OverdraftFlag = false;
            }
            [XmlElement(ElementName = "BCAmounts", Namespace = "urn:crif-creditbureau:v1")]
            public BCAmounts BCAmounts { get; set; }

            [XmlElement(ElementName = "GAmounts", Namespace = "urn:crif-creditbureau:v1")]
            public GAmounts GAmounts { get; set; }

            [XmlAttribute(AttributeName = "ContractsCounter")]
            public int ContractsCounter { get; set; }

            [XmlAttribute(AttributeName = "OverdueFlag")]
            public bool OverdueFlag { get; set; }

            [XmlAttribute(AttributeName = "OverdraftFlag")]
            public bool OverdraftFlag { get; set; }
        }


        [XmlRoot(ElementName = "NotGrantedContract", Namespace = "urn:crif-creditbureau:v1")]
        public class NotGrantedContract
        {
            public NotGrantedContract()
            {
                CBContractCode = "";
                ContractType = 0;
                CreditFacilityPurpose = 0;

                ContractTypeDesc = ProviderCodeEncrypted = ContractPhase = CreditFacilityPurposeDesc = ContractPhaseDesc = Role = RoleDesc = "";
                ContractRequestDate = LastUpdateDate = DateTime.Now;



            }

            [XmlAttribute(AttributeName = "CBContractCode")]
            public string CBContractCode { get; set; }

            [XmlAttribute(AttributeName = "ContractType")]
            public int ContractType { get; set; }

            [XmlAttribute(AttributeName = "ContractTypeDesc")]
            public string ContractTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractPhase")]
            public string ContractPhase { get; set; }

            [XmlAttribute(AttributeName = "ContractPhaseDesc")]
            public string ContractPhaseDesc { get; set; }

            [XmlAttribute(AttributeName = "Role")]
            public string Role { get; set; }

            [XmlAttribute(AttributeName = "RoleDesc")]
            public string RoleDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractRequestDate")]
            public DateTime ContractRequestDate { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [XmlAttribute(AttributeName = "ProviderCodeEncrypted")]
            public string ProviderCodeEncrypted { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurpose")]
            public int CreditFacilityPurpose { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurposeDesc")]
            public string CreditFacilityPurposeDesc { get; set; }



        }

        [XmlRoot(ElementName = "NotGrantedContract", Namespace = "urn:crif-creditbureau:v1")]
        public class NotGrantedContract2
        {
            public NotGrantedContract2()
            {
                NotGrantedContract = new NotGrantedContract();
                NotGrantedInstallment = new NotGrantedInstallment();

                NotGrantedCard = new NotGrantedCard();
            }



            [XmlElement(ElementName = "NotGrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public NotGrantedContract NotGrantedContract { get; set; }


            [XmlElement(ElementName = "NotGrantedInstallment", Namespace = "urn:crif-creditbureau:v1")]
            public NotGrantedInstallment NotGrantedInstallment { get; set; }

            [XmlElement(ElementName = "NotGrantedCard", Namespace = "urn:crif-creditbureau:v1")]
            public NotGrantedCard NotGrantedCard { get; set; }

        }

        [XmlRoot(ElementName = "NotGrantedInstallment", Namespace = "urn:crif-creditbureau:v1")]
        public class NotGrantedInstallment
        {
            public NotGrantedInstallment()
            {
                FinancedAmount = InstallmentsNumber = 0;
                PaymentPeriodicity = PaymentPeriodicityDesc = "";
            }
            [XmlAttribute(AttributeName = "FinancedAmount")]
            public int FinancedAmount { get; set; }

            [XmlAttribute(AttributeName = "InstallmentsNumber")]
            public int InstallmentsNumber { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }
        }

        [XmlRoot(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedContract
        {
            public GrantedContract()
            {
                CBContractCode = ProviderContractNo = ProviderCodeEncrypted = ContractTypeDesc = ContractPhase = ContractPhaseDesc = Role = RoleDesc = OriginalCurrency = CreditFacilityPurposeDesc = OriginalCurrencyDesc = "";

                ContractType = CreditFacilityPurpose = 0;

                ContractStartDate = LastUpdateDate = DateTime.Now;
                ContractEndDate = new DateTime();

            }
            [XmlAttribute(AttributeName = "CBContractCode")]
            public string CBContractCode { get; set; }

            [XmlAttribute(AttributeName = "ProviderContractNo")]
            public string ProviderContractNo { get; set; }

            [XmlAttribute(AttributeName = "ContractType")]
            public int ContractType { get; set; }

            [XmlAttribute(AttributeName = "ContractTypeDesc")]
            public string ContractTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractPhase")]
            public string ContractPhase { get; set; }

            [XmlAttribute(AttributeName = "ContractPhaseDesc")]
            public string ContractPhaseDesc { get; set; }

            [XmlAttribute(AttributeName = "Role")]
            public string Role { get; set; }

            [XmlAttribute(AttributeName = "RoleDesc")]
            public string RoleDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractStartDate")]
            public DateTime ContractStartDate { get; set; }

            [XmlAttribute(AttributeName = "ContractEndDate")]
            public DateTime ContractEndDate { get; set; }

            [XmlAttribute(AttributeName = "LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [XmlAttribute(AttributeName = "OriginalCurrency")]
            public string OriginalCurrency { get; set; }

            [XmlAttribute(AttributeName = "OriginalCurrencyDesc")]
            public string OriginalCurrencyDesc { get; set; }

            [XmlAttribute(AttributeName = "ProviderCodeEncrypted")]
            public string ProviderCodeEncrypted { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurpose")]
            public int CreditFacilityPurpose { get; set; }

            [XmlAttribute(AttributeName = "CreditFacilityPurposeDesc")]
            public string CreditFacilityPurposeDesc { get; set; }



        }



        [XmlRoot(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedContract2<T> where T : Profile
        {
            public GrantedContract2()
            {
                GrantedContract = new GrantedContract();
                GrantedInstallment = new GrantedInstallment();

                Maximum = new Maximum();

                Profile = new List<T>();

                Guarantee = new Guarantee();

                GrantedNonInstallment = new GrantedNonInstallment();

                GrantedCard = new GrantedCard();

                GrantedService = new GrantedService();
            }


            [XmlElement(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedContract GrantedContract { get; set; }
            [XmlElement(ElementName = "GrantedInstallment", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedInstallment GrantedInstallment { get; set; }

            [XmlElement(ElementName = "Maximum", Namespace = "urn:crif-creditbureau:v1")]
            public Maximum Maximum { get; set; }

            [XmlElement(ElementName = "Profile", Namespace = "urn:crif-creditbureau:v1")]
            public List<T> Profile { get; set; }

            [XmlElement(ElementName = "Guarantee", Namespace = "urn:crif-creditbureau:v1")]
            public Guarantee Guarantee { get; set; }

            [XmlElement(ElementName = "GrantedNonInstallment", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedNonInstallment GrantedNonInstallment { get; set; }

            [XmlElement(ElementName = "GrantedCard", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedCard GrantedCard { get; set; }

            [XmlElement(ElementName = "GrantedService", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedService GrantedService { get; set; }

        }

        [XmlRoot(ElementName = "GrantedInstallment", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedInstallment
        {
            public GrantedInstallment()
            {
                TransactionType = TransactionTypeDesc = PaymentPeriodicity = PaymentMethodDesc = PaymentMethod = PaymentPeriodicityDesc = DaysPastDueDesc = ReorganizedCreditCodeDesc = "";
                FinancedAmount = MonthlyPaymentAmount = NextPayment = OutstandingPaymentsNumber = InstallmentsNumber = OutstandingBalance = OverduePaymentsNumber = OverduePaymentsAmount = DaysPastDue = ReorganizedCreditCode = 0;
                NextPaymentDate = FirstPaymentDate = LastPaymentDate = DateTime.Now;

            }


            [XmlAttribute(AttributeName = "TransactionType")]
            public string TransactionType { get; set; }

            [XmlAttribute(AttributeName = "TransactionTypeDesc")]
            public string TransactionTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "FinancedAmount")]
            public int FinancedAmount { get; set; }

            [XmlAttribute(AttributeName = "MonthlyPaymentAmount")]
            public int MonthlyPaymentAmount { get; set; }

            [XmlAttribute(AttributeName = "InstallmentsNumber")]
            public int InstallmentsNumber { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethod")]
            public string PaymentMethod { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethodDesc")]
            public string PaymentMethodDesc { get; set; }

            [XmlAttribute(AttributeName = "NextPayment")]
            public int NextPayment { get; set; }

            [XmlAttribute(AttributeName = "NextPaymentDate")]
            public DateTime NextPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "FirstPaymentDate")]
            public DateTime FirstPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "LastPaymentDate")]
            public DateTime LastPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "OutstandingPaymentsNumber")]
            public int OutstandingPaymentsNumber { get; set; }


            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsNumber")]
            public int OverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsAmount")]
            public int OverduePaymentsAmount { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCode")]
            public int ReorganizedCreditCode { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCodeDesc")]
            public string ReorganizedCreditCodeDesc { get; set; }
        }

        [XmlRoot(ElementName = "Maximum", Namespace = "urn:crif-creditbureau:v1")]
        public class Maximum
        {

            public Maximum()
            {
                MaxOverduePaymentsAmount = MaxChargedAmount = MaxOutstandingBalance = MaxDaysPastDue = MaxOverduePaymentsNumber = MaxOverTheLimitAmount = MaxBilledAmount = 0;
                MaxDaysPastDueDesc = WorstStatus = WorstStatusDesc = "";
                MaxDaysPastDueDate = MaxChargedAmountDate = MaxOutstandingBalanceDate = WorstStatusDate = DateTime.Now;
            }
            [XmlAttribute(AttributeName = "MaxOverduePaymentsAmount")]
            public int MaxOverduePaymentsAmount { get; set; }

            [XmlAttribute(AttributeName = "MaxOverduePaymentsNumber")]
            public int MaxOverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "MaxDaysPastDue")]
            public int MaxDaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "MaxDaysPastDueDesc")]
            public string MaxDaysPastDueDesc { get; set; }

            [XmlAttribute(AttributeName = "MaxDaysPastDueDate")]
            public DateTime MaxDaysPastDueDate { get; set; }

            [XmlAttribute(AttributeName = "WorstStatus")]
            public string WorstStatus { get; set; }

            [XmlAttribute(AttributeName = "WorstStatusDesc")]
            public string WorstStatusDesc { get; set; }

            [XmlAttribute(AttributeName = "WorstStatusDate")]
            public DateTime WorstStatusDate { get; set; }

            [XmlAttribute(AttributeName = "MaxOutstandingBalance")]
            public int MaxOutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "MaxOutstandingBalanceDate")]
            public DateTime MaxOutstandingBalanceDate { get; set; }

            [XmlAttribute(AttributeName = "MaxChargedAmount")]
            public int MaxChargedAmount { get; set; }

            [XmlAttribute(AttributeName = "MaxChargedAmountDate")]
            public DateTime MaxChargedAmountDate { get; set; }

            [XmlAttribute(AttributeName = "MaxOverTheLimitAmount")]
            public int MaxOverTheLimitAmount { get; set; }

            [XmlAttribute(AttributeName = "MaxBilledAmount")]
            public int MaxBilledAmount { get; set; }
        }

        [XmlRoot(ElementName = "Profile", Namespace = "urn:crif-creditbureau:v1")]
        public class Profile
        {
            [XmlAttribute(AttributeName = "ReferenceYear")]
            public int ReferenceYear { get; set; }

            [XmlAttribute(AttributeName = "ReferenceMonth")]
            public int ReferenceMonth { get; set; }

            [XmlAttribute(AttributeName = "Status")]
            public string Status { get; set; }

            [XmlAttribute(AttributeName = "StatusDesc")]
            public string StatusDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractStatusLastUpdate")]
            public string ContractStatusLastUpdate { get; set; }

            [XmlAttribute(AttributeName = "ContractStatusLastUpdateDesc")]
            public string ContractStatusLastUpdateDesc { get; set; }

            [XmlAttribute(AttributeName = "ContractStatusLastUpdateDate")]
            public DateTime ContractStatusLastUpdateDate { get; set; }

            public Profile()
            {
                var lastMonth = DateTime.Today.AddMonths(0);
                ReferenceYear = lastMonth.Year;
                ReferenceMonth = lastMonth.Month;
                Status = "B";
                StatusDesc = "No info";
                ContractStatusLastUpdate = "A";
                ContractStatusLastUpdateDesc = "No info";
                ContractStatusLastUpdateDate = DateTime.Now;
            }

            public virtual List<T> GenerateProfile<T>(int months, ref StackPanel stackPanel) where T : Profile
            {
                //for (int i = 0; i < months; i++)
                //{

                //}
                return new List<T>();
            }

            public virtual List<T> ShowProfiles<T>(int months, ref StackPanel stackPanel, List<T> Profiles) where T : Profile
            {
                return new List<T>();
            }

            //public static void ShowProfiles(List<Profile> profiles, ref StackPanel stackPanel)
            //{
            //    int i = 0;
            //    foreach (var profile in profiles)
            //        stackPanel.Children.Add(new UserControlSection($"Profile #{++i}", profile, Visibility.Visible, stackPanel));
            //}
            //public virtual List<Profile> ShowProfiles(int months,List<Profile> profiles, ref StackPanel stackPanel)
            //{
            //    //int i = 0;
            //    //foreach (var profile in profiles)
            //    //    stackPanel.Children.Add(new UserControlSection($"Profile #{++i}", profile, Visibility.Visible, stackPanel));
            //    return new List<Profile>();
            //}
        }

        // NonInstallments
        [XmlRoot(ElementName = "NonInstallmentsProfile")]
        public class NonInstallmentsProfile : Profile
        {
            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "Utilization")]
            public int Utilization { get; set; }

            [XmlAttribute(AttributeName = "TotalGuaranteedAmount")]
            public int TotalGuaranteedAmount { get; set; }

            public override List<T> GenerateProfile<T>(int months, ref StackPanel stackPanel)
            {
                var profiles = new List<T>();
                var lastMonth = DateTime.Today.AddMonths(0);

                for (int i = 0; i < months; i++)
                {
                    var profile = (T)Activator.CreateInstance(typeof(NonInstallmentsProfile));

                    profiles.Add(profile);
                    profiles[i].ReferenceYear = lastMonth.Year;
                    profiles[i].ReferenceMonth = lastMonth.Month;
                    lastMonth = lastMonth.AddMonths(-1);
                    stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
                }

                return profiles;
            }
        }

        // Installments
        [XmlRoot(ElementName = "InstallmentsProfile", Namespace = "")]
        public class InstallmentsProfile : Profile
        {
            [XmlAttribute(AttributeName = "OverduePaymentsNumber")]
            public int OverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            public override List<T> GenerateProfile<T>(int months, ref StackPanel stackPanel)
            {
                var profiles = new List<T>();
                var lastMonth = DateTime.Today.AddMonths(0);

                for (int i = 0; i < months; i++)
                {
                    var profile = (T)Activator.CreateInstance(typeof(InstallmentsProfile));

                    (profile as InstallmentsProfile).DaysPastDueDesc = "Paid as agreed";
                    (profile as InstallmentsProfile).DaysPastDue = 1;

                    profiles.Add(profile);
                    profiles[i].ReferenceYear = lastMonth.Year;
                    profiles[i].ReferenceMonth = lastMonth.Month;
                    lastMonth = lastMonth.AddMonths(-1);
                    stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
                }

                return profiles;
            }

            public override List<T> ShowProfiles<T>(int months, ref StackPanel stackPanel, List<T> Profiles)
            {
                //List<Profile> profiless = new List<Profile>();
                //foreach (var item in Profiles)
                //{
                //    var profile = item;
                //    profiless.Add(profile);
                //}
                //for (int i = 0;i < months; i++)
                //{
                //    var profile = new InstallmentsProfile();

                //    profiless.Add(profile);
                //}


                foreach (var profile in Profiles)
                    stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));

                //stackPanel.Children.Add(new UserControlSection($"Profile #{++i}", profile, Visibility.Visible, stackPanel));
                return Profiles;
            }
        }

        // CreditCards
        [XmlRoot(ElementName = "CreditCardsProfile", Namespace = "")]
        public class CreditCardsProfile : Profile
        {
            [XmlAttribute(AttributeName = "OverdueInsPaymentsNumber")]
            public int OverdueInsPaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            [XmlAttribute(AttributeName = "MinPaymentIndicator")]
            public int MinPaymentIndicator { get; set; }

            [XmlAttribute(AttributeName = "MinPaymentIndicatorDesc")]
            public string MinPaymentIndicatorDesc { get; set; }

            [XmlAttribute(AttributeName = "FlagCardUsed")]
            public int FlagCardUsed { get; set; }

            [XmlAttribute(AttributeName = "TimesCardUsed")]
            public int TimesCardUsed { get; set; }

            public override List<T> GenerateProfile<T>(int months, ref StackPanel stackPanel)
            {
                var profiles = new List<T>();
                var lastMonth = DateTime.Today.AddMonths(0);

                for (int i = 0; i < months; i++)
                {
                    var profile = (T)Activator.CreateInstance(typeof(CreditCardsProfile));

                    (profile as CreditCardsProfile).DaysPastDue = 1;
                    (profile as CreditCardsProfile).DaysPastDueDesc = "Paid as agreed";
                    (profile as CreditCardsProfile).MinPaymentIndicatorDesc = "";

                    profiles.Add(profile);
                    profiles[i].ReferenceYear = lastMonth.Year;
                    profiles[i].ReferenceMonth = lastMonth.Month;
                    lastMonth = lastMonth.AddMonths(-1);
                    stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
                }

                return profiles;
            }

            //public override List<Profile> ShowProfiles(int months, ref StackPanel stackPanel, List<Profile> Profiles)
            //{
            //    //List<Profile> profiless = new List<Profile>();
            //    //foreach (var item in Profiles)
            //    //{
            //    //    var profile = item;
            //    //    profiless.Add(profile);
            //    //}
            //    //for (int i = 0;i < months; i++)
            //    //{
            //    //    var profile = new InstallmentsProfile();

            //    //    profiless.Add(profile);
            //    //}

            //    foreach (var profile in Profiles)
            //        stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
            //    //stackPanel.Children.Add(new UserControlSection($"Profile #{++i}", profile, Visibility.Visible, stackPanel));
            //    return Profiles;
            //}

        }

        // Services
        [XmlRoot(ElementName = "ServicesProfile", Namespace = "")]
        public class ServicesProfile : Profile
        {
            [XmlAttribute(AttributeName = "BilledAmount")]
            public int BilledAmount { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsNumber")]
            public int OverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            public override List<T> GenerateProfile<T>(int months, ref StackPanel stackPanel)
            {
                var profiles = new List<T>();
                var lastMonth = DateTime.Today.AddMonths(0);

                for (int i = 0; i < months; i++)
                {
                    var profile = (T)Activator.CreateInstance(typeof(ServicesProfile));

                    (profile as ServicesProfile).DaysPastDue = 1;
                    (profile as ServicesProfile).DaysPastDueDesc = "Paid as agreed";

                    profiles.Add(profile);
                    profiles[i].ReferenceYear = lastMonth.Year;
                    profiles[i].ReferenceMonth = lastMonth.Month;
                    lastMonth = lastMonth.AddMonths(-1);
                    stackPanel.Children.Add(new UserControlSection("Profile", profile, Visibility.Visible, stackPanel));
                }

                return profiles;
            }
        }


        [XmlRoot(ElementName = "Real", Namespace = "urn:crif-creditbureau:v1")]
        public class Real
        {
            public Real()
            {
                AssetDescription = AssetLocation = RealGuaranteesDesc = "";
                AssetAppraisedValue = RealGuaranteeCode = 0;
            }

            [XmlAttribute(AttributeName = "AssetDescription")]
            public string AssetDescription { get; set; }

            [XmlAttribute(AttributeName = "AssetLocation")]
            public string AssetLocation { get; set; }

            [XmlAttribute(AttributeName = "AssetAppraisedValue")]
            public int AssetAppraisedValue { get; set; }

            [XmlAttribute(AttributeName = "RealGuaranteeCode")]
            public int RealGuaranteeCode { get; set; }

            [XmlAttribute(AttributeName = "RealGuaranteesDesc")]
            public string RealGuaranteesDesc { get; set; }
        }

        [XmlRoot(ElementName = "Guarantee", Namespace = "urn:crif-creditbureau:v1")]
        public class Guarantee
        {
            public Guarantee()
            {
                Real = new Real();
                CBSubjectCode = GuarantorName = ProviderGuaranteeNo = "";
                CounterUsed = GuaranteedAmount = 0;
                ValidityStartDate = ValidityEndDate = DateTime.Now;
                Personal = new Personal();
            }
            [XmlElement(ElementName = "Real", Namespace = "urn:crif-creditbureau:v1")]
            public Real Real { get; set; }

            [XmlAttribute(AttributeName = "CBSubjectCode")]
            public string CBSubjectCode { get; set; }

            [XmlAttribute(AttributeName = "GuarantorName")]
            public string GuarantorName { get; set; }

            [XmlAttribute(AttributeName = "ProviderGuaranteeNo")]
            public string ProviderGuaranteeNo { get; set; }

            [XmlAttribute(AttributeName = "CounterUsed")]
            public int CounterUsed { get; set; }

            [XmlAttribute(AttributeName = "GuaranteedAmount")]
            public int GuaranteedAmount { get; set; }

            [XmlAttribute(AttributeName = "ValidityStartDate")]
            public DateTime ValidityStartDate { get; set; }

            [XmlAttribute(AttributeName = "ValidityEndDate")]
            public DateTime ValidityEndDate { get; set; }

            [XmlElement(ElementName = "Personal", Namespace = "urn:crif-creditbureau:v1")]
            public Personal Personal { get; set; }
        }

        [XmlRoot(ElementName = "Installments", Namespace = "urn:crif-creditbureau:v1")]
        public class Installments : InstallmentsProfile
        {
            public Installments()
            {
                NumbersSummary = new NumbersSummary();
                AmountsSummary = new AmountsSummary();
                NotGrantedContract = new List<NotGrantedContract2>();
                GrantedContract = new List<GrantedContract2<InstallmentsProfile>>();
            }
            [XmlElement(ElementName = "NumbersSummary", Namespace = "urn:crif-creditbureau:v1")]
            public NumbersSummary NumbersSummary { get; set; }

            [XmlElement(ElementName = "AmountsSummary", Namespace = "urn:crif-creditbureau:v1")]
            public AmountsSummary AmountsSummary { get; set; }

            [XmlElement(ElementName = "NotGrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public List<NotGrantedContract2> NotGrantedContract { get; set; }

            [XmlElement(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public List<GrantedContract2<InstallmentsProfile>> GrantedContract { get; set; }
        }

        [XmlRoot(ElementName = "GrantedNonInstallment", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedNonInstallment
        {
            public GrantedNonInstallment()
            {
                TransactionType = TransactionTypeDesc = ReorganizedCreditCodeDesc = "";
                CreditLimit = ReorganizedCreditCode = OverdraftRangeNumber = 0;
                LastPaymentDate = DateTime.Now;
            }
            [XmlAttribute(AttributeName = "TransactionType")]
            public string TransactionType { get; set; }

            [XmlAttribute(AttributeName = "TransactionTypeDesc")]
            public string TransactionTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "LastPaymentDate")]
            public DateTime LastPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCode")]
            public int ReorganizedCreditCode { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCodeDesc")]
            public string ReorganizedCreditCodeDesc { get; set; }

            [XmlAttribute(AttributeName = "OverdraftRangeNumber")]
            public int OverdraftRangeNumber { get; set; }
        }

        [XmlRoot(ElementName = "Personal", Namespace = "urn:crif-creditbureau:v1")]
        public class Personal
        {
            public Personal()
            {
                CustomerType = CustomerTypeDesc = PersonalGuaranteesDesc = "";
                PersonalGuaranteeCode = 0;

            }
            [XmlAttribute(AttributeName = "CustomerType")]
            public string CustomerType { get; set; }

            [XmlAttribute(AttributeName = "CustomerTypeDesc")]
            public string CustomerTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "PersonalGuaranteeCode")]
            public int PersonalGuaranteeCode { get; set; }

            [XmlAttribute(AttributeName = "PersonalGuaranteesDesc")]
            public string PersonalGuaranteesDesc { get; set; }
        }

        [XmlRoot(ElementName = "NonInstallments")]
        public class NonInstallments : NonInstallmentsProfile
        {
            public NonInstallments()
            {
                NumbersSummary = new NumbersSummary();
                AmountsSummary = new AmountsSummary();
                GrantedContract = new GrantedContract2<NonInstallmentsProfile>();
            }
            [XmlElement(ElementName = "NumbersSummary", Namespace = "urn:crif-creditbureau:v1")]
            public NumbersSummary NumbersSummary { get; set; }

            [XmlElement(ElementName = "AmountsSummary", Namespace = "urn:crif-creditbureau:v1")]
            public AmountsSummary AmountsSummary { get; set; }

            [XmlElement(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedContract2<NonInstallmentsProfile> GrantedContract { get; set; }
        }

        [XmlRoot(ElementName = "NotGrantedCard", Namespace = "urn:crif-creditbureau:v1")]
        public class NotGrantedCard
        {
            public NotGrantedCard()
            {
                CreditLimit = 0;
                PaymentPeriodicity = "";
                PaymentPeriodicityDesc = "";
            }
            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }
        }

        [XmlRoot(ElementName = "GrantedCard", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedCard
        {
            public GrantedCard()
            {
                TransactionType = TransactionTypeDesc = PaymentPeriodicity = PaymentPeriodicityDesc = PaymentMethod = PaymentMethodDesc = DaysPastDueDesc = InstallmentType = InstallmentTypeDesc = ReorganizedCreditCodeDesc = "";
                CreditLimit = MonthlyPaymentAmount = NextPayment = LastPaymentAmount = OutstandingBalance = OverduePaymentsNumber = OverduePaymentsAmount = DaysPastDue = ChargedAmount = OverTheLimitAmount = MinPaymentPercentage = ReorganizedCreditCode = 0;
                NextPaymentDate = LastPaymentDate = OverTheLimitDate = DateTime.Now;
            }
            [XmlAttribute(AttributeName = "TransactionType")]
            public string TransactionType { get; set; }

            [XmlAttribute(AttributeName = "TransactionTypeDesc")]
            public string TransactionTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "CreditLimit")]
            public int CreditLimit { get; set; }

            [XmlAttribute(AttributeName = "MonthlyPaymentAmount")]
            public int MonthlyPaymentAmount { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethod")]
            public string PaymentMethod { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethodDesc")]
            public string PaymentMethodDesc { get; set; }

            [XmlAttribute(AttributeName = "NextPayment")]
            public int NextPayment { get; set; }

            [XmlAttribute(AttributeName = "NextPaymentDate")]
            public DateTime NextPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "LastPaymentAmount")]
            public int LastPaymentAmount { get; set; }

            [XmlAttribute(AttributeName = "LastPaymentDate")]
            public DateTime LastPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsNumber")]
            public int OverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsAmount")]
            public int OverduePaymentsAmount { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            [XmlAttribute(AttributeName = "InstallmentType")]
            public string InstallmentType { get; set; }

            [XmlAttribute(AttributeName = "InstallmentTypeDesc")]
            public string InstallmentTypeDesc { get; set; }

            [XmlAttribute(AttributeName = "ChargedAmount")]
            public int ChargedAmount { get; set; }

            [XmlAttribute(AttributeName = "OverTheLimitAmount")]
            public int OverTheLimitAmount { get; set; }

            [XmlAttribute(AttributeName = "OverTheLimitDate")]
            public DateTime OverTheLimitDate { get; set; }

            [XmlAttribute(AttributeName = "MinPaymentPercentage")]
            public int MinPaymentPercentage { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCode")]
            public int ReorganizedCreditCode { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCodeDesc")]
            public string ReorganizedCreditCodeDesc { get; set; }
        }

        [XmlRoot(ElementName = "CreditCards", Namespace = "urn:crif-creditbureau:v1")]
        public class CreditCards : CreditCardsProfile
        {
            public CreditCards()
            {
                NumbersSummary = new NumbersSummary();
                AmountsSummary = new AmountsSummary();
                NotGrantedContract = new NotGrantedContract2();
                GrantedContract = new GrantedContract2<CreditCardsProfile>();

            }
            [XmlElement(ElementName = "NumbersSummary", Namespace = "urn:crif-creditbureau:v1")]
            public NumbersSummary NumbersSummary { get; set; }

            [XmlElement(ElementName = "AmountsSummary", Namespace = "urn:crif-creditbureau:v1")]
            public AmountsSummary AmountsSummary { get; set; }

            [XmlElement(ElementName = "NotGrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public NotGrantedContract2 NotGrantedContract { get; set; }

            [XmlElement(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedContract2<CreditCardsProfile> GrantedContract { get; set; }
        }

        [XmlRoot(ElementName = "GrantedService", Namespace = "urn:crif-creditbureau:v1")]
        public class GrantedService
        {
            public GrantedService()
            {
                BilledAmount = ReorganizedCreditCode = ServicesLinesNo = DaysPastDue = OverduePaymentsAmount = OverduePaymentsNumber = OutstandingBalance = 0;
                PaymentPeriodicity = ReorganizedCreditCodeDesc = DaysPastDueDesc = PaymentPeriodicityDesc = PaymentMethod = PaymentMethodDesc = "";
                NextPaymentDate = LastPaymentDate = DateTime.Now;
            }
            [XmlAttribute(AttributeName = "BilledAmount")]
            public int BilledAmount { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicity")]
            public string PaymentPeriodicity { get; set; }

            [XmlAttribute(AttributeName = "PaymentPeriodicityDesc")]
            public string PaymentPeriodicityDesc { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethod")]
            public string PaymentMethod { get; set; }

            [XmlAttribute(AttributeName = "PaymentMethodDesc")]
            public string PaymentMethodDesc { get; set; }

            [XmlAttribute(AttributeName = "NextPaymentDate")]
            public DateTime NextPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "OutstandingBalance")]
            public int OutstandingBalance { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsNumber")]
            public int OverduePaymentsNumber { get; set; }

            [XmlAttribute(AttributeName = "OverduePaymentsAmount")]
            public int OverduePaymentsAmount { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDue")]
            public int DaysPastDue { get; set; }

            [XmlAttribute(AttributeName = "DaysPastDueDesc")]
            public string DaysPastDueDesc { get; set; }

            [XmlAttribute(AttributeName = "ServicesLinesNo")]
            public int ServicesLinesNo { get; set; }

            [XmlAttribute(AttributeName = "LastPaymentDate")]
            public DateTime LastPaymentDate { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCode")]
            public int ReorganizedCreditCode { get; set; }

            [XmlAttribute(AttributeName = "ReorganizedCreditCodeDesc")]
            public string ReorganizedCreditCodeDesc { get; set; }
        }

        [XmlRoot(ElementName = "Services", Namespace = "urn:crif-creditbureau:v1")]
        public class Services : ServicesProfile
        {
            public Services()
            {
                NumbersSummary = new NumbersSummary();
                AmountsSummary = new AmountsSummary();
                GrantedContract = new GrantedContract2<ServicesProfile>();
            }
            [XmlElement(ElementName = "NumbersSummary", Namespace = "urn:crif-creditbureau:v1")]
            public NumbersSummary NumbersSummary { get; set; }

            [XmlElement(ElementName = "AmountsSummary", Namespace = "urn:crif-creditbureau:v1")]
            public AmountsSummary AmountsSummary { get; set; }

            [XmlElement(ElementName = "GrantedContract", Namespace = "urn:crif-creditbureau:v1")]
            public GrantedContract2<ServicesProfile> GrantedContract { get; set; }
        }

        [XmlRoot(ElementName = "FootPrint", Namespace = "urn:crif-creditbureau:v1")]
        public class FootPrint
        {
            public FootPrint()
            {
                FunctionCode = FunctionCodeDesc = Channel = ProviderType = "";
                EnquiryDate = DateTime.Now;
                ProviderCode = 0;
            }
            [XmlAttribute(AttributeName = "FunctionCode")]
            public string FunctionCode { get; set; }

            [XmlAttribute(AttributeName = "FunctionCodeDesc")]
            public string FunctionCodeDesc { get; set; }

            [XmlAttribute(AttributeName = "EnquiryDate")]
            public DateTime EnquiryDate { get; set; }

            [XmlAttribute(AttributeName = "ProviderCode")]
            public int ProviderCode { get; set; }

            [XmlAttribute(AttributeName = "Channel")]
            public string Channel { get; set; }

            [XmlAttribute(AttributeName = "ProviderType")]
            public string ProviderType { get; set; }
        }

        [XmlRoot(ElementName = "FootPrints", Namespace = "urn:crif-creditbureau:v1")]
        public class FootPrints
        {
            public FootPrints()
            {
                FootPrint = new List<FootPrint>();
            }

            [XmlElement(ElementName = "FootPrint", Namespace = "urn:crif-creditbureau:v1")]
            public List<FootPrint> FootPrint { get; set; }
        }

        [XmlRoot(ElementName = "ContractsHistory", Namespace = "urn:crif-creditbureau:v1")]
        public class ContractsHistory
        {
            public ContractsHistory()
            {
                AggregatedData = new AggregatedData();
                Installments = new Installments();
                NonInstallments = new NonInstallments();
                CreditCards = new CreditCards();
                Services = new Services();
                FootPrints = new FootPrints();
            }
            [XmlElement(ElementName = "AggregatedData", Namespace = "urn:crif-creditbureau:v1")]
            public AggregatedData AggregatedData { get; set; }

            [XmlElement(ElementName = "Installments", Namespace = "urn:crif-creditbureau:v1")]
            public Installments Installments { get; set; }

            [XmlElement(ElementName = "NonInstallments", Namespace = "urn:crif-creditbureau:v1")]
            public NonInstallments NonInstallments { get; set; }

            [XmlElement(ElementName = "CreditCards", Namespace = "urn:crif-creditbureau:v1")]
            public CreditCards CreditCards { get; set; }

            [XmlElement(ElementName = "Services", Namespace = "urn:crif-creditbureau:v1")]
            public Services Services { get; set; }

            [XmlElement(ElementName = "FootPrints", Namespace = "urn:crif-creditbureau:v1")]
            public FootPrints FootPrints { get; set; }
        }

        [XmlRoot(ElementName = "CreditReport", Namespace = "urn:crif-creditbureau:v1")]
        public class CreditReport
        {
            public CreditReport()
            {
                MatchedSubject = new MatchedSubject();
                SubjectInfo = new List<SubjectInfo>();
                ContractsHistory = new ContractsHistory();
            }
            [XmlElement(ElementName = "MatchedSubject", Namespace = "urn:crif-creditbureau:v1")]
            public MatchedSubject MatchedSubject { get; set; }

            [XmlElement(ElementName = "SubjectInfo", Namespace = "urn:crif-creditbureau:v1")]
            public List<SubjectInfo> SubjectInfo { get; set; }

            [XmlElement(ElementName = "ContractsHistory", Namespace = "urn:crif-creditbureau:v1")]
            public ContractsHistory ContractsHistory { get; set; }
        }

        [XmlRoot(ElementName = "PositiveScoreFactors", Namespace = "urn:crif-creditbureau:v1")]
        public class PositiveScoreFactors
        {
            public PositiveScoreFactors()
            {
                Description = "";
            }
            [XmlAttribute(AttributeName = "Description")]
            public string Description { get; set; }
        }

        [XmlRoot(ElementName = "NegativeScoreFactors", Namespace = "urn:crif-creditbureau:v1")]
        public class NegativeScoreFactors
        {
            public NegativeScoreFactors()
            {
                Description = "";
            }

            [XmlAttribute(AttributeName = "Description")]
            public string Description { get; set; }
        }

        public XNamespace aw = "somewhere.com";

        [XmlRoot(ElementName = "CBSGlocal", Namespace = "urn:crif-creditbureau:v1")]
        public class CBSGlocal
        {
            public CBSGlocal()
            {
                PositiveScoreFactors = new List<PositiveScoreFactors>();
                NegativeScoreFactors = new List<NegativeScoreFactors>();
                ScoreRaw = 0;
                RiskLevel = "";
            }
            [XmlElement(ElementName = "PositiveScoreFactors", Namespace = "urn:crif-creditbureau:v1")]
            public List<PositiveScoreFactors> PositiveScoreFactors { get; set; }

            [XmlElement(ElementName = "NegativeScoreFactors", Namespace = "urn:crif-creditbureau:v1")]
            public List<NegativeScoreFactors> NegativeScoreFactors { get; set; }

            [XmlAttribute(AttributeName = "ScoreRaw")]
            public long ScoreRaw { get; set; }

            [XmlAttribute(AttributeName = "RiskLevel")]
            public string RiskLevel { get; set; }
        }



        [XmlRoot(ElementName = "CBScore", Namespace = "urn:crif-creditbureau:v1")]
        public class CBScore
        {
            public CBScore()
            {
                CBSGlocal = new CBSGlocal();
            }

            [XmlElement(ElementName = "CBSGlocal", Namespace = "urn:crif-creditbureau:v1")]
            public CBSGlocal CBSGlocal { get; set; }
        }

        [XmlRoot(ElementName = "CB_NAE_ProductOutput", Namespace = "")]
        public class CBNAEProductOutput
        {
            public CBNAEProductOutput()
            {
                MessageId = new MessageId();
                EnquiredData = new EnquiredData();
                ApplicationCodes = new ApplicationCodes();
                CreditReport = new CreditReport();
                CBScore = new CBScore();
                //Cb = "";
            }
            [XmlElement(ElementName = "MessageId", Namespace = "urn:crif-creditbureau:v1")]
            public MessageId MessageId { get; set; }

            [XmlElement(ElementName = "EnquiredData", Namespace = "urn:crif-creditbureau:v1")]
            public EnquiredData EnquiredData { get; set; }

            [XmlElement(ElementName = "ApplicationCodes", Namespace = "urn:crif-creditbureau:v1")]
            public ApplicationCodes ApplicationCodes { get; set; }

            [XmlElement(ElementName = "CreditReport", Namespace = "urn:crif-creditbureau:v1")]
            public CreditReport CreditReport { get; set; }

            [XmlElement(ElementName = "CBScore", Namespace = "urn:crif-creditbureau:v1")]
            public CBScore CBScore { get; set; }

            //[XmlAttribute(AttributeName = "cb")]
            //public string Cb { get; set; }
        }

        [XmlRoot(ElementName = "ProductResponse")]
        public class ProductResponse
        {
            public ProductResponse()
            {
                CBNAEProductOutput = new CBNAEProductOutput();
                ServiceId = Id = Version = ResultLanguage = ResultCode = ResultDescription = "";
            }
            [XmlElement(ElementName = "CB_NAE_ProductOutput", Namespace = "urn:crif-creditbureau:v1")]
            public CBNAEProductOutput CBNAEProductOutput { get; set; }

            [XmlAttribute(AttributeName = "ServiceId")]
            public string ServiceId { get; set; }

            [XmlAttribute(AttributeName = "Id")]
            public string Id { get; set; }

            [XmlAttribute(AttributeName = "Version")]
            public string Version { get; set; }

            [XmlAttribute(AttributeName = "ResultLanguage")]
            public string ResultLanguage { get; set; }

            [XmlAttribute(AttributeName = "ResultCode")]
            public string ResultCode { get; set; }

            [XmlAttribute(AttributeName = "ResultDescription")]
            public string ResultDescription { get; set; }
        }

        [XmlRoot(ElementName = "MGResponse")]
        public class MGResponse
        {
            public MGResponse()
            {
                MessageResponse = new MessageResponse();
                ProductResponse = new ProductResponse();
                // Xmlns = "";
            }
            [XmlElement(ElementName = "MessageResponse")]
            public MessageResponse MessageResponse { get; set; }

            [XmlElement(ElementName = "ProductResponse")]
            public ProductResponse ProductResponse { get; set; }

            //[XmlAttribute(AttributeName = "xmlns")]
            //public string Xmlns { get; set; }
        }

        [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Body
        {
            public Body()
            {
                MGResponse = new MGResponse();
                //Xsi =
                //Xsd = "";
            }

            [XmlElement(ElementName = "MGResponse", Namespace = "urn:cbs-messagegatewaysoap:2015-01-01")]
            public MGResponse MGResponse { get; set; }

            //[XmlAttribute(AttributeName = "xsi")]
            //public string Xsi { get; set; }

            //[XmlAttribute(AttributeName = "xsd")]
            //public string Xsd { get; set; }
        }

        [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Envelope
        {
            public Envelope()
            {
                Body = new Body();
                //S = "";

            }

            [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
            public Body Body { get; set; }



            //[XmlAttribute(AttributeName = "S")]
            //public string S { get; set; }
        }


    }
}
