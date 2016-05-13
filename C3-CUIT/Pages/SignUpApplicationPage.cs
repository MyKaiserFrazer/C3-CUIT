using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;


namespace C3_CUIT.Pages
{
    public class SignUpApplicationPage : HtmlBase
    {
        public SignUpApplicationPage()
        {
            SetParent("C3 - Sign-up Application");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Set the property for Customer Type ComboBox control on Sign Up Application
        /// </summary>
        public HtmlComboBox cboSignUpAppCustomerType
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Name, "CustomerType");
            }
        }

        /// <summary>
        /// Set the property for Account Type ComboBox control on Sign Up Application
        /// </summary>
        public HtmlComboBox cboSignUpAppAccountType
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlSignUpApplication_AccountType");
            }
        }

        /// <summary>
        /// Set the property for Finder Account Number edit control on Sign Up Application
        /// </summary>
        public HtmlEdit txtFinderAccountNumber
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_FinderAccountNumber");
            }
        }
        //private void EnterFAN(string txtFanNumber)
        //{
        //    UITestControl txtFinderAccountNumber = new HtmlEdit(ParentPage);
        //    txtFinderAccountNumber.TechnologyName = "Web";
        //    txtFinderAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtSignUpApplication_FinderAccountNumber";
        //    txtFinderAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Name] = "FinderAccountNumber";
        //    //txtFinderAccountNumber.Text = "";
        //    Keyboard.SendKeys(txtFinderAccountNumber, txtFanNumber);
        //    //HtmlExtensions.EnterText(txtFinderAccountNumber, txtFanNumber);
        //}

        /// <summary>
        /// Set the property for Sponsor Account Number edit control on Sign Up Application
        /// </summary>
        public HtmlEdit txtSponsorAccountNumber
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_SponsorAccountNumber");
            }
        }
        //private void EnterSAN(string txtSanNumnber)
        //{
        //    UITestControl txtSponsorAccountNumber = new HtmlEdit(ParentPage);
        //    txtSponsorAccountNumber.TechnologyName = "Web";
        //    txtSponsorAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtSignUpApplication_SponsorAccountNumber";
        //    txtSponsorAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Name] = "SponsorAccountNumber";
        //    txtSponsorAccountNumber.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Sponsor Account Number:*";
        //    //txtSponsorAccountNumber.Text = "";
        //    Keyboard.SendKeys(txtSponsorAccountNumber, txtSanNumnber);
        //    //HtmlExtensions.EnterText(txtSponsorAccountNumber, txtSanNumnber);
        //}

        /// <summary>
        /// Set the property for Commission Plan ComboBox control on Sign Up Application
        /// </summary>
        public HtmlComboBox cboCommissionPlan
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Name, "CommissionPlan");
            }
        }

        /// <summary>
        /// Set the property for Contact Name Prefix ComboBox control on Sign Up Application for Primary Contact Name Info
        /// </summary>
        public HtmlComboBox cboContactNamePrefix
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.ClassName, "HtmlSelect");
            }
        }

        /// <summary>
        /// Set the property for First Name edit control on Primary Contact Name Info on Sign Up Application
        /// </summary>
        public HtmlEdit txtContactFirstName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_FirstName");
            }
        }

        /// <summary>
        /// Set the property for Middle Name edit control on Primary Contact Name Info on Sign Up Application
        /// </summary>
        public HtmlEdit txtContactMiddleName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_MiddleName");
            }
        }

        /// <summary>
        /// Set the property for Last Name edit control on Primary Contact Name Info on Sign Up Application
        /// </summary>
        public HtmlEdit txtContactLastName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_LastName");
            }
        }

        /// <summary>
        /// Set the property for Contact Name Suffix edit control on Primary Contact Name Info on Sign Up Application
        /// </summary>
        public HtmlEdit txtContactNameSuffix
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_NameSuffix");
            }
        }

        /// <summary>
        /// Set the property for Primary Language ComboBox control on Sign Up Application 
        /// for Personal Information of Sign Up Application
        /// </summary>
        public HtmlComboBox cboContactLanguage
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlContact_Language");
            }
        }

        /// <summary>
        /// Set the property for Contact Gender ComboBox control on Sign Up Application 
        /// for Personal Information of Sign Up Application
        /// </summary>
        public HtmlComboBox cboContactGender
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlContact_Gender");
            }
        }

        /// <summary>
        /// Set the property for Contact Birth Date edit control on Primary Contact Name Info 
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtContactBirthDate
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_BirthDate");
            }
        }

        /// <summary>
        /// Set the property for Email Address edit control on Contact Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtEmailAddress
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_EmailAddress");
            }
        }

        /// <summary>
        /// Set the property for Username edit control on Authentication
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtUsername
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_Username");
            }
        }

        /// <summary>
        /// Set the property for New Password edit control on Authentication
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtPassword
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtAuthentication_Password");
            }
        }

        /// <summary>
        /// Set the property for the Reenter New Password edit control on Authentication
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtPasswordConfirmation
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtAuthentication_PasswordConfirmation");
            }
        }

        /// <summary>
        /// Set the property for the Call-In Authentication edit control on Authentication
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtCallInAuthentication
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtContact_CallInAuthentication");
            }
        }

        /// <summary>
        /// Set the property for the Account Name edit control on Account Name Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtAccountName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_AccountName");
            }
        }

        /// <summary>
        /// Set the property for the Account Name (Legal) edit control on Account Name Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtAccountNameLegal
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_AccountNameLegal");
            }
        }

        /// <summary>
        /// Set the property for the Mailing Address Name edit control on Mailing Address Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtMailingName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtName_DefaultMailing");
            }
        }

        /// <summary>
        /// Set the property for the Address Line 1 edit control on Mailing Address Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtLine1DefaultMailing
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtLine1_DefaultMailing");
            }
        }

        /// <summary>
        /// Set the property for the City edit control on Mailing Address Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtCityDefaultMailing
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCityAsText_DefaultMailing");
            }
        }

        /// <summary>
        /// Click the Add New Phone Number link control on Contact Information
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlCustom lnkAddEditPhoneNumber
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "winAddEditPhoneNumber");
            }
        }

        /// <summary>
        /// Setup the control to enter a phone number
        /// </summary>
        public HtmlEdit txtPhoneNumber
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtPhoneNumber_Number");
            }
        }

        /// <summary>
        /// Setup the control to enter a phone number
        /// </summary>
        public HtmlComboBox cboPhoneType
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlPhoneNumber_Type");
            }
        }

        /// <summary>
        /// Setup the Allow Text Messages control
        /// </summary>
        public HtmlComboBox cboAllowTextMessages
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlPhoneNumber_AllowTextMessages");
            }
        }

        /// <summary>
        /// Setup the Is this your primary phone control (for phone).
        /// </summary>
        public HtmlComboBox cboIsPrimaryPhone
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlPhoneNumber_IsPrimary");
            }
        }

        /// <summary>
        /// Click the Submit button for phone number and related info popup box
        /// </summary>
        public HtmlCustom btnSubmitPhoneInfo
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnPhoneNumber_SubmitForm");
            }
        }

        /// <summary>
        /// Fills out the controls on the Phone Number Form
        /// </summary>
        private void addNewPhoneNumber()
        {
            HtmlExtensions.Click(lnkAddEditPhoneNumber);
            HtmlExtensions.EnterText(txtPhoneNumber, "8888888888");
            HtmlExtensions.Click(cboPhoneType);
            HtmlExtensions.Click(cboAllowTextMessages);
            HtmlExtensions.Click(cboIsPrimaryPhone);
            HtmlExtensions.Click(btnSubmitPhoneInfo);
        }

        /// <summary>
        /// Select the city in the comboBox for Mailing Address
        /// </summary>
        public HtmlComboBox cboSubdivision
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlSubdivision_DefaultMailing");
            }
        }

        /// <summary>
        /// Setup the control to enter a zip code
        /// </summary>
        public HtmlEdit txtPostalCode
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtPostalCode_DefaultMailing");
            }
        }

        /// <summary>
        /// Setup the control to verify a phone number
        /// </summary>
        public HtmlEdit txtPhoneNumDefMailing
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtPhoneNumber_DefaultMailing");
            }
        }

        /// <summary>
        /// Set the property for Email Address default mailing edit control on Mailing Address
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtEmailAddressDefaultMailing
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtEmailAddress_DefaultMailing");
            }
        }

        /// <summary>
        /// Setup the Same As Mailing comboBox control in Shipping Address
        /// </summary>
        public HtmlComboBox cboShippingSameAsMailing
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlSignUpApplication_IsShippingSameAsMailing");
            }
        }

        /// <summary>
        /// Set the property for Name in Shipping Address
        /// </summary>
        public HtmlEdit txtNameDefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtName_DefaultShipping");
            }
        }

        /// <summary>
        /// Set the address line 1 in Shipping Address
        /// </summary>
        public HtmlEdit txtAddrLine1DefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtLine1_DefaultShipping");
            }
        }

        /// <summary>
        /// Set the address line 2 in Shipping Address
        /// </summary>
        public HtmlEdit txtAddrLine2DefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtLine2_DefaultShipping");
            }
        }

        /// <summary>
        /// Set the City in Shipping Address
        /// </summary>
        public HtmlEdit txtCityDefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCityAsText_DefaultShipping");
            }
        }

        /// <summary>
        /// Select the state in the United States for Subdivision Default Shipping
        /// </summary>
        public HtmlComboBox cboSubdivisionDefaultShipping
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlSubdivision_DefaultShipping");
            }
        }

        /// <summary>
        /// Setup the control to enter a zip code
        /// </summary>
        public HtmlEdit txtPostalCodeDefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtPostalCode_DefaultShipping");
            }
        }

        /// <summary>
        /// Setup the control to verify a phone number in Shipping Address
        /// </summary>
        public HtmlEdit txtPhoneNumDefShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtPhoneNumber_DefaultShipping");
            }
        }

        /// <summary>
        /// Set the property for Email Address default shipping edit control on Shipping Address
        /// on Personal Info of Sign Up Application
        /// </summary>
        public HtmlEdit txtEmailAddressDefaultShipping
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtEmailAddress_DefaultShipping");
            }
        }

        /// <summary>
        /// Click the Submit button for Application SignUp page
        /// </summary>
        public HtmlCustom btnSubmitAccountSignUp
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnSubmitAccountSignUp");
            }
        }

        /// <summary>
        /// Method specific for this page
        /// </summary>
        /// <param name="operatingUnit"></param>
        public void FillInSignUpApplicationForm()
        {
            cboSignUpAppCustomerType.SelectedIndex = 0; // 0=Retail 1=Distributor
            HtmlExtensions.Click(cboSignUpAppCustomerType);
            HtmlExtensions.Click(cboSignUpAppAccountType);
            HtmlExtensions.EnterText(txtFinderAccountNumber, "76334");
            //EnterFAN("76334");    //bypasses the framework
            HtmlExtensions.EnterText(txtSponsorAccountNumber, "78686");
            //EnterSAN("78686");    //bypasses the framework
            HtmlExtensions.Click(cboCommissionPlan);
            HtmlExtensions.Click(cboContactNamePrefix);
            HtmlExtensions.EnterText(txtContactFirstName, "Donald");
            HtmlExtensions.EnterText(txtContactMiddleName, "J.");
            HtmlExtensions.EnterText(txtContactLastName, "Trump");
            HtmlExtensions.EnterText(txtContactNameSuffix, "I");
            HtmlExtensions.Click(cboContactLanguage);
            HtmlExtensions.Click(cboContactGender);
            HtmlExtensions.EnterText(txtContactBirthDate, "6/14/1946");
            addNewPhoneNumber();   // this is a popup modal window
            HtmlExtensions.EnterText(txtEmailAddress,"djtrump@nodomain.com");
            HtmlExtensions.addRandomName(txtUsername,"djtrump");
            HtmlExtensions.EnterText(txtPassword,"test123");
            HtmlExtensions.EnterText(txtPasswordConfirmation,"test123");
            HtmlExtensions.EnterText(txtCallInAuthentication,"IamTheSmartestPersonIKnow");
            HtmlExtensions.Click(txtAccountName);
            HtmlExtensions.Click(txtAccountNameLegal);
            HtmlExtensions.Click(txtMailingName);
            HtmlExtensions.EnterText(txtLine1DefaultMailing,"125 E Main St");
            HtmlExtensions.EnterText(txtCityDefaultMailing,"Rochester");
             cboSubdivision.SelectedIndex = 37;
            HtmlExtensions.EnterText(txtPostalCode,"146041601");
            HtmlExtensions.Click(txtPhoneNumDefMailing);
            HtmlExtensions.Click(txtEmailAddressDefaultMailing);
            HtmlExtensions.Click(cboShippingSameAsMailing);
            HtmlExtensions.Click(txtNameDefaultShipping);
            HtmlExtensions.EnterText(txtAddrLine1DefaultShipping,"125 E Main St");
            HtmlExtensions.EnterText(txtAddrLine2DefaultShipping, "");
            HtmlExtensions.EnterText(txtCityDefaultShipping,"Rochester");
            cboSubdivisionDefaultShipping.SelectedIndex = 37;
            HtmlExtensions.EnterText(txtPostalCodeDefaultShipping,"14604-1601");
            HtmlExtensions.Click(txtPhoneNumDefShipping);
            HtmlExtensions.Click(txtEmailAddressDefaultShipping);
            HtmlExtensions.Click(btnSubmitAccountSignUp);
        }
    }
}
