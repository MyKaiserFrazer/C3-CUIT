using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_CUIT.Extensions
{
    /// <summary>
    /// Extension methods to perform operations in Coded UI HTML controls
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// Extension method to perform a click operation
        /// </summary>
        /// <param name="control"></param>
        public static void Click(this HtmlControl control)
        {
            Mouse.Click(control);
        }

        /// <summary>
        /// Extension method to clear existing text and enter a new string into an HTML edit control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="text"></param>
        public static void EnterText(this HtmlControl control, string text)
        {
            //control.SetProperty("Text", "");    // clear the control first before entering new text
            Keyboard.SendKeys(control, text);
        }

        /// <summary>
        /// Takes a string and concatenates a 5 digit number onto the end
        /// </summary>
        /// <param name="control"></param>
        /// <param name="text"></param>
        public static void addRandomName(this HtmlControl control, string text)
        {
            control.SetProperty("Text", "");    // clear out what might already be there
            Random rnd = new Random();          // instantiate a Random() object
            int ran = rnd.Next(10000, 99999);   // get a 5 digit random number
            Keyboard.SendKeys(text + ran);      // append the number to text
        }

        public static int rndNum()
        {
            Random rnd = new Random();
            int rNum = rnd.Next(100, 999);
            return rNum;
        }
    }
}
