using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using EPiServer.Shell.ObjectEditing;

namespace MarijasPlayground.Awesome
{
    public class AwesomeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(
            ExtendedMetadata metadata)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Awesome\FontAwesomeIcons.xml");
            XDocument xdoc = XDocument.Load(path);

            foreach (var node in xdoc.Document.Descendants("string"))
            {
                var nameOfFontCssClass = node.Attribute("name").Value;
                yield return new SelectItem
                {
                    Value = nameOfFontCssClass,
                    Text = string.Format("<i class=\"fa {0}\"></i>&nbsp;&nbsp;{1}", nameOfFontCssClass, nameOfFontCssClass.Substring(3))
                };
            }
        }
    }
}