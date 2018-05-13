using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExecuteDLL
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var asm = Assembly.LoadFrom(@"C:\Users\F04629\Desktop\anything\MomosLabo\HelloWorldDLL\HelloWorldDLL\bin\Release\HelloWorldDLL.dll");
            var mod = asm.GetModule(@"HelloWorldDLL.dll");
            var type = mod.GetType("HelloWorldDLL.Program");
            if (type != null)
            {
                var obj = Activator.CreateInstance(type);
                //======================================================↓
                //CreateTypeArray
                //DefinitionTypeArray
                //GetExecuteMethod
                //MethodInvoke
                //ConvertReturnValue

                //WriteHere

                //======================================================↑

            }
        }
    }
}
