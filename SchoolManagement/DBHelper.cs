using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public class DBHelper
    {
        //1.返回连接字符串
        public static string getConnstr()
        {
            return @"Data Source= LAPTOP-0K5JDDPH\SQLEXPRESS; Initial Catalog=SupermarketInfo; Integrated Security =true;";
        }
        //2.执行SQL操作（增、删、该）
        public static int ExecuteNonQuery(string sql, List<SqlParameter> paraList = null,
            CommandType commType = CommandType.Text)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection();  //创建连接对象
            try
            {
                conn.ConnectionString = DBHelper.getConnstr();    //设置连接串
                conn.Open();  //打开连接
                SqlCommand comm = new SqlCommand(); //创建命令对象
                comm.Connection = conn;     //设置命令对象的所用连接
                comm.CommandText = sql;  //设置命令文本
                comm.CommandType = commType;     //设置命令类型
                comm.CommandTimeout = 600;  //超时时间
                if (paraList != null)
                {  //给命令添加参数----------
                    foreach (SqlParameter para in paraList)
                        comm.Parameters.Add(para);
                }
                result = comm.ExecuteNonQuery();  //执行命令
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();   //关闭连接
            }
        }
        //3.执行查询命令（拉水管，返回表格）
        public static DataTable ExecuteReaderDataTable(string sql, List<SqlParameter> paraList = null,
            CommandType commType = CommandType.Text)
        {
            DataTable dt = new DataTable();  //返回值
            SqlConnection conn = new SqlConnection();  //连接桥
            try
            {
                conn.ConnectionString = DBHelper.getConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);  //命令对象
                comm.CommandType = commType;//--------------------------!!!!!!----------------------------------------
                if (paraList != null)
                {  //给命令添加参数----------
                    foreach (SqlParameter para in paraList)
                        comm.Parameters.Add(para);
                }
                SqlDataReader dr = comm.ExecuteReader();  //水管
                dt.Load(dr); //向内存表 填充水
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();//关闭连接
            }
        }
        //4.事务封装 多个SQL语句一起执行
        public static void ExecuteNonQueryTransaction(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = DBHelper.getConnstr();
            SqlTransaction trans = null; //定义事务
            try
            {
                conn.Open();
                trans = conn.BeginTransaction();//开启事务   
                foreach (string sql in sqlList)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = sql;
                    comm.Connection = conn;
                    comm.Transaction = trans; //命令事务属性
                    comm.ExecuteNonQuery(); //执行SQL
                }
                trans.Commit();//提交事务
            }
            catch (Exception ex)
            {
                trans.Rollback(); //事务回滚
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //5.连线查询 -拉水管   ，返回水管对象
        public static SqlDataReader ExecuteReader(string sql, List<SqlParameter> paraList = null,
            CommandType commType = CommandType.Text)
        {
            SqlDataReader dr; //
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = DBHelper.getConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = sql;
                comm.CommandType = commType;
                comm.CommandTimeout = 600;
                if (paraList != null)
                {  //给命令添加参数----------
                    foreach (SqlParameter para in paraList)
                        comm.Parameters.Add(para);
                }
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection); //             
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //6. 聚合查询
        public static object ExecuteScalar(string sql, List<SqlParameter> paraList = null,
            CommandType commType = CommandType.Text)
        {
            object value;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = DBHelper.getConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = sql;
                comm.CommandType = commType;
                comm.CommandTimeout = 600;
                if (paraList != null)
                {  //给命令添加参数----------
                    foreach (SqlParameter para in paraList)
                        comm.Parameters.Add(para);
                }
                value = comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return value;
        }
        //7.创建一个参数
        public static SqlParameter createPara(string paraName, SqlDbType paraType,
            ParameterDirection paraDire = ParameterDirection.Input, object paraValue = null,
             int paraSize = 0)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = paraName; //参数名
            para.SqlDbType = paraType; //参数类型
            para.Direction = paraDire; //参数方向
            if (paraValue != null)
                para.Value = paraValue;  //参数值
            if (paraSize != 0)
                para.Size = paraSize;   //参数大小
            return para;
        }
        //8.离线查询 ，返回DataTable
        public static DataTable ExecuteAdapter(string sql, List<SqlParameter> paraList = null,
            CommandType commType = CommandType.Text)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = DBHelper.getConnstr();
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.CommandType = commType;
                if (paraList != null)
                {  //给命令添加参数----------
                    foreach (SqlParameter para in paraList)
                        comm.Parameters.Add(para);
                }
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();   //不能关闭连接，水管断开
            }
        }



    }
}
