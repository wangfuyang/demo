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
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
        }
        ListViewItem Row;
        public editForm(ListViewItem row)
        {
            InitializeComponent();
            this.Row = row;
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            string name = this.text1.Text;
            string credit = this.text2.Text;
            string remark = this.text3.Text;
            string id = Row.SubItems[0].Text.ToString();
            String sql = "update course set name='" + name + "',credit='" + credit + "',remark='" + remark + "' where id=" + id;
            DBlink.ExecuteNonQuery(sql);
            myRefresh();
            this.Close();
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            this.text1.Text = Row.SubItems[1].Text.ToString();
            this.text2.Text = Row.SubItems[2].Text.ToString();
            this.text3.Text = Row.SubItems[3].Text.ToString();


        }

        //定义委托
        public delegate void Refresh();
        //定义事件
        public event Refresh myRefresh;
    }
}
