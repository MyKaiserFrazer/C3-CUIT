using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_CUIT.Base
{
    /// <summary>
    /// Sets up for Page Object Model using C# Generics
    /// </summary>
    public class C3HtmlBase
    {
        public static BrowserWindow ParentPage;
        //private BrowserWindow mParentWindow { get; set; }     // *** ToDo *** Work in progress to re-identify current parent page

        public void SetParent(string title)
        {
            ParentPage.SearchProperties.Add("Name", title, PropertyExpressionOperator.Contains);
        }
        public enum PropertyType
        {
            Name,
            Id,
            ClassName,
            DisplayText,
            LinkText,
            InnerText
        }

        /// <summary>
        /// Object creator. Takes in a HtmlControl property type and identification value (like btnLogin) and creates an instance of it and 
        /// sets the SearchProperty for the property being passed in. Code reuse.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="identificationValue"></param>
        /// <returns>control</returns>
        public T SetProperty<T>(PropertyType property, string identificationValue) where T : HtmlControl
        {
            T control = (T)Activator.CreateInstance(typeof(T), new object[] { ParentPage });

            if (property == PropertyType.Name)
                control.SearchProperties[HtmlControl.PropertyNames.Name] = identificationValue;
            if (property == PropertyType.Id)
                control.SearchProperties[HtmlControl.PropertyNames.Id] = identificationValue;
            if (property == PropertyType.ClassName)
                control.SearchProperties[HtmlControl.PropertyNames.ClassName] = identificationValue;
            if (property == PropertyType.DisplayText)
                control.SearchProperties.Add("DisplayText", identificationValue);   // use the Add property to add unique property types like 'DisplayText'.
            if (property == PropertyType.LinkText)
                control.SearchProperties.Add("LinkText", identificationValue);      // use the Add property to add unique property types like 'LinkText'.
            if (property == PropertyType.InnerText)
                control.SearchProperties[HtmlControl.PropertyNames.InnerText] = identificationValue;
            return control;
        }

    /// *** ToDo *** This is work in progress to always keep track of which page is the parent page
    //    public BrowserWindow TopParentWindow()
    //    {
    //        BrowserWindow window = new BrowserWindow();
    //        window.SearchProperties[UITestControl.PropertyNames.ClassName] = BrowserWindow.CurrentBrowser.ToString();
    //        return window;
    //    }

    //    public BrowserWindow ParentWindow
    //    {
    //        get
    //        {
    //            // First time
    //            if(this.mParentWindow == null)
    //            {
    //                this.mParentWindow = TopParentWindow();
    //            }
    //            return mParentWindow;
    //        }
    //    }

    }
}
