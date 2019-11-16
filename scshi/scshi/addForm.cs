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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = text1.Text;
            string credit= text2.Text;
            string remark = text3.Text;
                
            String sql = "INSERT INTO course (name,credit,remark) VALUES ('" + name + "','" + credit + "','" + remark + "')";
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
