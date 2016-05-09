using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace C3_CUIT.Pages
{
    public class CustomCallCenterPage : HtmlBase
    {
        /// <summary>
        /// Constructor: Need to set the parent page for the Launch Options controls of that page
        /// </summary>
        public CustomCallCenterPage()
        {
            SetParent("C3 - Custom Call Center");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Set the property for 
        /// </summary>
        public HtmlHyperlink lnkSignUpWithOrder
        {
            get
            {
                return SetProperty<HtmlHyperlink>(PropertyType.Href, "https://qa-apollo-nsp/us/c3/ApplicationSignUp?type=order");
            }
        }

        /// <summary>
        /// Method specific for this page
        /// </summary>
        /// <param name="operatingUnit"></param>
        public SignUpApplicationPage ClickSignUpWithOrder()
        {
            lnkSignUpWithOrder.Click();
            return new SignUpApplicationPage();
        }

    }
}
