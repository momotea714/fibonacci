using Fibonacci.Biz;
using Fibonacci.Core;
using Fibonacci.Core.Models;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Reactive.Bindings;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace Fibonacci.Views
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        #region Classes

        public class ModuleCollection
        {
            public bool CanAcceptChildren { get; set; }
            public ReactiveCollection<Module> Modules { get; set; }
        }

        #endregion

        #region Properties

        public ModuleCollection RegisterdModules { get; set; }
        public ModuleCollection UseModules { get; set; }

        #endregion

        #region Field

        private Point dragStartPos;
        private ListBoxItem dragItem;
        private DragAdorner dragGhost;

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }

        #endregion

        #region WindowLoad

        private async void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var controller = await this.ShowProgressAsync("Now Loading...", "登録されているモジュール一覧を読み込んでいます");
            await Task.Run(() => LoadRegisterdModules());
            ClearUseModules();
            SwitchCreateButtonEnabled();
            lstbxModules.ItemsSource = RegisterdModules.Modules;
            lstbxUseModules.ItemsSource = UseModules.Modules;
            await controller.CloseAsync();
        }

        #endregion

        #region メソッド

        private void LoadRegisterdModules()
        {
            if (RegisterdModules != null)
            {
                RegisterdModules.Modules.Clear();
            }
            else
            {
                RegisterdModules = new ModuleCollection()
                {
                    CanAcceptChildren = false,
                    Modules = new ReactiveCollection<Module>()
                };
            }
            RegisterdModules.Modules.AddRange(FibonacciUtility.SelectModules());
        }

        private void ClearUseModules()
        {
            if (UseModules != null)
            {
                UseModules.Modules.Clear();
                return;
            }
            UseModules = new ModuleCollection()
            {
                CanAcceptChildren = true,
                Modules = new ReactiveCollection<Module>()
            };

        }

        private void SwitchCreateButtonEnabled()
        {
            var isEnabled = UseModules.Modules.Count > 0;
            btnCreate.IsEnabled = isEnabled;
            btnCLear.IsEnabled = isEnabled;
        }

        private void AddUseModules(Module module)
        {
            UseModules.Modules.Add(ObjectExtension.DeepClone(module));
            SwitchCreateButtonEnabled();
        }

        private void RemoveUseModules(Module module)
        {
            UseModules.Modules.Remove(module);
            SwitchCreateButtonEnabled();
        }

        #endregion

        #region ClickEvents

        private void btnReload_Click(object sender, RoutedEventArgs e)
        {
            LoadRegisterdModules();
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            var uploadWindow = new RegistModuleWindow();
            uploadWindow.WindowState = WindowState.Maximized;
            uploadWindow.ShowDialog();
        }

        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            var appName = await this.ShowInputAsync("Set your application name", "This name is used as Assembly Name and NameSpace of new Application");
            if (string.IsNullOrEmpty(appName)) return;
            var app = new FibonacciEngine();
            app.CreateApplication(appName, UseModules.Modules);
            MessageBox.Show("完");

        }

        private void btnCLear_Click(object sender, RoutedEventArgs e)
        {
            ClearUseModules();
            SwitchCreateButtonEnabled();
        }

        private void btnAddToUseModules_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var module = ((FrameworkElement)sender).DataContext as Module;
                AddUseModules(module);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDeleteFromUseModules_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var module = ((FrameworkElement)sender).DataContext as Module;
                RemoveUseModules(module);
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region DragAndDropEvents

        private void listBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // マウスダウンされたアイテムを記憶
            dragItem = sender as ListBoxItem;
            // マウスダウン時の座標を取得
            dragStartPos = e.GetPosition(dragItem);
        }

        private void listBoxItem_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            var lbi = sender as ListBoxItem;
            if (e.LeftButton == MouseButtonState.Pressed && dragGhost == null && dragItem == lbi)
            {
                var nowPos = e.GetPosition(lbi);
                if (Math.Abs(nowPos.X - dragStartPos.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(nowPos.Y - dragStartPos.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    lstbxUseModules.AllowDrop = true;

                    var layer = AdornerLayer.GetAdornerLayer(lstbxUseModules);
                    dragGhost = new DragAdorner(lstbxUseModules, lbi, 0.5, dragStartPos);
                    layer.Add(dragGhost);
                    System.Windows.DragDrop.DoDragDrop(lbi, lbi, DragDropEffects.Move);
                    layer.Remove(dragGhost);
                    dragGhost = null;
                    dragItem = null;

                    lstbxUseModules.AllowDrop = false;
                }
            }
        }

        private void listBoxItem_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (dragGhost != null)
            {
                var p = CursorInfo.GetNowPosition(this);
                var loc = this.PointFromScreen(lstbxUseModules.PointToScreen(new Point(0, 0)));
                dragGhost.LeftOffset = p.X - loc.X;
                dragGhost.TopOffset = p.Y - loc.Y;
            }
        }

        private void listBox_Drop(object sender, DragEventArgs e)
        {
            try
            {
                var dropPos = e.GetPosition(lstbxUseModules);
                var lbi = e.Data.GetData(typeof(ListBoxItem)) as ListBoxItem;
                var module = lbi.DataContext as Module;
                var index = UseModules.Modules.IndexOf(module);
                for (int i = 0; i < UseModules.Modules.Count; i++)
                {
                    var item = lstbxUseModules.ItemContainerGenerator.ContainerFromIndex(i) as ListBoxItem;
                    var pos = lstbxUseModules.PointFromScreen(item.PointToScreen(new Point(0, item.ActualHeight / 2)));
                    if (dropPos.Y < pos.Y)
                    {
                        // i が入れ換え先のインデックス
                        UseModules.Modules.Move(index, (index < i) ? i - 1 : i);
                        return;
                    }
                }
                // 最後にもっていく
                int last = UseModules.Modules.Count - 1;
                if (index >= 0 && last >= 0 && index != last)
                {
                    UseModules.Modules.Move(index, last);
                }
                else
                {
                    AddUseModules(module);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion

    }
}
