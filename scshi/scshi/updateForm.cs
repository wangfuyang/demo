using scshi.demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scshi
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }
        DataGridViewRow Row;
        public edit(DataGridViewRow row)
        {
            InitializeComponent();
            this.Row = row;//扩大作用域范围
        }
        //窗体加载事件
        private void edit_Load(object sender, EventArgs e)
        {

            this.text1.Text = Row.Cells["name"].Value.ToString();
            this.text2.Text = Row.Cells["credit"].Value.ToString();
            this.text3.Text = Row.Cells["remark"].Value.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.text1.Text = "";
            this.text2.Text = "";
            this.text3.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = text1.Text;
            string credit = text2.Text;
            string remark = text3.Text;
            string id = Row.Cells["id"].Value.ToString();
            String sql = "update course set name='"+name+"',credit='"+credit+"',remark='"+remark+"' where id="+ id;
            DBhelper.ExecuteNonQuery(sql);

            //点击执行事件
            myRefresh();
            this.Close();
           
        }

      
        //定义委托
        public delegate void Refresh();
        //定义事件
        public event Refresh myRefresh;

    }
}
