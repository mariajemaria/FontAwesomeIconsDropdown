using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using EPiServer.Shell.ObjectEditing;

namespace AddOn.Property.FontawesomeDropdown.Awesome
{
    public class AwesomeSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(
            ExtendedMetadata metadata)
        {
            var pathAttribute = metadata.Attributes.OfType<AwesomeDropdownPathAttribute>().FirstOrDefault();

            if (pathAttribute == null || string.IsNullOrEmpty(pathAttribute.Path))
                throw new Exception($"Missing AwesomeDropdownPathAttribute and/or its Path parameter on {metadata.DisplayName}");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pathAttribute.Path);
            var xdoc = XDocument.Load(path);

            var fonts = xdoc.Document?.Descendants("string").ToList() ?? new List<XElement>();
            foreach (var font in fonts)
            {
                var nameOfFontCssClass = font.Attribute("name")?.Value;
                if (nameOfFontCssClass != null && nameOfFontCssClass.Length > 3)
                {
                    yield return new SelectItem
                    {
                        Value = nameOfFontCssClass,
                        Text = $"<i class=\"fa {nameOfFontCssClass}\"></i>&nbsp;&nbsp;{nameOfFontCssClass.Substring(3)}"
                    };
                }
            }
        }
    }
}
