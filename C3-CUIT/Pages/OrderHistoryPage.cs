using C3_CUIT.Base;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace C3_CUIT.Pages
{
    public class OrderHistoryPage : HtmlBase
    {


        /// <summary>
        /// Constructor: Need to set the parent page for the Order Entry controls of that page
        /// </summary>
        public OrderHistoryPage()
        {
            SetParent("C3 - Order History Details");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Used to setup for Assertions on the OrderHistoryPage
        /// </summary>
        /// <param name="propertyvalue"></param>
        /// <returns>
        /// The string representing the value of the corresponding text label^
        /// </returns>
        public string getText(string propertyValue)
        {
            HtmlDiv orderDate = new HtmlDiv(ParentPage);
            orderDate.SearchProperties[HtmlDiv.PropertyNames.Id] = propertyValue;
            return orderDate.GetProperty(HtmlDiv.PropertyNames.InnerText).ToString();
        }

        /// <summary>
        /// Verifies that the order just submitted has correct history details for that order.
        /// </summary>
        public void Verify_OrderHistoryPageDetails()
        {

            // Check that Order Date is equal to todays date
            Assert.AreEqual(DateTime.Now.ToString("M/d/yyyy"), getText("hdivOrderHistory_OrderDate"));

            // Assuming for now that Commission Date is equal to yesterday's date.
            Assert.AreEqual(DateTime.Today.AddDays(-1).ToString("M/d/yyyy"), getText("hdivOrderHistory_CommissionDate"), true,
                "Commission Date is other than yesterdays date");

            // Check that Order Type is equal to 'Activation'.
            Assert.AreEqual("Standard", getText("hdivOrderHistory_OrderType"), true, "Order Type was not equal to Standard");

            // Check that Channel Type is equal to 'Phone'.
            Assert.AreEqual("Phone", getText("hdivOrderHistory_ChannelType"), true, "Channel Type was not equal to Phone");

            // Check that Order Status is equal to 'Booked'.
            Assert.AreEqual("Booked", getText("hdivOrderHistory_Status"), true, "Order Status was not equal to Booked");
        }
    }
}
