﻿#pragma checksum "..\..\CustomerPaymentDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FAF1844AED7B577C0C81805E23F2F26AF58AC5D1006855E00B03659694685830"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarApp2;
using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace CarApp2 {
    
    
    /// <summary>
    /// CustomerPaymentDetails
    /// </summary>
    public partial class CustomerPaymentDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.Sharp.IconImage imgBack;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFname;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNIC;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cobCuntry;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cobNO;
        
        #line default
        #line hidden
        
        
        #line 529 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTele;
        
        #line default
        #line hidden
        
        
        #line 550 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 568 "..\..\CustomerPaymentDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarApp2;component/customerpaymentdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CustomerPaymentDetails.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgBack = ((FontAwesome.Sharp.IconImage)(target));
            
            #line 27 "..\..\CustomerPaymentDetails.xaml"
            this.imgBack.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgBack_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNIC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cobCuntry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cobNO = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.txtTele = ((System.Windows.Controls.TextBox)(target));
            
            #line 541 "..\..\CustomerPaymentDetails.xaml"
            this.txtTele.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtTele_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 575 "..\..\CustomerPaymentDetails.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

