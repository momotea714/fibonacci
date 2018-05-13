using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Reactive.Bindings;
using Reactive.Bindings.Notifiers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Windows;

namespace Fibonacci.Views
{
    /// <summary>
    /// RegistModuleWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class RegistModuleWindow : MetroWindow
    {
        #region Classes
        public class ClassManager
        {
            public TypeInfo ClassTypeInfo { get; set; }
            public bool IsUse { get; set; }
            public ReactiveCollection<MethodManager> Methods { get; set; }

        }

        public class MethodManager
        {
            public MethodInfo Method { get; set; }
            public bool IsUse { get; set; }
        }

        #endregion

        #region Properties
        public ReactiveCollection<ClassManager> _uploadModuleClasses { get; set; }
        #endregion

        #region Fields

        private IDialogCoordinator _mahAppsDialogCoordinator = new DialogCoordinator();
        private readonly BusyNotifier _busyNotifier = new BusyNotifier();
        #endregion

        #region Constractor
        public RegistModuleWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }
        #endregion

        #region WindowLoaded
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
        }
        #endregion


        #region Methods
        private async void fuga()
        {
            //一秒間（1000ミリ秒）停止する
            Thread.Sleep(3000);
            await _mahAppsDialogCoordinator.ShowMessageAsync(this, "title", "dekitayo");

            //var a = new FibonacciEngine();
            //a.CreateApplication("aaaaa");

            //if (a.result)
            //{
            //}
        }
        #endregion

        #region DragAndDrop

        private void Window_Drop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null)
            {
                var asm = Assembly.LoadFrom(files[0]);
                var mod = asm.GetModule(asm.ManifestModule.Name);
                _uploadModuleClasses = new ReactiveCollection<ClassManager>();
                foreach (var definedType in mod.Assembly.DefinedTypes)
                {
                    if (!definedType.IsPublic) continue;

                    var classTypeInfo = definedType;
                    var methods = new ReactiveCollection<MethodManager>();
                    foreach (var method in definedType.DeclaredMethods)
                    {
                        methods.Add(new MethodManager { Method = method, IsUse = false });
                    }

                    _uploadModuleClasses.Add(new ClassManager
                    {
                        ClassTypeInfo = definedType,
                        IsUse = true,
                        Methods = methods
                    });
                }
            }
            lstbxClasses.ItemsSource = _uploadModuleClasses;
        }
        private void Window_PreviewDragOver(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true)
                && files.Length == 1
                && (files[0].EndsWith(@".dll")
                    || files[0].EndsWith(@".DLL")
                    || files[0].EndsWith(@".exe")
                    || files[0].EndsWith(@".EXE")
                    || files[0].EndsWith(@".bat")
                    || files[0].EndsWith(@".BAT")))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = true;
        }

        #endregion

        #region ClickEvents

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegist_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion


    }
}
