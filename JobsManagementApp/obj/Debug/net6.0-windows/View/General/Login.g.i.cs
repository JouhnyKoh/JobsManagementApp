﻿#pragma checksum "..\..\..\..\..\View\General\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B9AE21DD20EF0AF4BC1B398BD3382FBF874F440"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JobsManagementApp.View.General;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace JobsManagementApp.View.General {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 86 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_email;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_del_email;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon icon_del_email;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passb_password;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txb_password;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_password;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon icon_eye;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_del_pass;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon icon_del_pass;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\..\..\View\General\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/JobsManagementApp;component/view/general/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\General\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 59 "..\..\..\..\..\View\General\Login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 67 "..\..\..\..\..\View\General\Login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txb_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_del_email = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\..\..\View\General\Login.xaml"
            this.btn_del_email.Click += new System.Windows.RoutedEventHandler(this.del_email_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.icon_del_email = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 6:
            this.passb_password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.txb_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btn_password = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\..\View\General\Login.xaml"
            this.btn_password.Click += new System.Windows.RoutedEventHandler(this.btn_password_click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.icon_eye = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 10:
            this.btn_del_pass = ((System.Windows.Controls.Button)(target));
            
            #line 174 "..\..\..\..\..\View\General\Login.xaml"
            this.btn_del_pass.Click += new System.Windows.RoutedEventHandler(this.del_pass_click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.icon_del_pass = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 12:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

