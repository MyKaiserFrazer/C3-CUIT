using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C3_CUIT.Base;
using C3_CUIT.Pages;
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
            BrowserWindow.CurrentBrowser = "chrome";
            HtmlBase.ParentPage = BrowserWindow.Launch(new Uri("https://qa-apollo-nsp/us/c3/"));
        }

        [TestMethod]
        public void TestMain()
        {

            // login to C3
            LoginPage loginPage = new LoginPage();
            LaunchOptionsPage loPageObject = loginPage.LogIn("Coded UI Testing", "Natr123");

            // click the United States link
            CustomCallCenterPage cccpObject = loPageObject.ouClickUS();

            // click Sign Up With Order link
            SignUpApplicationPage SignUpAppPageObject = cccpObject.ClickSignUpWithOrder();

            // Fill in Sign-Up Application Form
            SignUpAppPageObject.FillInSignUpApplicationForm();

        }

        [TestCleanup]
        public void cleanMethod()
        {
            Console.WriteLine("Test Cleanup");

            if(TestContext.CurrentTestOutcome == UnitTestOutcome.Failed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" + TestContext.TestName + "Fail" + ".jpeg", ImageFormat.Jpeg);
            }
            else if(TestContext.CurrentTestOutcome == UnitTestOutcome.Error)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" + TestContext.TestName + "Error" + ".jpeg", ImageFormat.Jpeg);
            }
            else if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"C:\\Users\\JSteele.DESKTOP-6HUUN3S\\Pictures\\Screenpresso\\CUI_images\\" + TestContext.TestName + "Pass" + ".jpeg", ImageFormat.Jpeg);
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
    }
}
