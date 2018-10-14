using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AddOn.Property.FontawesomeDropdown.Awesome
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = AwesomeUiHints.AwesomeDropdown)]
    public class AwesomeDropdownEditorDescriptor : EditorDescriptor
    {
        public AwesomeDropdownEditorDescriptor()
        {
            ClientEditingClass = "addon-property-fontawesomedropdown/AwesomeSelectionEditor";
            EditorConfiguration.Add("style", "width: 72px");
            SelectionFactoryType = typeof(AwesomeSelectionFactory);
        }
    }
}