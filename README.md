[![Platform](https://img.shields.io/badge/Episerver-11.1.0-orange.svg?style=flat)](https://nuget.episerver.com/package/?id=EPiServer.CMS.UI.Core&v=11.1.0)

This is an EPiServer edit-mode dropdown that displays the list of font-awesome icons to the editor.

To use it, simply use the correct UIHint and a path to your xml file within an attribute.

Example:
 ```csharp
[UIHint(AwesomeUiHints.AwesomeDropdown)]
[AwesomeDropdownPath(Path = "three-icons.xml")]
public virtual string Font2 { get; set; }
```

Example of a file:
 ```xml
<?xml version="1.0" encoding="utf-8" ?>
<resources>
  <string name="fa-glass">&#xf000;</string>
  <string name="fa-music">&#xf001;</string>
  <string name="fa-search">&#xf002;</string>
</resources>
```
