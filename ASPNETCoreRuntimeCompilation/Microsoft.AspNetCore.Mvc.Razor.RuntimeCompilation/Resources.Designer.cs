﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASPNETCoreRuntimeCompilation.Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation.Re" +
                            "sources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to One or more compilation references may be missing. If you&apos;re seeing this in a published application, set &apos;{0}&apos; to true in your project file to ensure files in the refs directory are published..
        /// </summary>
        internal static string Compilation_MissingReferences {
            get {
                return ResourceManager.GetString("Compilation_MissingReferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more compilation failures occurred:.
        /// </summary>
        internal static string CompilationFailed {
            get {
                return ResourceManager.GetString("CompilationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}.{1}&apos; must not be empty. At least one &apos;{2}&apos; is required to locate a view for rendering..
        /// </summary>
        internal static string FileProvidersAreRequired {
            get {
                return ResourceManager.GetString("FileProvidersAreRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generated Code.
        /// </summary>
        internal static string GeneratedCodeFileName {
            get {
                return ResourceManager.GetString("GeneratedCodeFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The debug type specified in the dependency context could be parsed. The debug type value &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string UnsupportedDebugInformationFormat {
            get {
                return ResourceManager.GetString("UnsupportedDebugInformationFormat", resourceCulture);
            }
        }
    }
}
