using System;
using System.IO;
using System.Text;

namespace NapoleonCode.Common
{
    public class FileFunc
    {

        /// <summary>
        ///  操作文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="content">内容</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:05:14
        public static bool OperateFile(string filePath, string content)
        {
            try
            {
                ExistFile(filePath);
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.Default))
                {
                    writer.Write(content);
                    writer.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        ///  判断文件是否存在
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:08:07
        private static void ExistFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (FileStream stream = File.Create(filePath))
                {
                    stream.Close();
                }
            }
        }


    }
}
