﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HanumanInstitute.Downloads.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HanumanInstitute.Downloads.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to DownloadTask.DownloadAsync can only be called once..
        /// </summary>
        internal static string DownloadTaskCallOnce {
            get {
                return ResourceManager.GetString("DownloadTaskCallOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uri does not contain a valid YouTube video ID: {0}.
        /// </summary>
        internal static string InvalidYouTubeId {
            get {
                return ResourceManager.GetString("InvalidYouTubeId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request contains no stream to download..
        /// </summary>
        internal static string RequestHasNoStream {
            get {
                return ResourceManager.GetString("RequestHasNoStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canceled.
        /// </summary>
        internal static string StatusCanceled {
            get {
                return ResourceManager.GetString("StatusCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done.
        /// </summary>
        internal static string StatusDone {
            get {
                return ResourceManager.GetString("StatusDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed.
        /// </summary>
        internal static string StatusFailed {
            get {
                return ResourceManager.GetString("StatusFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finalizing....
        /// </summary>
        internal static string StatusFinalizing {
            get {
                return ResourceManager.GetString("StatusFinalizing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing....
        /// </summary>
        internal static string StatusInitializing {
            get {
                return ResourceManager.GetString("StatusInitializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting....
        /// </summary>
        internal static string StatusWaiting {
            get {
                return ResourceManager.GetString("StatusWaiting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only call UpdateProgress when DownloadStatus is Downloading..
        /// </summary>
        internal static string UpdateProgressInvalidStatus {
            get {
                return ResourceManager.GetString("UpdateProgressInvalidStatus", resourceCulture);
            }
        }
    }
}