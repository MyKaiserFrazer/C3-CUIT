using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_CUIT
{
    class Retired
    {
        // *** First Pass Code - 15 Lines of code ***************************************************************************************************************************************
        //var parent = BrowserWindow.Launch(new Uri("https://qa-apollo-nsp/us/c3"));

        //// Enter the username
        //HtmlEdit txtUserName = new HtmlEdit(parent);
        //txtUserName.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtC3Authenticate_Username";
        //txtUserName.Text = "";
        //Keyboard.SendKeys(txtUserName, "Coded UI Testing");

        //// Enter the password
        //HtmlEdit txtPassword = new HtmlEdit(parent);
        //txtPassword.SearchProperties[HtmlEdit.PropertyNames.Id] = "txtC3Authenticate_Password";
        //txtPassword.Text = "";
        //Keyboard.SendKeys(txtPassword, "Natr123");

        //// Click on Sign In button
        //HtmlInputButton btnSignInButton = new HtmlInputButton(parent);
        //btnSignInButton.SearchProperties[HtmlInputButton.PropertyNames.Id] = "btnSignIn";

        //Mouse.Click(btnSignInButton);

        ////Click on Nature's Sunshine logo
        //HtmlHyperlink lnkNatrLogo = new HtmlHyperlink(parent); // ** TODO ** need to re-initiate parent since we're on a different page
        //lnkNatrLogo.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "United States";

        //Mouse.Click(lnkNatrLogo);

        // *** Second Pass Code - 4 lines of code *******************************************************************************************************************************************

        // DSL - Domain Specific Language
        //C3LoginPage loginPage = new C3LoginPage();

        //loginPage.UserName.EnterText("Coded UI Testing");
        //loginPage.Password.EnterText("Natr123");
        //loginPage.SignInButton.Click();
    }
}
