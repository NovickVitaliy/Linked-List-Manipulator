﻿#pragma checksum "..\..\..\RemoveElementWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9759A2D673FB9214B21222406FD49C8F14891ABE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Laba_15_1;
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


namespace Laba_15_1 {
    
    
    /// <summary>
    /// RemoveElementWindow
    /// </summary>
    public partial class RemoveElementWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAllElementButton;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteByIndexButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIndex;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteByValueButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbValueSingle;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteByValuesAsCSV;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\RemoveElementWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbValuesAsCSV;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Laba_15_1;component/removeelementwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RemoveElementWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DeleteAllElementButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\RemoveElementWindow.xaml"
            this.DeleteAllElementButton.Click += new System.Windows.RoutedEventHandler(this.DeleteAllElementButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeleteByIndexButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\RemoveElementWindow.xaml"
            this.DeleteByIndexButton.Click += new System.Windows.RoutedEventHandler(this.DeleteByIndexButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DeleteByValueButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\RemoveElementWindow.xaml"
            this.DeleteByValueButton.Click += new System.Windows.RoutedEventHandler(this.DeleteByValueButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbValueSingle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DeleteByValuesAsCSV = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\RemoveElementWindow.xaml"
            this.DeleteByValuesAsCSV.Click += new System.Windows.RoutedEventHandler(this.DeleteByValuesAsCSV_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tbValuesAsCSV = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

