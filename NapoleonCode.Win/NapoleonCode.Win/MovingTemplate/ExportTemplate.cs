
using System.Text;
using NapoleonCode.Common;

namespace NapoleonCode.Win.MovingTemplate
{
    public class ExportTemplate
    {

        /// <summary>
        ///  导出通用类
        /// </summary>
        /// <param name="namespaces">命名空间</param>
        /// <param name="dbName">数据库表名</param>
        /// <param name="content">内容</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:17:07
        public static string ExportModel(string namespaces, string dbName, string content)
        {
            StringBuilder top = new StringBuilder();
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("using System.Data;{0}using System.Data.SqlClient;{0}using System.Text;{0}using Napoleon.Db;{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("namespace {0}{1}", namespaces, PublicFiled.WarpSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}public class {1}{2}", PublicFiled.TabSymbol, PublicTemplate.ComposeTableName(dbName), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{1}", content, PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("}");
            return top.ToString();
        }

    }
}
