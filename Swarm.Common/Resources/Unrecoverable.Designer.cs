﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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
    public class Unrecoverable {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Unrecoverable() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Swarm.Common.Resources.Unrecoverable", typeof(Unrecoverable).Assembly);
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
        ///   Looks up a localized string similar to &lt;section class=&apos;inner&apos;&gt;{0}&lt;/section&gt;.
        /// </summary>
        public static string InnerException {
            get {
                return ResourceManager.GetString("InnerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.Exception.
        /// </summary>
        public static string ModelException {
            get {
                return ResourceManager.GetString("ModelException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.InnerException.
        /// </summary>
        public static string ModelInnerException {
            get {
                return ResourceManager.GetString("ModelInnerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.Message.
        /// </summary>
        public static string ModelMessage {
            get {
                return ResourceManager.GetString("ModelMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.Refresh.
        /// </summary>
        public static string ModelRefresh {
            get {
                return ResourceManager.GetString("ModelRefresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.Sql.
        /// </summary>
        public static string ModelSql {
            get {
                return ResourceManager.GetString("ModelSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.StackTrace.
        /// </summary>
        public static string ModelStackTrace {
            get {
                return ResourceManager.GetString("ModelStackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @Model.Title.
        /// </summary>
        public static string ModelTitle {
            get {
                return ResourceManager.GetString("ModelTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;section class=&apos;sql&apos;&gt;&lt;pre&gt;{0}&lt;/pre&gt;&lt;/section&gt;.
        /// </summary>
        public static string Sql {
            get {
                return ResourceManager.GetString("Sql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;section class=&apos;stacktrace&apos;&gt;{0}&lt;/section&gt;.
        /// </summary>
        public static string StackTrace {
            get {
                return ResourceManager.GetString("StackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;{0}&lt;/p&gt;.
        /// </summary>
        public static string StackTraceLine {
            get {
                return ResourceManager.GetString("StackTraceLine", resourceCulture);
            }
        }
    }
}
