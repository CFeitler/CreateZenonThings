﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateZenonThings.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class XmlResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal XmlResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CreateZenonThings.Resources.XmlResources", typeof(XmlResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;
        ///&lt;Subject ShortName=&quot;zenOn(R) exported project&quot; MainVersion=&quot;10000&quot;&gt;
        ///  &lt;Apartment ShortName=&quot;zenOn(R) assigns&quot; Version=&quot;10000&quot;&gt;
        ///    &lt;Assign ShortName=&quot;ALLOCATION_NAME&quot;&gt;
        ///      &lt;Name&gt;ALLOCATION_NAME&lt;/Name&gt;
        ///      &lt;Description /&gt;
        ///      &lt;SourceVariable&gt;SOURCE_VARIABLE&lt;/SourceVariable&gt;
        ///      &lt;TargetVariable&gt;TARGET_VARIABLE&lt;/TargetVariable&gt;
        ///      &lt;TriggerVariable&gt;TRIGGER_VARIABLE&lt;/TriggerVariable&gt;
        ///      &lt;TriggerType&gt;0&lt;/TriggerType&gt;
        ///      &lt;SystemModelGroup /&gt;
        ///    &lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XML_TEMPLATE_ALLOCATION {
            get {
                return ResourceManager.GetString("XML_TEMPLATE_ALLOCATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;Subject ShortName=&quot;zenOn(R) exported project&quot; MainVersion=&quot;8200&quot;&gt;
        ///	&lt;Apartment ShortName=&quot;zenOn(R) System Model objects&quot; Version=&quot;8200&quot;&gt;
        ///		&lt;SystemModel&gt;
        ///			&lt;Model&gt;
        ///				&lt;Name&gt;TEMPLATE_EQUIPMENT_MODEL&lt;/Name&gt;
        ///				&lt;GUID&gt;eb2dd249-67ba-468a-a7ce-1ab213b3fac6&lt;/GUID&gt;
        ///				&lt;RelevantForNetToken&gt;FALSE&lt;/RelevantForNetToken&gt;
        ///				&lt;Description&gt;&lt;/Description&gt;
        ///				&lt;Groups&gt;
        ///					&lt;Group&gt;
        ///						&lt;Name&gt;TEMPLATE_EQUIPMENT_GROUP&lt;/Name&gt;
        ///						&lt;GUID&gt;ea96863a-e3f2-41c9-b73b-f9a6b0f8af89&lt;/GUID&gt;
        ///						&lt;Description&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XML_TEMPLATE_EQUIPMENT_MODEL {
            get {
                return ResourceManager.GetString("XML_TEMPLATE_EQUIPMENT_MODEL", resourceCulture);
            }
        }
    }
}
