﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3E973BC3649AAEC9D4662CAD4D862F625515318"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnl1;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpload;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReload;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnl2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCLear;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxModules;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxMethods;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxUseModules;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstbxArgumentSettings;
        
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
            System.Uri resourceLocater = new System.Uri("/Fibonacci;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 21 "..\..\..\Views\MainWindow.xaml"
            ((Fibonacci.Views.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pnl1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.btnUpload = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\MainWindow.xaml"
            this.btnUpload.Click += new System.Windows.RoutedEventHandler(this.btnUpload_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReload = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\MainWindow.xaml"
            this.btnReload.Click += new System.Windows.RoutedEventHandler(this.btnReload_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.pnl2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.btnCLear = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Views\MainWindow.xaml"
            this.btnCLear.Click += new System.Windows.RoutedEventHandler(this.btnCLear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\MainWindow.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstbxModules = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.lstbxMethods = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.lstbxUseModules = ((System.Windows.Controls.ListBox)(target));
            
            #line 134 "..\..\..\Views\MainWindow.xaml"
            this.lstbxUseModules.Drop += new System.Windows.DragEventHandler(this.listBox_Drop);
            
            #line default
            #line hidden
            return;
            case 15:
            this.lstbxArgumentSettings = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 92 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.listBoxItem_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseMoveEvent;
            
            #line 93 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.listBoxItem_PreviewMouseMove);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.QueryContinueDragEvent;
            
            #line 94 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.QueryContinueDragEventHandler(this.listBoxItem_QueryContinueDrag);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 11:
            
            #line 111 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAddToUseModules_Click);
            
            #line default
            #line hidden
            break;
            case 13:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 146 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.listBoxItem_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseMoveEvent;
            
            #line 147 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.listBoxItem_PreviewMouseMove);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.QueryContinueDragEvent;
            
            #line 148 "..\..\..\Views\MainWindow.xaml"
            eventSetter.Handler = new System.Windows.QueryContinueDragEventHandler(this.listBoxItem_QueryContinueDrag);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 14:
            
            #line 165 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDeleteFromUseModules_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

