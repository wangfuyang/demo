using scshi.demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace scshi
{
    public partial class showForm : Form
    {
        public showForm()
        {
            InitializeComponent();
            //全屏
            //  this.WindowState = FormWindowState.Maximized;
        }

        private void showForm_Load(object sender, EventArgs e)
        {
                string sql = "SELECT id,name,credit,remark from course";
//            string sql = "SELECT l.*,s.* from  login_info l  LEFT JOIN student_score s ON l.number=s.number;";
            DataTable dt = DBhelper.GetDataTable(sql);
            this.dgv1.DataSource = dt;
            this.dgv1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //获取输入条件
            string iname = input1.Text;
            string sql = " SELECT id,name,credit,remark from course where name like '%"+ iname.Trim()+"%'" ;
        
            this.dgv1.DataSource = DBhelper.GetDataTable(sql);
        }
        //鼠标点击事件 左键 右键
        private void dgv1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button== MouseButtons.Right) {
                if (e.RowIndex >= 0)
                {
                    //取消选中
                    this.dgv1.ClearSelection();
                    this.dgv1.Rows[e.RowIndex].Selected = true;//选中
                }
                else if(e.Button == MouseButtons.Left) {
                    //取消选中
                    this.dgv1.ClearSelection();
                    this.dgv1.Rows[e.RowIndex].Selected = true;//选中
                }

        }
        }

        private void cms1_Click(object sender, EventArgs e)
        {
          DataGridViewRow row=  this.dgv1.SelectedRows[0];//选中要修改的行
           string id = row.Cells["id"].Value.ToString();//获取列上的值
            edit updateform = new edit(row);

            //定阅这个事件
            updateform.myRefresh += new edit.Refresh(RefreshControl);
            updateform.Show();

        }
        //定义刷新方法
        private void RefreshControl()
        {
            //绑定加载信息
         showForm_Load(null,null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv1.SelectedRows[0];//选中要修改的行
            string id = row.Cells["id"].Value.ToString();//获取列上的值
            edit updateform = new edit(row);
            updateform.myRefresh += new edit.Refresh(RefreshControl);
            updateform.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add updateform = new add();
            updateform.myRefresh += new add.Refresh(RefreshControl);
            updateform.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgv1.SelectedRows[0];//选中要修改的行
            string id = row.Cells["id"].Value.ToString();//获取列上的值
            String sql = "delete from course where id="+id;
            DBhelper.ExecuteNonQuery(sql);
            this.showForm_Load(null, null);
        }

       
        //关闭窗口 不退出程序
        private void showForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason== CloseReason.UserClosing) {
                e.Cancel = true;
                this.Hide();
            }
        }
        //双击图标显示程序
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();

        }
    }
}
