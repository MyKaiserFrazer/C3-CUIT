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
        //public HtmlEdit txtFinderAccountNumber
        //{
        //    get
        //    {
        //        return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_FinderAccountNumber");
        //    }
        //}
        private void EnterFAN(string txtFanNumber)
        {
            UITestControl txtFinderAccountNumber = new HtmlEdit(ParentPage);
            txtFinderAccountNumber.TechnologyName = "Web";
            txtFinderAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtSignUpApplication_FinderAccountNumber";
            txtFinderAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Name] = "FinderAccountNumber";
            //txtFinderAccountNumber.Text = "";
            Keyboard.SendKeys(txtFinderAccountNumber, txtFanNumber);
            //HtmlExtensions.EnterText(txtFinderAccountNumber, txtFanNumber);
        }

        /// <summary>
        /// Set the property for Sponsor Account Number edit control on Sign Up Application
        /// </summary>
        //public HtmlEdit txtSponsorAccountNumber
        //{
        //    get
        //    {
        //        return SetProperty<HtmlEdit>(PropertyType.Id, "txtSignUpApplication_SponsorAccountNumber");
        //    }
        //}
        private void EnterSAN(string txtSanNumnber)
        {
            UITestControl txtSponsorAccountNumber = new HtmlEdit(ParentPage);
            txtSponsorAccountNumber.TechnologyName = "Web";
            txtSponsorAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtSignUpApplication_SponsorAccountNumber";
            txtSponsorAccountNumber.SearchProperties[HtmlEdit.PropertyNames.Name] = "SponsorAccountNumber";
            txtSponsorAccountNumber.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Sponsor Account Number:*";
            //txtSponsorAccountNumber.Text = "";
            Keyboard.SendKeys(txtSponsorAccountNumber, txtSanNumnber);
            //HtmlExtensions.EnterText(txtSponsorAccountNumber, txtSanNumnber);
        }

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
        /// Method specific for this page
        /// </summary>
        /// <param name="operatingUnit"></param>
        public void FillInSignUpApplicationForm()
        {
            cboSignUpAppCustomerType.Click();
            cboSignUpAppAccountType.Click();
            //txtFinderAccountNumber.EnterText("76334");
            EnterFAN("76334");
            //txtSponsorAccountNumber.EnterText("78686");
            EnterSAN("78686");
            cboCommissionPlan.Click();
            cboContactNamePrefix.SelectedItem.IndexOf("2");
            txtContactFirstName.EnterText("Donald");
            txtContactMiddleName.EnterText("J.");
            txtContactLastName.EnterText("Trump");
            txtContactNameSuffix.EnterText("I");
            cboContactLanguage.SelectedItem.Equals("English");
            cboContactGender.SelectedItem.Equals("Female");
            txtContactBirthDate.EnterText("6/14/1946");
        }
    }
}
