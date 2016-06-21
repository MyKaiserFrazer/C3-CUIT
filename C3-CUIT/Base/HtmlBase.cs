using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace C3_CUIT.Base
{
    /// <summary>
    /// Sets up for Page Object Model using C# Generics
    /// </summary>
    public class HtmlBase
    {
        public static BrowserWindow ParentPage;

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
            InnerText,
            Href,
            TagName
        }

        /// <summary>
        /// Object creator. This uses C# Generics, takes in a HtmlControl property type and identification value 
        /// (like btnLogin) and creates an instance of it and sets the SearchProperty for the property being 
        /// passed in. The constraint is 'HtmlControl'. Code reuse principle.
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
                control.SearchProperties.Add("DisplayText", identificationValue);   // use the Add property to add rare property types like 'DisplayText'.
            if (property == PropertyType.LinkText)
                control.SearchProperties.Add("LinkText", identificationValue);      // use the Add property to add 'LinkText' property.
            if (property == PropertyType.Href)
                control.SearchProperties.Add("Href", identificationValue);          // another one I added, 'Href'
            if (property == PropertyType.InnerText)
                control.SearchProperties[HtmlControl.PropertyNames.InnerText] = identificationValue;
            if (property == PropertyType.TagName)
                control.SearchProperties[HtmlControl.PropertyNames.TagName] = identificationValue;
            return control;
        }

    }
}
