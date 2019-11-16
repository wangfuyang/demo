namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("节点18");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("节点19");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("节点5", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("节点20");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("节点21");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("节点6", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("节点9");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("节点2", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("节点12");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("节点13");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("节点14");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("节点3", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("节点15");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("节点16");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("节点17");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.FullRowSelect = true;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode23.Name = "节点18";
            treeNode23.Text = "节点18";
            treeNode24.Name = "节点19";
            treeNode24.Text = "节点19";
            treeNode25.Name = "节点5";
            treeNode25.Text = "节点5";
            treeNode26.Name = "节点20";
            treeNode26.Text = "节点20";
            treeNode27.Name = "节点21";
            treeNode27.Text = "节点21";
            treeNode28.Name = "节点6";
            treeNode28.Text = "节点6";
            treeNode29.Checked = true;
            treeNode29.Name = "节点0";
            treeNode29.Text = "节点0";
            treeNode30.Name = "节点7";
            treeNode30.Text = "节点7";
            treeNode31.Name = "节点8";
            treeNode31.Text = "节点8";
            treeNode32.Name = "节点9";
            treeNode32.Text = "节点9";
            treeNode33.Name = "节点1";
            treeNode33.Text = "节点1";
            treeNode34.Name = "节点10";
            treeNode34.Text = "节点10";
            treeNode35.Name = "节点11";
            treeNode35.Text = "节点11";
            treeNode36.Name = "节点2";
            treeNode36.Text = "节点2";
            treeNode37.Name = "节点12";
            treeNode37.Text = "节点12";
            treeNode38.Name = "节点13";
            treeNode38.Text = "节点13";
            treeNode39.Name = "节点14";
            treeNode39.Text = "节点14";
            treeNode40.Name = "节点3";
            treeNode40.Text = "节点3";
            treeNode41.Name = "节点15";
            treeNode41.Text = "节点15";
            treeNode42.Name = "节点16";
            treeNode42.Text = "节点16";
            treeNode43.Name = "节点17";
            treeNode43.Text = "节点17";
            treeNode44.Name = "节点4";
            treeNode44.Text = "节点4";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode33,
            treeNode36,
            treeNode40,
            treeNode44});
            this.treeView1.Size = new System.Drawing.Size(178, 343);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(178, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(714, 277);
            this.textBox1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(254, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "根节点+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(357, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "根节点-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 343);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "树形结构";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

