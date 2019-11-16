using System;
using System.Collections.Generic;
using ListView;
using MySql.Data.MySqlClient;
using System.Data;

namespace ListVIew
{
    class DBlink
    {
        public static string ConnStr = "Data Source='127.0.0.1' ;port=3306;user id=root;password=root;database=test;charset=utf8";
        public static DataTable GetDataTable(string SQL)
        {
            DataTable ADt = new DataTable();
            MySqlConnection AConn = new MySqlConnection(ConnStr);
            try
            {
                MySqlDataAdapter ADp = new MySqlDataAdapter(SQL, AConn);
                ADp.Fill(ADt);
            }
            catch
            {
                ;
            }
            finally
            {
                AConn.Close();
                AConn.Dispose();
                AConn = null;
            }
            return ADt;
        }
        //增删改
        public static int ExecuteNonQuery(string sql)
        {
            MySqlConnection conn = new MySqlConnection(ConnStr);
            {
                conn.Open();
                MySqlTransaction trans = conn.BeginTransaction();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Transaction = trans;

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    int result = cmd.ExecuteNonQuery();
                    trans.Commit();
                    return result;
                }
                catch
                {
                    trans.Rollback();
                    return 0;
                }
                finally
                {
                    conn.Close();

                }
            }
        }
    }
}
