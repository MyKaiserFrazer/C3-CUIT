using C3_CUIT.Base;
using C3_CUIT.Extensions;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
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
        /// Set the property for the "CLear Cart" button on the Order Entry popup for 
        /// Clears or Closes the Rapid Entry Grid Dialog.
        /// </summary>
        public HtmlCustom btnCancelCart
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnRapidEntry_StartOver");
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

        public HtmlCustom addPaymentLink
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "winCheckoutPayment_AddPayment");
            }
        }

        public HtmlCustom discountSubmit
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "winOrderEntry_SubmitDiscountOverride");
            }
        }

        /// <summary>
        /// Set the property for the "submit order" button on the Order Entry popup for 
        /// submitting orders.
        /// </summary>
        public HtmlCustom btnSubmitOrder
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnOrderEntry_SubmitOrder");
            }
        }
        /// <summary>
        /// Cancel the Entire Order by ckicking this popup dialog
        /// </summary>
        public HtmlCustom cancelOrder
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnOrderEntry_CancelOrder");
            }
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

        public HtmlCustom editPayment
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "hrefShowPaymentTab");
            }
        }

        /// <summary>
        /// Set the property for the "Add Payment" button on the PaymentInformation TAB .
        /// </summary>
        public HtmlDiv btnAddPayment /// here is the issue
        {
            get
            {
                return SetProperty<HtmlDiv>(PropertyType.Id, "winCheckoutPayment_AddPayment");
            }
        }

        /// <summary>
        /// Set the property "Payment CC Type" button on the PaymentInformation TAB 
        /// </summary>
        public HtmlCustom enterNewCredCard
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "paymentForm_AddCreditCard");
            }
        }

        /// <summary>
        /// Set the property for the "Payment Description" for the ID of the Credit Card 
        /// </summary>
        public HtmlEdit paymentDescription
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCreditCard_CustomersDescription");
            }
        }
        public HtmlEdit nameOnCard
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCreditCard_NameOnCard");
            }
        }

        public HtmlEdit creditCardNumber
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCreditCard_CreditCardNumber");
            }
        }

        public HtmlEdit cvvCode
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtCreditCard_Cvv");
            }
        }

        public HtmlComboBox expirationMonth
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlCreditCard_ExpireMonth");
            }
        }

        public HtmlCustom submitCrediCardEntry
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnUpdateCreditCard");
            }
        }

        public HtmlCustom submitPayment
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.Id, "btnSubmitPayment");
            }
        }
        public HtmlComboBox expirationYear
        {
            get
            {
                return SetProperty<HtmlComboBox>(PropertyType.Id, "ddlCheckoutPayment_CreditCardExpireYear");
            }
        }

        public HtmlButton submitOrder
        {
            get
            {
                return SetProperty<HtmlButton>(PropertyType.Id, "btnOrderEntry_SubmitOrder");
            }
        }

        public HtmlCustom paymentInformationTAB
        {
            get
            {
                return SetProperty<HtmlCustom>(PropertyType.InnerText, "Payment Information");
            }
        }


        public HtmlEdit defaultBillingName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtName_DefaultBilling");
            }
        }


        public void SubmiEditPayment()
        {
            HtmlExtensions.Click(editPayment);
        }

        /// <summary>
        /// Complete the adding of items to the cart by clicking the "add to cart" button
        /// </summary>
        public void AddItemsToCart()
        {
            HtmlExtensions.Click(btnAddToCart);
        }

        /// <summary>
        /// Click the "add item" button on the Order Entry page to bring up the cart popup
        /// </summary>
        public void OpenCart()
        {
            HtmlExtensions.Click(btnAddItem);
        }


        public void EnterCartItems()
        {
            int ItemID = 0;
            int Quantity = 0;
            int counter = 1;
            int numberOfOrders = 5;     // number of products to enter into cart

            // dummy data to enter into cart
            String[,] OrderAarry = new string[,] { {"30","2"},{"40","2"},{"70","3"},{"160","4"},
                {"190","1"},{"258","5"},{"340","2"},{"380","6"},{"1096","3"},{"410","2"},{"405","1"},
                {"204","2"},{"610","3"},{"653","4"},{"150","5"},{"1376","6"},{"774","5"},{"777","4"},
                {"1072","3"},{"175","2"},{"810","1"},{"1226","2"},{"3134","3"},{"3993","4"},{"3070","5"},
                {"2922","6"} };

            HtmlEdit orderGrid = new HtmlEdit(OrderEntryPage.ParentPage);

            while ((OrderAarry[ItemID, Quantity]).Length != 0)
            {
                Quantity = 0;
                orderGrid.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtRapidEntry_ProductId" + counter;
                Keyboard.SendKeys(orderGrid, OrderAarry[ItemID, Quantity]);
                Quantity++;
                orderGrid.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtRapidEntry_Quantity" + counter;
                Keyboard.SendKeys(orderGrid, OrderAarry[ItemID, Quantity]);
                ItemID++;

                if (numberOfOrders == ItemID)
                    break;
                counter++;
            }

            AddItemsToCart();
            Playback.Wait(4000);
        }

        public void pmtInfo()
        {

            HtmlExtensions.Click(editPayment);

            Mouse.Click(paymentInformationTAB);

            HtmlCustom addAPaymentLink = new HtmlCustom(OrderEntryPage.ParentPage.CurrentDocumentWindow);
            addAPaymentLink.SearchProperties["TagName"] = "A";
            addAPaymentLink.SearchProperties["Id"] = "winCheckoutPayment_AddPayment";
            addAPaymentLink.SearchProperties[UITestControl.PropertyNames.Name] = null;
            addAPaymentLink.FilterProperties["Class"] = "buttonStrong window";
            addAPaymentLink.FilterProperties["ControlDefinition"] = "class=\"buttonStrong window\" id=\"winCheck";
            Playback.Wait(2000);
            Mouse.Click(addAPaymentLink);

            HtmlExtensions.Click(enterNewCredCard);
            HtmlExtensions.EnterText(paymentDescription, "MyNewPayment");
            HtmlExtensions.EnterText(nameOnCard, "FAKE CARDS");
            HtmlExtensions.EnterText(creditCardNumber, "4112344112344113");
            HtmlComboBox cboxEXPMonth = new HtmlComboBox(OrderEntryPage.ParentPage);
            cboxEXPMonth.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, "ddlCreditCard_ExpireMonth");
            cboxEXPMonth.SelectedItem = "03 - March";

            HtmlComboBox cboxEXPYear = new HtmlComboBox(OrderEntryPage.ParentPage);
            cboxEXPYear.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, "ddlCheckoutPayment_CreditCardExpireYear");
            cboxEXPYear.SelectedItem = "2020";
            HtmlExtensions.EnterText(cvvCode, "123");

            HtmlExtensions.Click(submitCrediCardEntry);
            Playback.Wait(5000);

            HtmlCustom addPaymentDialog = new HtmlCustom(OrderEntryPage.ParentPage.CurrentDocumentWindow);
            addPaymentDialog.SearchProperties[HtmlCustom.PropertyNames.InnerText] = "Add Payment";
            addPaymentDialog.SearchProperties.Add(HtmlCustom.PropertyNames.Id, "btnSubmitPayment");
            HtmlExtensions.Click(submitPayment);
            Playback.Wait(8000);

            HtmlCustom overviewTAB = new HtmlCustom(OrderEntryPage.ParentPage.CurrentDocumentWindow);
            overviewTAB.SearchProperties[HtmlCustom.PropertyNames.InnerText] = "Overview";
            Mouse.Click(overviewTAB);

            Mouse.Click(paymentInformationTAB);
            Mouse.Click(paymentInformationTAB);

            //return new OrderHistoryPage();
        }

        public OrderHistoryPage submitCompleteOrder()
        {
            Playback.Wait(3000);
            HtmlExtensions.Click(btnSubmitOrder);
            Playback.Wait(10000);
            return new OrderHistoryPage();
        }
    }
}
