﻿#pragma checksum "..\..\..\..\Windows\NewRentalWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5083EE7939E40B35BEDCC06C85943A393E471DD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Windows;
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


namespace Library.Windows {
    
    
    /// <summary>
    /// NewRentalWindow
    /// </summary>
    public partial class NewRentalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Windows\NewRentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbRentals;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\NewRentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox readerId;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Windows\NewRentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Windows\NewRentalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library;component/windows/newrentalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\NewRentalWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Windows\NewRentalWindow.xaml"
            ((Library.Windows.NewRentalWindow)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CbRentals = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\Windows\NewRentalWindow.xaml"
            this.CbRentals.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbRentals_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.readerId = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\Windows\NewRentalWindow.xaml"
            this.readerId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtReaderId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Windows\NewRentalWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\Windows\NewRentalWindow.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

