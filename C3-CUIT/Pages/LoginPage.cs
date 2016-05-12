using C3_CUIT.Base;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using C3_CUIT.Extensions;

namespace C3_CUIT.Pages
{
    public class LoginPage : HtmlBase
    {
        /// <summary>
        /// Constructor: Need to set the parent page for the login controls of that page
        /// </summary>
        public LoginPage()
        {
            SetParent("C3 - Authenticate/Launch");  // title of page need only contain part of this string. See SetParent in C3HtmlBase
        }

        /// <summary>
        /// Set the property for the UserName edit control
        /// </summary>
        public HtmlEdit txtUserName
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtC3Authenticate_Username");
            }
        }

        /// <summary>
        /// Set the property for the Password edit control
        /// </summary>
        public HtmlEdit txtPassword
        {
            get
            {
                return SetProperty<HtmlEdit>(PropertyType.Id, "txtC3Authenticate_Password");
            }
        }

        /// <summary>
        /// Set the property for the Sign In button
        /// </summary>
        public HtmlInputButton btnSignInButton
        {
            get
            {
                return SetProperty<HtmlInputButton>(PropertyType.Id, "btnSignIn");
            }
        }

        /// <summary>
        /// Login() function, enters username & password then clicks the Sign In button and 
        /// returns the page object for the next or LaunchOptionsPage object.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public LaunchOptionsPage LogIn(string userName, string passWord)
        {
            HtmlExtensions.EnterText(txtUserName,userName);
            HtmlExtensions.EnterText(txtPassword,passWord);
            HtmlExtensions.Click(btnSignInButton);
            return new LaunchOptionsPage();
        }
    }
}
