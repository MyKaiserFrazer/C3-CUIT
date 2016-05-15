using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
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


        /// <summary>
        /// Set the property for the "add item" button on the Order Entry page that brings up the Add Item
        /// popup to enter items into a cart.
        /// </summary>
        public HtmlInputButton btnAddItem
        {
            get
            {
                return SetProperty<HtmlInputButton>(PropertyType.Id, "winOrderEntry_AddItem");
            }
        }

        /// <summary>
        /// Set the property for the first Item ID edit control on the Add Item popup
        /// </summary>
        public HtmlEdit txtItemId1
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtRapidEntry_ProductId1");
            }
        }

        /// <summary>
        /// Set the property for the second Item ID edit control on the Add Item popup
        /// </summary>
        public HtmlEdit txtItemId2
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtRapidEntry_ProductId2");
            }
        }

        /// <summary>
        /// Set the property for the first Quantity edit control on the Add Item popup for
        /// the quantity of items in the first row.
        /// </summary>
        public HtmlEdit txtQuantity1
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtRapidEntry_Quantity1");
            }
        }

        /// <summary>
        /// Set the property for the second Quantity edit control on the Add Item popup for
        /// the quantity of items in the second row.
        /// </summary>
        public HtmlEdit txtQuantity2
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtRapidEntry_Quantity2");
            }
        }

        /// <summary>
        /// Set the property for the "add to cart" button on the Order Entry popup for 
        /// submitting items to the cart.
        /// </summary>
        public HtmlCustom btnAddToCart
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnAddToCart");
            }
        }

        /// <summary>
        /// Click the "add item" button on the Order Entry page to bring up the cart popup
        /// </summary>
        public void OpenCart()
        {
            HtmlExtensions.Click(btnAddItem);
        }

        /// <summary>
        /// Enters an item into the cart. If one item is already there, then it enters the item on the 2nd row
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="quantity"></param>
        public void EnterCartItem(string itemID, string quantity)
        {
            if(txtItemId1.ValueAttribute == "")     // if one item is already in the cart, go to the next row
            {
                HtmlExtensions.EnterText(txtItemId1, itemID);
                HtmlExtensions.EnterText(txtQuantity1, quantity);
            }
            else
            {
                HtmlExtensions.EnterText(txtItemId2, itemID);
                HtmlExtensions.EnterText(txtQuantity2, quantity);
            }
        }

        /// <summary>
        /// Search a row of the Shopping Cart Table for the product description.
        /// </summary>
        /// <param name="productDescription"></param>
        /// <returns></returns>
        private HtmlRow FindRowForProduct(string productDescription)
        {
            HtmlRow productRow = new HtmlRow(this.ShoppingCartTable);
            productRow.SearchProperties.Add(HtmlRow.PropertyNames.InnerText, productDescription, PropertyExpressionOperator.Contains);
            return productRow;
        }

        /// <summary>
        /// Private property for the Shopping Cart Table. Not sure how I'm going to use it just yet.
        /// </summary>
        private HtmlTable ShoppingCartTable
        {
            get
            {
                HtmlTable shoppingCartTable = new HtmlTable(ParentPage);
                shoppingCartTable.SearchProperties.Add(HtmlTable.PropertyNames.Id, "htbodyShoppingCart_CartItems", PropertyExpressionOperator.Contains);
                return shoppingCartTable;
            }
        }

        // tbd
        //public OrderEntryPage RemoveItemFromCart(string productDescription)
        //{
        //    var productRow = FindRowForProduct(productDescription);
        //}

        public bool IsProductInCart(string productDescription)
        {
            return FindRowForProduct(productDescription).TryFind();
        }
            
        /// <summary>
        /// Adds the items to the cart by clicking the "add to cart" button
        /// </summary>
        public void SubmitCart()
        {
            HtmlExtensions.Click(btnAddToCart);
        }

        /// <summary>
        /// Set the property for the "submit order" button on the Order Entry popup for 
        /// submitting orders.
        /// </summary>
        public HtmlButton btnSubmitOrder
        {
            get
            {
                return SetProperty<HtmlButton>(PropertyType.Id, "btnOrderEntry_SubmitOrder");
            }
        }
    }
}
