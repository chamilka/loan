﻿#pragma checksum "..\..\..\..\View\WpfPage\DashBoardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54879B5E4F3460BED3D84A3B9BA2A525"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace LoanManagementSystem.View.WpfPage {
    
    
    /// <summary>
    /// DashBoardPage
    /// </summary>
    public partial class DashBoardPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SettingsBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompanyBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HolidaysBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EventsBtn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AttendenceBtn;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportsBtn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmployeeBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LoanManagementSystem;component/view/wpfpage/dashboardpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
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
            this.SettingsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.CompanyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
            this.CompanyBtn.Click += new System.Windows.RoutedEventHandler(this.CompanyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HolidaysBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.EventsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.AttendenceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
            this.AttendenceBtn.Click += new System.Windows.RoutedEventHandler(this.AttendenceBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ReportsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
            this.ReportsBtn.Click += new System.Windows.RoutedEventHandler(this.ReportsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EmployeeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\View\WpfPage\DashBoardPage.xaml"
            this.EmployeeBtn.Click += new System.Windows.RoutedEventHandler(this.EmployeeBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

