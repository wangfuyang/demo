using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace scshi.工具类
{
    class DBlink
    {
        MySqlConnection sqlCnn = new MySqlConnection(); //创建数据库连接对象
        MySqlCommand sqlCmd = new MySqlCommand();       //创建执行sql的对象
        public Boolean DBtag = false;
    }
    public Boolean DBconn() {
        sqlCnn.ConnectionString = "server = '127.0.0.1'; uid = 'root'; pwd = 'root'; database = 'test';";//连接字符串
        sqlCmd.Connection = sqlCnn;
        try
        {
            sqlCnn.Open();
            DBtag = true;
            if (DBtag)
            {
                //Console.WriteLine("数据库连接成功");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error");
            // Console.WriteLine(ex.Message);
            //Console.WriteLine("数据库连接失败");
        }
        finally
        {
            //textBox2.AppendText("数据库连接关闭！");

        }
        return DBtag;
    }
    //执行查询的sql
    public Boolean search(String str)
    {
        sqlCmd.CommandText = str;
        Boolean tag = false;
        MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
        while (rec.Read())
        {
            tag = true;
            // Console.WriteLine("查询到数据");
        }
        return tag;
    }
    //执行增删改的sql
    public Boolean UpdataDeletAdd(string str)
    {
        sqlCmd.CommandText = str;
        return sqlCmd.ExecuteNonQuery() > 0;
    }
}
