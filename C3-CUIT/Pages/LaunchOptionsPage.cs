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
    public class LaunchOptionsPage : HtmlBase
    {
        /// <summary>
        /// Constructor: Need to set the parent page for the Launch Options controls of that page
        /// </summary>
        public LaunchOptionsPage()
        {
            SetParent("C3 - Authenticate/Launch");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Set the property for the United States hyperlink control
        /// </summary>
        public HtmlHyperlink lnkUnitedStates
        {
            get
            {
                return SetProperty<HtmlHyperlink>(PropertyType.Href, "http://qa-apollo-nsp/us/c3/");
            }
        }
        
        /// <summary>
        /// Click the United States link
        /// </summary>
        /// <param name="operatingUnit"></param>
        public void ouClickUS()
        {
            lnkUnitedStates.Click();
        }

    }
}
