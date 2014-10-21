
using System.Data;
using System.Text;
using NapoleonCode.BLL;
using NapoleonCode.Common;
using NapoleonCode.Model;

namespace NapoleonCode.Win.MovingTemplate
{
    public class AutofacTemplate
    {

        private static readonly MsSqlDao Bll = new MsSqlDao();

        /// <summary>
        ///  Autofac模版的配置文件
        /// </summary>
        /// <param name="appConfig">数据库配置类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-26 14:41:00
        public static string InsertAutofacXml(AppConfig appConfig)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dt = Bll.GetTreeView(appConfig, PublicFiled.DataBaseName, "U");
            if (dt.Rows.Count > 0)
            {
                sb.AppendFormat("新建配置文件AuthConfig.cs，将配置写入进去，并在Application_Start()中启用");
                sb.AppendFormat("{0}{0}{0}{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}", PublicFun.GetCommentary("初始化Autofac"));
                sb.AppendFormat("public static void InitAutofc(){0}", PublicFiled.WarpSymbol);
                sb.Append("{");
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      ContainerBuilder builder = new ContainerBuilder();{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      SetupResolveRules(builder);//注册类{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      builder.RegisterControllers(Assembly.GetExecutingAssembly());//注册控制器{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      IContainer container = builder.Build();{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      DependencyResolver.SetResolver(new AutofacDependencyResolver(container));{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("      AreaRegistration.RegisterAllAreas();{0}", PublicFiled.WarpSymbol);
                sb.Append("}");
                sb.AppendFormat("{0}{0}{0}", PublicFiled.WarpSymbol);
                sb.AppendFormat("{0}", PublicFun.GetCommentary("需要用到的类进行注册"));
                sb.AppendFormat("private static void SetupResolveRules(ContainerBuilder builder){0}", PublicFiled.WarpSymbol);
                sb.Append("{");
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
                foreach (DataRow row in dt.Rows)
                {
                    string name = PublicFun.FormatTableName(row["name"].ToString());
                    sb.AppendFormat("      builder.RegisterType<{0}>().As<{1}>();{2}", name + "Dao", "I" + name + "Dao", PublicFiled.WarpSymbol);
                    sb.AppendFormat("      builder.RegisterType<{0}>().As<{1}>();{2}", name + "Service", "I" + name + "Service", PublicFiled.WarpSymbol);
                }
                sb.Append("}");
                sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            }
            return sb.ToString();
        }

    }
}
