﻿#pragma checksum "..\..\..\Views\RegistModuleWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2443930580A1D08CC4AC4408F44C85D8C177B99C"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
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


namespace Fibonacci.Views {
    
    
    /// <summary>
    /// RegistModuleWindow
    /// </summary>
    public partial class RegistModuleWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlHeaderAdd;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlHeaderRegist;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegist;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlModuleBasicInformation;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxClasses;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\RegistModuleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxMethods;
        
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
            System.Uri resourceLocater = new System.Uri("/Fibonacci;component/views/registmodulewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RegistModuleWindow.xaml"
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
            
            #line 23 "..\..\..\Views\RegistModuleWindow.xaml"
            ((Fibonacci.Views.RegistModuleWindow)(target)).Drop += new System.Windows.DragEventHandler(this.Window_Drop);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Views\RegistModuleWindow.xaml"
            ((Fibonacci.Views.RegistModuleWindow)(target)).PreviewDragOver += new System.Windows.DragEventHandler(this.Window_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Views\RegistModuleWindow.xaml"
            ((Fibonacci.Views.RegistModuleWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pnlHeaderAdd = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\RegistModuleWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pnlHeaderRegist = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.btnRegist = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Views\RegistModuleWindow.xaml"
            this.btnRegist.Click += new System.Windows.RoutedEventHandler(this.btnRegist_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pnlModuleBasicInformation = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.lstbxClasses = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.lstbxMethods = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

