using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Core.Utility
{
    public static class FileOperationUtility
    {
        /// <summary>
        ///     指定したファイルを削除します。</summary>
        /// <param name="stFilePath">
        ///     削除するファイルまでのパス。</param>
        public static void DeleteFile(string stFilePath)
        {
            var cFileInfo = new FileInfo(stFilePath);

            // ファイルが存在しているか判断する
            if (cFileInfo.Exists)
            {
                // 読み取り専用属性がある場合は、読み取り専用属性を解除する
                if ((cFileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    cFileInfo.Attributes = FileAttributes.Normal;
                }

                // ファイルを削除する
                cFileInfo.Delete();
            }
        }
    }
}
