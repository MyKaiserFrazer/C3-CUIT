using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_CUIT.Pages
{
    public class PaymentInformationPage : HtmlBase
    {
            
        /// <summary>
        /// Constructor: Need to set the parent page for the Launch Options controls of that page
        /// </summary>
        public PaymentInformationPage()
        {
            SetParent("C3 - Order Entry");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Set the property for the United States hyperlink control
        /// </summary>
        public HtmlCustom btnAddPayment
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "winCheckoutPayment_AddPayment");
            }
        }

        /// <summary>
        /// Click the United States link
        /// </summary>
        /// <param name="operatingUnit"></param>
        //public PaymentInformationPage paymentInfo()
        //{
        //    HtmlExtensions.Click(btnAddPayment);
        //    //return new CustomCallCenterPage();
        //}

    }
}

