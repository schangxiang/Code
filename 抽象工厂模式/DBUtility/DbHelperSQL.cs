using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBUtility
{
    public static class DbHelperSQL
    {
        //public static readonly string connString = "Data Source=.;Initial Catalog=DB_SchoolTest;Integrated Security=True";
        public static readonly string connString = ConfigurationManager.ConnectionStrings["connStringSchool"].ConnectionString.ToString();

        #region ExecuteNonQuery
        /// <summary>
        /// 执行SQL命令
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">Sql语句或带参数的Sql语句</param>
        /// <param name="cmdParams">参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params SqlParameter[] cmdParams)
        {
            SqlCommand cmd=new SqlCommand ();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                PrepareCommand(cmd, conn, cmdType, cmdText, cmdParams);
                int val = cmd.ExecuteNonQuery();
                return val;

            }
        }
        /// <summary>
        /// 执行Sql Server存储过程
        /// 注意：不能执行有out参数的存储过程
        /// </summary>
        /// <param name="prName">存储过程名</param>
        /// <param name="parameterValues">对象参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string prName, params object[] parameterValues)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                PrepareCommand(cmd, conn, prName, parameterValues);
                int val = cmd.ExecuteNonQuery();
                return val;
            }
        }
        #endregion
        #region  ExecuteReader
        /// <summary>
        /// 执行Sql命令
        /// </summary>
        /// <param name="cmdType">命令类型,不加上这个的话，很容易跟下面的重载函数混淆</param>
        /// <param name="cmdText">sql语句/参数化sql语句</param>
        /// <param name="cmdParams">参数</param>
        /// <returns>SqlDataReader对象</returns>
        public static SqlDataReader ExecuteReader(CommandType cmdType,string cmdText, params SqlParameter[] cmdParams)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn,cmdType,cmdText, cmdParams);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch (Exception)
            {
                conn.Close();
                throw; //没有这个trow，会报出"并非所有的代码路径都返回值"
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="prName">存储过程名</param>
        /// <param name="paramValues">对象参数</param>
        /// <returns>SqlDataReader对象</returns>
        public static SqlDataReader ExecuteReader(string prName, params object[] parameterValues)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, conn, prName, parameterValues);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return sdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        #endregion

        #region Private Method
        /// <summary>
        /// 设置一个等待执行Sql语句的SqlCommand对象
        /// </summary>
        /// <param name="cmd">SqlCommand对象</param>
        /// <param name="cmdType">ComandType类型</param>
        /// <param name="conn">SqlConnection 对象，不允许空对象</param>
        /// <param name="cmdText">Sql语句</param>
        /// <param name="cmdParams">SqlParameters  对象,允许为空对象</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn,CommandType cmdType, string cmdText, SqlParameter[] cmdParams)
         {
            //打开连接
             if (conn.State != ConnectionState.Open)
                 conn.Open();

            //设置SqlCommand对象
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdText;

            if (cmdParams != null) //如果Sql语句中有参数,则将他们添加到cmd的Parameters集合中
            {
                foreach (SqlParameter parm in cmdParams)
                {
                    cmd.Parameters.Add(parm);
                }
            }
         }

        /// <summary>
        /// 设置一个等待执行存储过程的SqlCommand对象
        /// </summary>
        /// <param name="cmd">SqlCommand 对象，不允许空对象</param>
        /// <param name="conn">SqlConnection 对象，不允许空对象</param>
        /// <param name="prName">存储过程名</param>
        /// <param name="parameterValues">不定个数的存储过程的所有参数值（注意！这里是参数值，而不是参数对象!!），允许为空</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, string prName, params Object[] parameterValues)
        {
            //打开连接
            if (conn.State != ConnectionState.Open)
                conn.Open();

            //设置SqlCommand对象
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = prName;//存储过程名

            //获取该存储过程中的所有参数,并添加到cmd的Parameters集合中
            //相当于cmd.Parameters.Add();
            SqlCommandBuilder.DeriveParameters(cmd);

            //移除Return_Value 参数(这个是因为执行上面语句是，有一个默认的Return_Value 参数)
            //他位于索引等于0的地方，必须删掉他才行，这点非常重要
            cmd.Parameters.RemoveAt(0);

            //已经获取了参数，下面就要设置参数值了
            if (parameterValues != null)
            {
                for (int i = 0; i < cmd.Parameters.Count; i++)
                {
                    cmd.Parameters[i].Value = parameterValues[i];
                }

            }
        }
	   #endregion
       

    }
}
