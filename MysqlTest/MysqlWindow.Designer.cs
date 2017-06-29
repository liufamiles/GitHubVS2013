namespace MysqlTest
{
    partial class MysqlWindow
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MysqlWindow));
            this.username_la = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_la = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_la
            // 
            this.username_la.AutoSize = true;
            this.username_la.BackColor = System.Drawing.SystemColors.Control;
            this.username_la.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username_la.Location = new System.Drawing.Point(6, 17);
            this.username_la.Name = "username_la";
            this.username_la.Size = new System.Drawing.Size(74, 12);
            this.username_la.TabIndex = 0;
            this.username_la.Text = "username：";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(86, 14);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(112, 21);
            this.username_tb.TabIndex = 1;
            // 
            // password_la
            // 
            this.password_la.AutoSize = true;
            this.password_la.BackColor = System.Drawing.SystemColors.Control;
            this.password_la.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password_la.Location = new System.Drawing.Point(238, 17);
            this.password_la.Name = "password_la";
            this.password_la.Size = new System.Drawing.Size(74, 12);
            this.password_la.TabIndex = 2;
            this.password_la.Text = "password：";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(318, 14);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(112, 21);
            this.password_tb.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.username_tb);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Controls.Add(this.username_la);
            this.panel1.Controls.Add(this.password_la);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.connect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(457, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 290);
            this.panel2.TabIndex = 5;
            // 
            // connect
            // 
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connect.Image = ((System.Drawing.Image)(resources.GetObject("connect.Image")));
            this.connect.Location = new System.Drawing.Point(15, 64);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(93, 93);
            this.connect.TabIndex = 0;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // MysqlWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(575, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MysqlWindow";
            this.Text = "Connect Mysql";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MysqlWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label username_la;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label password_la;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button connect;
    }
}

