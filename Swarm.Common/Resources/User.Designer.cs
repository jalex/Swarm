﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Swarm.Common.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class User {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal User() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Swarm.Common.Resources.User", typeof(User).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database access error..
        /// </summary>
        public static string DatabaseError {
            get {
                return ResourceManager.GetString("DatabaseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops! Something went wrong!.
        /// </summary>
        public static string FatalException {
            get {
                return ResourceManager.GetString("FatalException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;Exceptions&quot;:[&quot;Oops! Something went wrong!&quot;]}.
        /// </summary>
        public static string FatalExceptionJson {
            get {
                return ResourceManager.GetString("FatalExceptionJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested job doesn&apos;t seem to exist in the server..
        /// </summary>
        public static string InvalidJobKey {
            get {
                return ResourceManager.GetString("InvalidJobKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested Scenario doesn´t exist in the server..
        /// </summary>
        public static string InvalidScenarioID {
            get {
                return ResourceManager.GetString("InvalidScenarioID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dd&apos;, &apos;MMMM, yyyy.
        /// </summary>
        public static string LongDateFormat {
            get {
                return ResourceManager.GetString("LongDateFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dd&apos;,  &apos;MMMM, yyyy hh:mm:ss tt.
        /// </summary>
        public static string LongDateTimeFormat {
            get {
                return ResourceManager.GetString("LongDateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh.
        /// </summary>
        public static string Refresh {
            get {
                return ResourceManager.GetString("Refresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong. Try again later..
        /// </summary>
        public static string UnhandledAjaxException {
            get {
                return ResourceManager.GetString("UnhandledAjaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong. Try again later..
        /// </summary>
        public static string UnhandledException {
            get {
                return ResourceManager.GetString("UnhandledException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;Exceptions&quot;:[&quot;Something went wrong! Try again later.&quot;]}.
        /// </summary>
        public static string UnhandledExceptionJson {
            get {
                return ResourceManager.GetString("UnhandledExceptionJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource does not exist in the web server..
        /// </summary>
        public static string WebResourceNotFound {
            get {
                return ResourceManager.GetString("WebResourceNotFound", resourceCulture);
            }
        }
    }
}
