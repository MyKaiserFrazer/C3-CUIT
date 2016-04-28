using C3_CUIT.Base;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3_CUIT.Extensions;

namespace C3_CUIT.Pages
{
    public class C3LoginPage : C3HtmlBase
    {

        public C3LoginPage()
        {
            SetParent("C3 - Authenticate/Launch");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        public HtmlEdit txtUserName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtC3Authenticate_Username");
            }
        }

        public HtmlEdit txtPassword
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtC3Authenticate_Password");
            }
        }

        public HtmlInputButton btnSignInButton
        {
            get
            {
                return SetProperty<HtmlInputButton>(PropertyType.Id, "btnSignIn");
            }
        }

        public C3LoginPage LogIn(string userName, string passWord)
        {
            txtUserName.EnterText("Coded UI Testing");
            txtPassword.EnterText("Natr123");
            btnSignInButton.Click();
            return new C3LoginPage();
        }
    }
}
