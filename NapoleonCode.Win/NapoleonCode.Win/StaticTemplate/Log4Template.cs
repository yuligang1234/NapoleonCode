
using System.Text;
using NapoleonCode.Common;

namespace NapoleonCode.Win.StaticTemplate
{
    public class Log4Template
    {

        /// <summary>
        ///  文本配置
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 15:28:28
        public static string InsertTxtConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("将下面配置加入到log4net.config中，并在AssemblyInfo.cs中加入log4net.config路径");
            sb.AppendFormat("{0}{0}{0}{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<?xml version=\"1.0\" encoding=\"utf-8\"?>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<log4net>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!-- 错误日志类-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <logger name=\"logerror\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <level value=\"ALL\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <appender-ref ref=\"ErrorAppender\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </logger>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!-- 错误日志附加介质-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <appender name=\"ErrorAppender\" type=\"log4net.Appender.RollingFileAppender\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--文件路径-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"File\" value=\"Log4\\\\Error\\\\\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--是否覆盖-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"AppendToFile\" value=\"true\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--设置备份，-1表示无限制-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"MaxSizeRollBackups\" value=\"100\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--文件大小1MB-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"MaximumFileSize\" value=\"1024\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"StaticLogFileName\" value=\"false\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--文件名称-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"DatePattern\" value=\"yyyyMM\\yyyyMMdd&quot;.htm&quot;\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"RollingStyle\" value=\"Date\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <!--错误信息布局-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <param name=\"ConversionPattern\" value=\"&lt;HR COLOR=red&gt;%n【异常时间】：%d [%t] &lt;BR&gt;%n【异常级别】：%-5p &lt;BR&gt;%n【异 常 类】：%c [%x] &lt;BR&gt;%n%m &lt;BR&gt;\"  />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </appender>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!-- 信息日志类 -->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <logger name=\"loginfo\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <level value=\"info\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <appender-ref ref=\"InfoAppender\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </logger>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!-- 信息日志附加介质-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <appender name=\"InfoAppender\" type=\"log4net.Appender.RollingFileAppender\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"File\" value=\"Log4\\\\Info\\\\\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"AppendToFile\" value=\"false\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"MaximumFileSize\" value=\"1024\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"MaxSizeRollBackups\" value=\"100\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"StaticLogFileName\" value=\"false\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"DatePattern\" value=\"yyyyMM\\yyyyMMdd&quot;.htm&quot;\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"RollingStyle\" value=\"Date\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!-- 信息日志布局-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <param name=\"ConversionPattern\" value=\"&lt;HR COLOR=blue&gt;%n日志时间：%d [%t] &lt;BR&gt;%n日志级别：%-5p &lt;BR&gt;%n日 志 类：%c [%x] &lt;BR&gt;%n%m &lt;BR&gt;\"  />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </appender>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("</log4net>{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        /// <summary>
        ///  文本Helper
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 15:28:52
        public static string InsertTxtHelper()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("//对应配置文件中的loginfo节点{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("private static readonly log4net.ILog LogInfo = log4net.LogManager.GetLogger(\"loginfo\");{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("//对应配置文件中的logerror节点{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("private static readonly log4net.ILog LogError = log4net.LogManager.GetLogger(\"logerror\");{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("{0}", PublicFun.GetCommentary("信息记录"));
            sb.AppendFormat("public static void WriteLog(string info){0}", PublicFiled.WarpSymbol);
            sb.Append("{");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  if (LogInfo.IsInfoEnabled){0}", PublicFiled.WarpSymbol);
            sb.Append("  {");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    LogInfo.Info(info);{0}", PublicFiled.WarpSymbol);
            sb.Append("  }");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("}");
            sb.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("{0}", PublicFun.GetCommentary("错误记录"));
            sb.AppendFormat("public static void ErrorLog(string info, Exception ex){0}", PublicFiled.WarpSymbol);
            sb.Append("{");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  if (!string.IsNullOrEmpty(info) && ex == null){0}", PublicFiled.WarpSymbol);
            sb.Append("  {");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("    LogError.ErrorFormat(\"【附加信息】:{0}<br>\", new object[] { info });");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("  }");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  else if (!string.IsNullOrEmpty(info) && ex != null){0}", PublicFiled.WarpSymbol);
            sb.Append("  {");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    string errorMsg = BeautyErrorMsg(ex);{0}", PublicFiled.WarpSymbol);
            sb.Append("    LogError.ErrorFormat(\"【附加信息】:{0}<br>{1}\", new object[] { info, errorMsg });");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("  }");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  else if (!string.IsNullOrEmpty(info) && ex != null){0}", PublicFiled.WarpSymbol);
            sb.Append("  {");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    string errorMsg = BeautyErrorMsg(ex);{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    LogError.Error(errorMsg);{0}", PublicFiled.WarpSymbol);
            sb.Append("  }");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("}");
            sb.AppendFormat("{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("{0}", PublicFun.GetCommentary("美化错误信息"));
            sb.AppendFormat("private static string BeautyErrorMsg(Exception ex){0}", PublicFiled.WarpSymbol);
            sb.Append("{");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.Append("  string errorMsg = string.Format(\"【异常类型】：{0} <br>【异常信息】：{1} <br>【堆栈调用】：{2}\", new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  errorMsg = errorMsg.Replace(\"\r\n\", \"<br>\");{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  errorMsg = errorMsg.Replace(\"位置\", \"<strong style=\"color:red\">位置</strong>\");{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("return errorMsg;{0}", PublicFiled.WarpSymbol);
            sb.Append("}");
            sb.AppendFormat("{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        /// <summary>
        ///  数据库配置
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 15:30:15
        public static string InsertDbConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("该配置为Oracle数据库的配置，更换数据库，请修改对应的appender-ref节点和parameterName的value形式");
            sb.AppendFormat("{0}{0}{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<configSections>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <section name=\"log4net\" type=\"log4net.Config.Log4NetConfigurationSectionHandler, log4net\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("</configSections>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("<log4net>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <logger name=\"logerror\" additivity=\"false\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <level value=\"ALL\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <appender-ref ref=\"AdoNetAppender_Oracle\" />{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </logger>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <!--写入到数据库-->{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <appender name=\"AdoNetAppender_Oracle\" type=\"log4net.Appender.AdoNetAppender\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <connectionType value=\"System.Data.OracleClient.OracleConnection, System.Data.OracleClient, Version=4.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <connectionString value=\"Data Source=orcl;User ID=tdcb;Password=123;pooling=true;max pool size=1000\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <commandText value=\"INSERT INTO T_ErrorLog (LOG_DATE, THREAD, LOG_LEVEL, LOGGER, MESSAGE, EXCEPTION) VALUES ( :log_date, :thread, :log_level, :logger, :message, :exception)\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <bufferSize value=\"1\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <parameterName value=\":log_date\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value=\"DateTime\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type=\"log4net.Layout.PatternLayout\" value=\"%date{0}\"/>{1}", "{yyyy'-'MM'-'dd HH':'mm':'ss'.'fff}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <parameterName value=\":thread\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value=\"String\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <size value=\"50\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("        <conversionPattern value=\"%thread\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <parameterName value=\":log_level\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value=\"String\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <size value=\"50\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("        <conversionPattern value=\"%level\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <parameterName value=\":logger\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value=\"String\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <size value=\"200\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("        <conversionPattern value=\"%logger\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <parameterName value=\":message\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value=\"String\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <size value=\"400\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type=\"log4net.Layout.PatternLayout\">{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("        <conversionPattern value=\"%message\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      </layout>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <parameterName  value =\":exception\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <dbType value =\"String\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <size value =\"200\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("      <layout type =\"log4net.Layout.ExceptionLayout\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    </parameter>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </appender>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  <root>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <level value=\"ALL\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    <appender-ref ref=\"AdoNetAppender_Oracle\"/>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("  </root>{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("</log4net>{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

        /// <summary>
        ///  数据库Helper
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2014-09-29 15:30:54
        public static string InsertDbHelper()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("在Application_Start方法中初始化:{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    log4net.Config.XmlConfigurator.Configure();{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("{0}{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("在Application_Error方法中处理错误:{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    Exception objErr = Server.GetLastError().GetBaseException();{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    log4net.ILog log = log4net.LogManager.GetLogger(Request.Url.ToString());{0}", PublicFiled.WarpSymbol);
            sb.Append("    log.ErrorFormat(\"发生异常页:{0}<br>异常信息{1}<br>source:{2}\", Request.Url.ToString(),objErr.Message, objErr.StackTrace);Server.ClearError();");
            sb.AppendFormat("{0}{0}{0}{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("需要写入错误的时候:{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    private static log4net.ILog myLogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);{0}", PublicFiled.WarpSymbol);
            sb.AppendFormat("    myLogger.Error(message);{0}", PublicFiled.WarpSymbol);
            return sb.ToString();
        }

    }
}
