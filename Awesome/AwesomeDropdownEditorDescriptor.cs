using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace MarijasPlayground.Awesome
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = CustomUiHints.AwesomeDropdown)]
    public class AwesomeDropdownEditorDescriptor : EditorDescriptor
    {
        public AwesomeDropdownEditorDescriptor()
        {
            SelectionFactoryType = typeof(AwesomeSelectionFactory);
            ClientEditingClass = "alloy/editors/AwesomeSelectionEditor";
            EditorConfiguration.Add("style", "width: 72px");
        }
    }
}