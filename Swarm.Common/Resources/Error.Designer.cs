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
    public class Error {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Error() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Swarm.Common.Resources.Error", typeof(Error).Assembly);
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
        ///   Looks up a localized string similar to Multiple exceptions were raised..
        /// </summary>
        public static string AggregateException {
            get {
                return ResourceManager.GetString("AggregateException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AjaxTransformActionResultAttribute must decorate a method or class that inherits from StringRenderingController..
        /// </summary>
        public static string AjaxTransformAttributeDecoration {
            get {
                return ResourceManager.GetString("AjaxTransformAttributeDecoration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication attempt failed for user {0}..
        /// </summary>
        public static string AuthenticationError {
            get {
                return ResourceManager.GetString("AuthenticationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IMappingEngine instance must also implement IMappingEngineRunner in order to properly configure the mapping profiles..
        /// </summary>
        public static string AutoMapperInvalidEngine {
            get {
                return ResourceManager.GetString("AutoMapperInvalidEngine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IMappingEngineRunner.ConfigurationProvider must implement IConfiguration in order to properly configure the mapping profiles..
        /// </summary>
        public static string AutoMapperInvalidProvider {
            get {
                return ResourceManager.GetString("AutoMapperInvalidProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commits on a file system repository are unnecessary because everything is committed immediatly. Transactional operations are not implemented on file system repositories..
        /// </summary>
        public static string CommitOnFileSystemRepository {
            get {
                return ResourceManager.GetString("CommitOnFileSystemRepository", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Controllers must inherit from StringRenderingController base type in order to be able to render partials..
        /// </summary>
        public static string ControllerBaseTypeMismatch {
            get {
                return ResourceManager.GetString("ControllerBaseTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller for path &apos;{0}&apos; could not be found..
        /// </summary>
        public static string ControllerNotFound {
            get {
                return ResourceManager.GetString("ControllerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; has already been injected. .
        /// </summary>
        public static string DuplicatePropertyInjection {
            get {
                return ResourceManager.GetString("DuplicatePropertyInjection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (none).
        /// </summary>
        public static string EmptyAction {
            get {
                return ResourceManager.GetString("EmptyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (none).
        /// </summary>
        public static string EmptyController {
            get {
                return ResourceManager.GetString("EmptyController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} doesn&apos;t subclass System.Enum.
        /// </summary>
        public static string EnumRouteConstraint {
            get {
                return ResourceManager.GetString("EnumRouteConstraint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error accessing the Facebook Graph API..
        /// </summary>
        public static string FacebookApiException {
            get {
                return ResourceManager.GetString("FacebookApiException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fatal exception has occurred..
        /// </summary>
        public static string FatalException {
            get {
                return ResourceManager.GetString("FatalException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpContext.Current is not set, and required for this operation..
        /// </summary>
        public static string InvalidContext {
            get {
                return ResourceManager.GetString("InvalidContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception has occurred when attempting to send a mail message over the network..
        /// </summary>
        public static string MailSendError {
            get {
                return ResourceManager.GetString("MailSendError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please configure a membership provider for {0}..
        /// </summary>
        public static string MisconfiguredMembershipProvider {
            get {
                return ResourceManager.GetString("MisconfiguredMembershipProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please configure a role provider for {0}..
        /// </summary>
        public static string MisconfiguredRoleProvider {
            get {
                return ResourceManager.GetString("MisconfiguredRoleProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An outgoing email address could not be retrieved from either the appSettings or the smtp configuration elements..
        /// </summary>
        public static string MissingEmailCredentials {
            get {
                return ResourceManager.GetString("MissingEmailCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A model was expected but null was passed to the action method..
        /// </summary>
        public static string ModelCantBeNull {
            get {
                return ResourceManager.GetString("ModelCantBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to return InvalidModelState result when the ModelState was actually valid..
        /// </summary>
        public static string ModelStateIsValid {
            get {
                return ResourceManager.GetString("ModelStateIsValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A required attribute ModelTypeAttribute is missing from an implementation of IModelBinder: {0}. This is required to map model binders to models..
        /// </summary>
        public static string ModelTypeAttributeMissing {
            get {
                return ResourceManager.GetString("ModelTypeAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IContainerAccessor must be properly initialized before attempting to resolve dependencies..
        /// </summary>
        public static string NoContainerInitialized {
            get {
                return ResourceManager.GetString("NoContainerInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; must be injected..
        /// </summary>
        public static string PropertyNotInjected {
            get {
                return ResourceManager.GetString("PropertyNotInjected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource Type does not have a &apos;{0}&apos; property..
        /// </summary>
        public static string ResourceTypeNoProperty {
            get {
                return ResourceManager.GetString("ResourceTypeNoProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource Property &apos;{0}&apos; is not a string..
        /// </summary>
        public static string ResourceTypeNotString {
            get {
                return ResourceManager.GetString("ResourceTypeNotString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An AJAX-only action was accessed during a non-AJAX request. HTTP not found result was returned..
        /// </summary>
        public static string UnauthorizedAjaxAttempt {
            get {
                return ResourceManager.GetString("UnauthorizedAjaxAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A non-AJAX action was accessed during an AJAX request. HTTP not found result was returned..
        /// </summary>
        public static string UnauthorizedNonAjaxAttempt {
            get {
                return ResourceManager.GetString("UnauthorizedNonAjaxAttempt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception has occurred during an AJAX request..
        /// </summary>
        public static string UnhandledAjaxException {
            get {
                return ResourceManager.GetString("UnhandledAjaxException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception has occurred while rendering a child action..
        /// </summary>
        public static string UnhandledChildActionException {
            get {
                return ResourceManager.GetString("UnhandledChildActionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception has occurred..
        /// </summary>
        public static string UnhandledException {
            get {
                return ResourceManager.GetString("UnhandledException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource does not exist on the server..
        /// </summary>
        public static string WebResourceNotFound {
            get {
                return ResourceManager.GetString("WebResourceNotFound", resourceCulture);
            }
        }
    }
}
