
using System.Data;
using System.Text;
using NapoleonCode.Common;

namespace NapoleonCode.Win.MovingTemplate
{
    public class AutoDapperTemplate
    {

        /// <summary>
        ///  DAL
        /// </summary>
        /// <param name="namespaces">命名空间</param>
        /// <param name="dbName">数据库表名</param>
        /// <param name="dt">数据库表查询结果</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:17:07
        public static string CompleteDao(string namespaces, string dbName, DataTable dt)
        {
            StringBuilder top = new StringBuilder();
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("using System.Data;{0}using System.Data.SqlClient;{0}using System.Text;{0}using Napoleon.Db;{0}using {1};{0}", PublicFiled.WarpSymbol, namespaces + ".IDAL");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("namespace {0}{1}", namespaces + ".DAL", PublicFiled.WarpSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}public class {1}Dao : I{1}Dao{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{1}", ContentDao(dt, dbName), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("}");
            return top.ToString();
        }

        /// <summary>
        ///  DAL内容
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:27:02
        private static string ContentDao(DataTable dt, string dbName)
        {
            StringBuilder content = new StringBuilder();
            if (dt.Rows.Count > 0)
            {
                string tableName = dt.Rows[0]["TableName"].ToString();

                #region 查询

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("查询数据", 2)); //注释
                content.AppendFormat("{0}{0}public DataTable Get{1}Table (string id){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}DataTable dt=new DataTable();{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}StringBuilder sb = new StringBuilder();{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}sb.AppendFormat(\"select {1} from {2}\");{3}", PublicFiled.TabSymbol, PublicTemplate.GetFiled1(dt), tableName, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}dt=DbHelper.GetDataTable(sb.ToString());{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}if (!string.IsNullOrWhiteSpace(id)){1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}{0}sb.AppendFormat(\" where Id=@id\");{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}{0}SqlParameter[] parameters = {1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}{0}{0}new SqlParameter(\"@id\",id){1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t\t\t};");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}{0}dt=DbHelper.GetDataTable(sb.ToString(),parameters);{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return dt;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 新增

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("新增数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Insert{1} ({1} model){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}StringBuilder sql = new StringBuilder();{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}sql.AppendFormat(\"insert into {1}({2}) values({3})\");{4}", PublicFiled.TabSymbol, tableName, PublicTemplate.GetFiled1(dt), PublicTemplate.GetFiled2(dt), PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}int i = DbHelper.ExecuteSql(sql.ToString(), model);{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return i;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 更新

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("更新数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Update{1} ({1} model){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}StringBuilder sql = new StringBuilder();{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}sql.AppendFormat(\"update {1} set {2} where Id=@Id\");{3}", PublicFiled.TabSymbol, tableName, PublicTemplate.GetFiled3(dt), PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}int i = DbHelper.ExecuteSql(sql.ToString(), model);{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return i;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 删除

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("删除数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Delete{1} (string id){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}string[] ids=id.Split(',');{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}StringBuilder sql = new StringBuilder();{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}sql.AppendFormat(\"delete {1} where Id in @Id\");{2}", PublicFiled.TabSymbol, tableName, PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}int i = DbHelper.ExecuteSql(sql.ToString(), new ", PublicFiled.TabSymbol);
                content.Append("{");
                content.AppendFormat("@Id=ids");
                content.Append("});");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return i;{1}", PublicFiled.TabSymbol, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

            }
            return content.ToString();
        }

        /// <summary>
        ///  IDAL
        /// </summary>
        /// <param name="namespaces">命名空间</param>
        /// <param name="dbName">数据库表名</param>
        /// <param name="dt">数据库表查询结果</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:17:07
        public static string CompleteIDao(string namespaces, string dbName, DataTable dt)
        {
            StringBuilder top = new StringBuilder();
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("using System.Data;{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("namespace {0}{1}", namespaces + ".IDAL", PublicFiled.WarpSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}public interface I{1}Dao ", PublicFiled.TabSymbol, dbName);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{1}", ContentIDao(dt, dbName), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("}");
            return top.ToString();
        }

        /// <summary>
        ///  IDAL内容
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:27:02
        private static string ContentIDao(DataTable dt, string dbName)
        {
            StringBuilder content = new StringBuilder();
            if (dt.Rows.Count > 0)
            {

                #region 查询

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("查询数据", 2)); //注释
                content.AppendFormat("{0}{0}DataTable Get{1}Table (string id);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 新增

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("新增数据", 2)); //注释
                content.AppendFormat("{0}{0}int Insert{1} ({1} model);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 更新

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("更新数据", 2)); //注释
                content.AppendFormat("{0}{0}int Update{1} ({1} model);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 删除

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("删除数据", 2)); //注释
                content.AppendFormat("{0}{0}int Delete{1} (string id);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

            }
            return content.ToString();
        }

        /// <summary>
        ///  BLL
        /// </summary>
        /// <param name="namespaces">命名空间</param>
        /// <param name="dbName">数据库表名</param>
        /// <param name="dt">数据库表查询结果</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:17:07
        public static string CompleteService(string namespaces, string dbName, DataTable dt)
        {
            StringBuilder top = new StringBuilder();
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("using System.Data;{1}using {0};{1}{1}", namespaces + ".IBLL", PublicFiled.WarpSymbol);
            top.AppendFormat("namespace {0}{1}", namespaces + ".BLL", PublicFiled.WarpSymbol);
            top.Append("{");
            top.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}public class {1}Service : I{1}Service{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("{");
            top.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{0}private I{1}Dao _{2}Dao;{3}{3}", PublicFiled.TabSymbol, dbName, dbName.ToLower(), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{0}public {1}Service(I{1}Dao {2}Dao){3}", PublicFiled.TabSymbol, dbName,
                dbName.ToLower(), PublicFiled.WarpSymbol);
            top.Append("\t\t{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{0}{0}_{1}Dao={1}Dao;{2}", PublicFiled.TabSymbol, dbName.ToLower(), PublicFiled.WarpSymbol);
            top.Append("\t\t}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{1}", ContentService(dt, dbName), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("}");
            return top.ToString();
        }

        /// <summary>
        ///  BLL内容
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:27:02
        private static string ContentService(DataTable dt, string dbName)
        {
            StringBuilder content = new StringBuilder();
            if (dt.Rows.Count > 0)
            {

                #region 查询

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("查询数据", 2)); //注释
                content.AppendFormat("{0}{0}public DataTable Get{1}Table (string id){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return _{1}Dao.Get{2}Table (id);{3}", PublicFiled.TabSymbol, dbName.ToLower(), dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 新增

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("新增数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Insert{1} ({1} model){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return _{1}Dao.Insert{2} (model);{3}", PublicFiled.TabSymbol, dbName.ToLower(), dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 更新

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("更新数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Update{1} ({1} model){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return _{1}Dao.Update{2} (model);{3}", PublicFiled.TabSymbol, dbName.ToLower(), dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

                #region 删除

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("删除数据", 2)); //注释
                content.AppendFormat("{0}{0}public int Delete{1} (string id){2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t{");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);
                content.AppendFormat("{0}{0}{0}return _{1}Dao.Delete{2} (id);{3}", PublicFiled.TabSymbol, dbName.ToLower(), dbName, PublicFiled.WarpSymbol);
                content.Append("\t\t}");
                content.AppendFormat("{0}", PublicFiled.WarpSymbol);

                #endregion

            }
            return content.ToString();
        }

        /// <summary>
        ///  IBLL
        /// </summary>
        /// <param name="namespaces">命名空间</param>
        /// <param name="dbName">数据库表名</param>
        /// <param name="dt">数据库表查询结果</param>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:17:07
        public static string CompleteIService(string namespaces, string dbName, DataTable dt)
        {
            StringBuilder top = new StringBuilder();
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("using System.Data;{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("namespace {0}{1}", namespaces + ".IBLL", PublicFiled.WarpSymbol);
            top.Append("{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}public interface I{1}Service ", PublicFiled.TabSymbol, dbName);
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("\t{");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.AppendFormat("{0}{1}", ContentIService(dt, dbName), PublicFiled.WarpSymbol);
            top.AppendFormat("{0}", PublicFiled.TabSymbol);
            top.Append("}");
            top.AppendFormat("{0}", PublicFiled.WarpSymbol);
            top.Append("}");
            return top.ToString();
        }

        /// <summary>
        ///  IBLL内容
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-05-27 15:27:02
        private static string ContentIService(DataTable dt, string dbName)
        {
            StringBuilder content = new StringBuilder();
            if (dt.Rows.Count > 0)
            {

                #region 查询

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("查询数据", 2)); //注释
                content.AppendFormat("{0}{0}DataTable Get{1}Table (string id);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 新增

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("新增数据", 2)); //注释
                content.AppendFormat("{0}{0}int Insert{1} ({1} model);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 更新

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("更新数据", 2)); //注释
                content.AppendFormat("{0}{0}int Update{1} ({1} model);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

                #region 删除

                content.AppendFormat("{0}{1}", PublicFiled.WarpSymbol, PublicFun.GetCommentary("删除数据", 2)); //注释
                content.AppendFormat("{0}{0}int Delete{1} (string id);{2}", PublicFiled.TabSymbol, dbName, PublicFiled.WarpSymbol);

                #endregion

            }
            return content.ToString();
        }

    }
}
