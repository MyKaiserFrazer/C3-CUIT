using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C3_CUIT.Base;
using C3_CUIT.Pages;
using C3_CUIT.Extensions;
using System.Drawing;
using System.Drawing.Imaging;

namespace C3_CUIT
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class CustomCUIT
    {
        public CustomCUIT()
        {
        }

        [TestInitialize]
        public void Initialize()
        {
            BrowserWindow.CurrentBrowser = "Chrome";
            HtmlBase.ParentPage = BrowserWindow.Launch(new Uri("https://test-apollo-nsp/us/c3/"));
        }

        [TestMethod]
        public void SignUpWithOrder()
        {
            // login to C3
            LoginPage loginPage = new LoginPage();
            LaunchOptionsPage loPageObject = loginPage.LogIn("Coded UI Testing", "Natr123");

            // click the United States link
            CustomCallCenterPage cccpObject = loPageObject.ouClickUS();

            // click Sign Up With Order link
            SignUpApplicationPage signUpAppPageObject = cccpObject.ClickSignUpWithOrder();

            // Fill in Sign-Up Application Form
            OrderEntryPage orderEntryPage = signUpAppPageObject.FillInSignUpApplicationForm();
            //Playback.Wait(5000);

            // click the 'add item' button in preparation to enter items onto the cart
            orderEntryPage.OpenCart();

            // Enter items into the cart
            // OrderHistoryPage orderHistoryPage = orderEntryPage.EnterCartItems();
            orderEntryPage.EnterCartItems();
            //Playback.Wait(3000);

            // Go to Payment Information and add a Credit Card, add payment to CC
            orderEntryPage.pmtInfo();

            // Click Submit Order to complete the transaction. Return a OrderHistoryPage object 
            // in preparation to go to that page and do some validation with Assertions.
            OrderHistoryPage ordHistPage = orderEntryPage.submitCompleteOrder();

            // Do some asserts to verify order details are correct
            ordHistPage.Verify_OrderHistoryPageDetails();
        }


        [TestCleanup]
        public void cleanMethod()
        {
            System.Diagnostics.Debug.WriteLine("Test Cleanup - If I ever Get HERE");

            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" +
                    TestContext.TestName + "Fail" + HtmlExtensions.rndNum() + ".jpeg", ImageFormat.Jpeg);
            }
            else if (TestContext.CurrentTestOutcome == UnitTestOutcome.Error)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" +
                    TestContext.TestName + "Error" + HtmlExtensions.rndNum() + ".jpeg", ImageFormat.Jpeg);
            }
            else if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" +
                    TestContext.TestName + "Pass" + HtmlExtensions.rndNum() + ".jpeg", ImageFormat.Jpeg);
            }
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
