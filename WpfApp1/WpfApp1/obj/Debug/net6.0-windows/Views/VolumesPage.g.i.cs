﻿#pragma checksum "..\..\..\..\Views\VolumesPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91631CD7665BF1061B44872B37763ED73A2CAB1B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Views;
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


namespace Library.Views {
    
    
    /// <summary>
    /// VolumesPage
    /// </summary>
    public partial class VolumesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblStudentsWithApprovedInternship;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblStudentsWithoutApprovedInternship;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgVolumes;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblAllStudents;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnNewVolume;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddReval;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteVolume;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\VolumesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturnVolume;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/views/volumespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\VolumesPage.xaml"
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
            this.LblStudentsWithApprovedInternship = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LblStudentsWithoutApprovedInternship = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.DgVolumes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.LblAllStudents = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.BtnNewVolume = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Views\VolumesPage.xaml"
            this.BtnNewVolume.Click += new System.Windows.RoutedEventHandler(this.BtnAddVolume_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAddReval = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Views\VolumesPage.xaml"
            this.BtnAddReval.Click += new System.Windows.RoutedEventHandler(this.BtnAddReval_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnDeleteVolume = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Views\VolumesPage.xaml"
            this.BtnDeleteVolume.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteVolume_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnReturnVolume = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Views\VolumesPage.xaml"
            this.BtnReturnVolume.Click += new System.Windows.RoutedEventHandler(this.BtnReturnVolume_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

