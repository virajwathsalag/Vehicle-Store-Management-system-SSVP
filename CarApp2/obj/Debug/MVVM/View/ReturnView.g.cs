﻿#pragma checksum "..\..\..\..\MVVM\View\ReturnView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54E47DECE4FB62338C96B21CE70EE6A082ED0D7E719C36985710E55586B18AF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarApp2.MVVM.View;
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


namespace CarApp2.MVVM.View {
    
    
    /// <summary>
    /// ReturnView
    /// </summary>
    public partial class ReturnView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEdetails;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtmail;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCarID;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtType;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOriPrice;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\MVVM\View\ReturnView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnOK;
        
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
            System.Uri resourceLocater = new System.Uri("/CarApp2;component/mvvm/view/returnview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\ReturnView.xaml"
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
            this.comboBoxSearch = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\..\..\MVVM\View\ReturnView.xaml"
            this.comboBoxSearch.DropDownOpened += new System.EventHandler(this.comboBoxSearch_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\..\MVVM\View\ReturnView.xaml"
            this.comboBoxSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.comboBoxSearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridEdetails = ((System.Windows.Controls.DataGrid)(target));
            
            #line 75 "..\..\..\..\MVVM\View\ReturnView.xaml"
            this.DataGridEdetails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridEdetails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\MVVM\View\ReturnView.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCarID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtOriPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnReturnOK = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\MVVM\View\ReturnView.xaml"
            this.btnReturnOK.Click += new System.Windows.RoutedEventHandler(this.btnReturnOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

