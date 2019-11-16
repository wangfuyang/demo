using ListVIew;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //页面初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            //构建表头
           // listView1.Columns.Add("编号");
           // listView1.Columns.Add("名称");
          //  listView1.Columns.Add("学分");
           // listView1.Columns.Add("备注");
            string sql = "select id, name,credit,remark from course";
            DataTable dt= DBlink.GetDataTable(sql);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lt = new ListViewItem();
                 lt.Text = dt.Rows[i][0].ToString();
               // lt.SubItems.Add(dt.Columns[0].ToString());
                lt.SubItems.Add(dt.Rows[i][1].ToString());
                lt.SubItems.Add(dt.Rows[i][2].ToString());
                lt.SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items.Add(lt);
            }
           


        }
        //查询
        private void btnsearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text1.Text.Trim().ToString());
            string sql1 = "select id, name,credit,remark from course where id=" + id;
            DataTable dt=   DBlink.GetDataTable(sql1);
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dt.Rows[i][0].ToString();
                // lt.SubItems.Add(dt.Columns[0].ToString());
                lt.SubItems.Add(dt.Rows[i][1].ToString());
                lt.SubItems.Add(dt.Rows[i][2].ToString());
                lt.SubItems.Add(dt.Rows[i][3].ToString());
                listView1.Items.Add(lt);
            }

        }
        //添加
        private void btnadd_Click(object sender, EventArgs e)
        {
            addForm add = new addForm();
            add.myRefresh += new addForm.Refresh(RefreshControl);
            add.Show();
        }

        //定义刷新方法
        private void RefreshControl()
        {
            //绑定加载信息
            Form1_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListViewItem row = listView1.SelectedItems[0];//选中要修改的行
            string id = row.SubItems[0].Text.ToString();//获取列上的值
            //MessageBox.Show(id,"tishi");
            String sql = "delete from course where id=" + id;
            DBlink.ExecuteNonQuery(sql);
            this.Form1_Load(null, null);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ListViewItem row = listView1.SelectedItems[0];//选中要修改的行
            editForm edit = new editForm(row);
            edit.myRefresh += new editForm.Refresh(RefreshControl);
            edit.Show();
        }
    }
}
