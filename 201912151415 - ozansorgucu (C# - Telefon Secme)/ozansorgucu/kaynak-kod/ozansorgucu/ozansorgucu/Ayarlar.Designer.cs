﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ozansorgucu {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Ayarlar : global::System.Configuration.ApplicationSettingsBase {
        
        private static Ayarlar defaultInstance = ((Ayarlar)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Ayarlar())));
        
        public static Ayarlar Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string sunucu {
            get {
                return ((string)(this["sunucu"]));
            }
            set {
                this["sunucu"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string veritabani {
            get {
                return ((string)(this["veritabani"]));
            }
            set {
                this["veritabani"] = value;
            }
        }
    }
}
