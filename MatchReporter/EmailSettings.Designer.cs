﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatchReporter {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class EmailSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static EmailSettings defaultInstance = ((EmailSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new EmailSettings())));
        
        public static EmailSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("r1506.pi@gmail.com")]
        public string EmailAddress {
            get {
                return ((string)(this["EmailAddress"]));
            }
            set {
                this["EmailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("r1506.pi@gmail.com")]
        public string EmailUsername {
            get {
                return ((string)(this["EmailUsername"]));
            }
            set {
                this["EmailUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("r1506r1506")]
        public string EmailPassword {
            get {
                return ((string)(this["EmailPassword"]));
            }
            set {
                this["EmailPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.gmail.com")]
        public string SmtpServer {
            get {
                return ((string)(this["SmtpServer"]));
            }
            set {
                this["SmtpServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("587")]
        public int SmtpPort {
            get {
                return ((int)(this["SmtpPort"]));
            }
            set {
                this["SmtpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSsl {
            get {
                return ((bool)(this["EnableSsl"]));
            }
            set {
                this["EnableSsl"] = value;
            }
        }
    }
}
