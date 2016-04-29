using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C3_CUIT.Base;
using C3_CUIT.Pages;

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

        [TestMethod]
        public void TestMain()
        {

            HtmlBase.ParentPage = BrowserWindow.Launch(new Uri("https://qa-apollo-nsp/us/c3/"));

            // login to C3
            LoginPage loginPage = new LoginPage();
            LaunchOptionsPage loPageObject = loginPage.LogIn("Coded UI Testing", "Natr123");

            // click the United States link
            loPageObject.ouClickUS();
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
