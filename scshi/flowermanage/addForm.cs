using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowermanage
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//遍历窗体中所有控件
            foreach (Control item  in Controls) {
                if (item is TextBox) {
                    (item as TextBox).Text = String.Empty;
                }
                if (item is ComboBox) {
                    (item as ComboBox).SelectedIndex = -1;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.text1.Text)) {
                MessageBox.Show("花名不能为空");
                //得到焦点 光标移动到这个文本框上
                this.text1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.text4.Text))
            {
                MessageBox.Show("价格不能为空");
                //得到焦点 光标移动到这个文本框上
                this.text1.Focus();
                return;
            }
            else {
                try
                {
                    Convert.ToInt32(this.text4.Text);//如果转换成功 说明是数字
                }
                catch (Exception)
                {

                    MessageBox.Show("价格必须是数字");
                }
                string name = this.text1.Text;
                string anothername = this.text1.Text;
                string property = this.text1.Text;
                //string price =this.text1.Text;
                int price = int.Parse(this.text1.Text);
                string production = this.text1.Text;
                String sql = "INSERT INTO flower(name,anothername,property,price,production) VALUES('" + name +"','"+ anothername+"','"+ property +"',"+price+",'"+ production + "')";
                int t=DBlink.ExecuteNonQuery(sql);
                try
                {
                    if (t > 0)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("服务器异常");
                }
                
            }
        }
    }
}
