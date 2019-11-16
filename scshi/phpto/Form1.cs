using phpto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phpto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select id, name,url from photo";
            DataTable dt= DBlink.GetDataTable(sql);

            listView1.Items.Clear();
            imageList1.Images.Clear();
            int a = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Image myImage = Image.FromFile(dt.Rows[i][2].ToString());

                imageList1.Images.Add(myImage);
                //.Tag = dt.Rows[i][1].ToString();
                ListViewItem lt = new ListViewItem();
                lt.Text= dt.Rows[i][1].ToString();
                lt.SubItems.Add(dt.Rows[i][0].ToString());
                lt.SubItems.Add(dt.Rows[i][1].ToString());
                lt.ImageIndex = i;
                listView1.Items.Add(lt);
                myImage.Dispose();
              
                a++;
            }

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem row = listView1.SelectedItems[0];
              string id = row.SubItems[1].Text.ToString();
          
               //int  index = this.listView1.SelectedItems[0].ImageIndex;
           
            MessageBox.Show(id);
            //  imageList1.Images.Clear();
           
        }
    }
}
