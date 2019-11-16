namespace flowermanage
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.增加花卉信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看花卉信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加花卉信息ToolStripMenuItem,
            this.查看花卉信息ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 增加花卉信息ToolStripMenuItem
            // 
            this.增加花卉信息ToolStripMenuItem.Name = "增加花卉信息ToolStripMenuItem";
            this.增加花卉信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.增加花卉信息ToolStripMenuItem.Text = "增加花卉信息";
            this.增加花卉信息ToolStripMenuItem.Click += new System.EventHandler(this.增加花卉信息ToolStripMenuItem_Click);
            // 
            // 查看花卉信息ToolStripMenuItem
            // 
            this.查看花卉信息ToolStripMenuItem.Name = "查看花卉信息ToolStripMenuItem";
            this.查看花卉信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.查看花卉信息ToolStripMenuItem.Text = "查看花卉信息";
            this.查看花卉信息ToolStripMenuItem.Click += new System.EventHandler(this.查看花卉信息ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "COR11.jpg");
            this.imageList1.Images.SetKeyName(1, "FCOG11.jpg");
            this.imageList1.Images.SetKeyName(2, "FCOK51.jpg");
            this.imageList1.Images.SetKeyName(3, "FCOK52.jpg");
            this.imageList1.Images.SetKeyName(4, "FCOM51.jpg");
            this.imageList1.Images.SetKeyName(5, "FCOM61.jpg");
            this.imageList1.Images.SetKeyName(6, "FCOM62.jpg");
            this.imageList1.Images.SetKeyName(7, "FCOM63.jpg");
            this.imageList1.Images.SetKeyName(8, "FCOM64.jpg");
            this.imageList1.Images.SetKeyName(9, "FCOM66.jpg");
            this.imageList1.Images.SetKeyName(10, "FCOR51.jpg");
            this.imageList1.Images.SetKeyName(11, "FCOS51.jpg");
            this.imageList1.Images.SetKeyName(12, "FCOS61.jpg");
            this.imageList1.Images.SetKeyName(13, "FCUH6.jpg");
            this.imageList1.Images.SetKeyName(14, "FCUH7.jpg");
            this.imageList1.Images.SetKeyName(15, "FCUH8.jpg");
            this.imageList1.Images.SetKeyName(16, "FCUH9.jpg");
            this.imageList1.Images.SetKeyName(17, "FCUH10.jpg");
            this.imageList1.Images.SetKeyName(18, "FCUH11.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "启动定时器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "关闭定时器";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "花卉管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加花卉信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看花卉信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}