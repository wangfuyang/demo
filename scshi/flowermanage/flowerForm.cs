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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {//退出程序
            Application.Exit();
        }

        private void 增加花卉信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm add = new addForm();
            add.MdiParent = this;//指定父容器为当前窗体
            add.Show(); 
        }

        private void 查看花卉信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFlowerForm showflower = new showFlowerForm();
            showflower.MdiParent = this;//指定父容器为当前窗体
            showflower.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = imageList1.Images[3];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("你该吃药了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        } 
    }
}
