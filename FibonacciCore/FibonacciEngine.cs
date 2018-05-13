using Fibonacci.Core.Models;
using Fibonacci.Core.Utility;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Fibonacci.Core
{
    public class FibonacciEngine
    {
        #region Property
        public bool result { get; set; }
        
        #endregion

        #region Field
        private string _originalPath = ConfigurationManager.AppSettings["OriginalFolderPath"];
        private const string _originalAppName = "ExecuteDLL";
        private const string _mainWindowFileName = "MainWindow.xaml.cs";
        #endregion

        #region PublicMethod
        public void CreateApplication(string appName,IEnumerable<Module> modules)
        {
            if (string.IsNullOrEmpty(appName))
            {
                result = false;
                return;
            }

            var createAppPath = Path.Combine(Directory.GetParent(_originalPath).FullName, appName);

            //OriginalSourceのコピー
            CopyOriginal(appName, createAppPath);

            //ソースコード作成
            var mainWindowDirectoryPath = Path.Combine(createAppPath, appName);
            var projectFilePath = Path.Combine(mainWindowDirectoryPath, appName + @".csproj");
            var fullPath = Path.Combine(mainWindowDirectoryPath, _mainWindowFileName);
            var oldTextList = new List<string>
            {
                 @"//CreateTypeArray"
                ,@"//DefinitionTypeArray"
                ,@"//GetExecuteMethod"
                ,@"//MethodInvoke"
                ,@"//ConvertReturnValue"
            };

            var newTextList = new List<string>
            {
                 @"var types = new Type[2];"
                ,@"types[0] = typeof(string);" + Environment.NewLine + @"types[1] = typeof(int);"
                ,@"var mainMethod = type.GetMethod(""Main"", types);"
                ,@"var ret = mainMethod.Invoke(obj, new object[2] { ""aa"",100 });"
                ,@"MessageBox.Show(Convert.ToString(ret));"
            };

            //置換
            ReplaceClassFile(fullPath, oldTextList, newTextList);

            //ビルド
            BuildUtility.BuildProject(projectFilePath);
            result = true;

            return;
        }

        #endregion

        #region PrivateMethod

        private void CopyOriginal(string appName, string createAppPath)
        {
            //オリジナルにbinとobjフォルダがあるとなぜかビルドがうまくいかないので削除しておく
            var originalBinPath = Path.Combine(Path.Combine(_originalPath, _originalAppName), "bin");
            if (Directory.Exists(originalBinPath))
            {
                Directory.Delete(originalBinPath, true);
            }

            var originalobjPath = Path.Combine(Path.Combine(_originalPath, _originalAppName), "obj");
            if (Directory.Exists(originalobjPath))
            {
                Directory.Delete(originalobjPath, true);
            }

            //オリジナルをフォルダごとコピー
            FileSystem.CopyDirectory(_originalPath, createAppPath, UIOption.AllDialogs, UICancelOption.DoNothing);

            //コピー先フォルダ内のフォルダ名・ファイル名・ファイル内文字列全置換
            var directory = new DirectoryInfo(createAppPath);

            //suoファイルの削除
            foreach (var file in directory.EnumerateFiles("*", System.IO.SearchOption.AllDirectories).Where(f => f.Name.EndsWith(@".suo")))
            {
                FileOperationUtility.DeleteFile(file.FullName);
            }

            //フォルダ名置換
            foreach (var file in directory.EnumerateDirectories("*", System.IO.SearchOption.AllDirectories).Where(f => f.Name.StartsWith(_originalAppName)))
            {
                file.MoveTo(file.FullName.Replace(_originalAppName, appName));
            }
            //ファイル名置換
            foreach (var file in directory.EnumerateFiles("*", System.IO.SearchOption.AllDirectories).Where(f => f.Name.StartsWith(_originalAppName)))
            {
                file.MoveTo(file.FullName.Replace(_originalAppName, appName));
            }
            //ファイル内文字列置換
            foreach (var file in directory.EnumerateFiles("*", System.IO.SearchOption.AllDirectories))
            {
                ReplaceClassFile(file.FullName, new List<string> { _originalAppName }, new List<string> { appName });
            }
        }


        private static void ReplaceClassFile(string fullPath, List<string> oldTextList, List<string> newTextList)
        {
            //ファイルの内容を読み込む
            var sr = new StreamReader(fullPath, Encoding.GetEncoding("utf-8"));

            //内容をすべて読み込む
            string s = sr.ReadToEnd();

            //閉じる
            sr.Close();

            // 文字列置換
            foreach (var oldText in oldTextList)
            {
                s = s.Replace(oldText, newTextList[oldTextList.IndexOf(oldText)]);
            }

            //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fullPath,
                false,
                System.Text.Encoding.GetEncoding("utf-8"));
            //内容を書き込む
            sw.Write(s);
            //閉じる
            sw.Close();
        }
        #endregion
    }
}
