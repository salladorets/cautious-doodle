﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doodle {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class DoodleSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static DoodleSettings defaultInstance = ((DoodleSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DoodleSettings())));
        
        public static DoodleSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(local)")]
        public string DBServerString {
            get {
                return ((string)(this["DBServerString"]));
            }
            set {
                this["DBServerString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sa")]
        public string DBUserString {
            get {
                return ((string)(this["DBUserString"]));
            }
            set {
                this["DBUserString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DBPasswordString {
            get {
                return ((string)(this["DBPasswordString"]));
            }
            set {
                this["DBPasswordString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BackupDirString {
            get {
                return ((string)(this["BackupDirString"]));
            }
            set {
                this["BackupDirString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DBPrefixString {
            get {
                return ((string)(this["DBPrefixString"]));
            }
            set {
                this["DBPrefixString"] = value;
            }
        }
    }
}