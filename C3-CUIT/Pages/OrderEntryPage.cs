using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace C3_CUIT.Pages
{
    public class OrderEntryPage : HtmlBase
    {
        /// <summary>
        /// Constructor: Need to set the parent page for the Order Entry controls of that page
        /// </summary>
        public OrderEntryPage()
        {
            SetParent("C3 - Order Entry");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }


    }
}
