﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Our.Umbraco.EmbeddedResource;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Our.Umbraco.CheckboxTable")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Our.Umbraco.CheckboxTable")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1e06a2ca-afb6-4b00-a064-5cd2eab4fe25")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.3.0.0")]
[assembly: AssemblyFileVersion("0.3.0.0")]

// register the embedded resoures (authenticated Umbraco users only)
[assembly: EmbeddedResourceProtected("Our.Umbraco.CheckboxTable.Resources.CheckboxTable.css", "~/App_Plugins/CheckboxTable/CheckboxTable.css")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.CheckboxTable.Resources.CheckboxTable.html", "~/App_Plugins/CheckboxTable/CheckboxTable.html")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.CheckboxTable.Resources.CheckboxTable.js", "~/App_Plugins/CheckboxTable/CheckboxTable.js")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.CheckboxTable.Resources.CheckboxTablePermissions.html", "~/App_Plugins/CheckboxTable/CheckboxTablePermissions.html")]

