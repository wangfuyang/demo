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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           string name = textBox1.Text;
            string credit = textBox2.Text;
            string remark = textBox3.Text;
            string sql ="INSERT INTO course (name,credit,remark) VALUES ('" + name + "','" + credit + "','" + remark + "')";
           DBlink.ExecuteNonQuery(sql);
            myRefresh();
            this.Close();
        }


        //定义委托
        public delegate void Refresh();
        //定义事件
        public event Refresh myRefresh;
    }
}
