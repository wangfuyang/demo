using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace scshi
{
    class DBlink
    {
        public static string ConnStr = "Data Source='127.0.0.1' ;port=3306;user id=root;password=root;database=test;charset=utf8";
        //执行添加删除修改的通用方法
        public static int ExcuteNonQuery(String  sql, params SqlParameter[]paras) {
            //创建数据库链接对象
            MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();//打开数据库链接
            //创建执行脚本对象
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add(paras);//添加参数
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        //执行查询 单个
        public static Object ExcuteSelet(String sql, params SqlParameter[] paras)
        {
            Object obj = null;
            //创建数据库链接对象
            MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();//打开数据库链接
            //创建执行脚本对象
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddRange(paras);//添加参数
            obj = command.ExecuteScalar();//执行脚本
            conn.Close();
            return obj;
        }
        //执行查询 多个
        public static MySqlDataReader ExcuteSelets(String sql, params SqlParameter[] paras)
        {
             MySqlDataReader reader = null;
            //创建数据库链接对象
            MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();//打开数据库链接
            //创建执行脚本对象
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddRange(paras);//添加参数
             reader = command.ExecuteReader();//执行脚本
            // reader = command.ExecuteReader(CommandBehavior.CloseConnection);//关闭 conn
            conn.Close();
            return reader;
        }

        public static DataTable GetDateTable(String sql, params MySqlParameter[] paras)
        {//断开式链接方式 不需要显示写open close 
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(ConnStr);
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddRange(paras);
            MySqlDataAdapter dapter = new MySqlDataAdapter();
            dapter.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
