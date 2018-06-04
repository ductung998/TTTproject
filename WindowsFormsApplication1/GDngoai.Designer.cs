namespace WindowsFormsApplication1
{
    partial class GDngoai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuhtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttcanhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.qltkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuhtToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuhtToolStripMenuItem1
            // 
            this.menuhtToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuhtToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signoutToolStripMenuItem,
            this.ttcanhanToolStripMenuItem,
            this.signinToolStripMenuItem1,
            this.toolStripSeparator3,
            this.qltkToolStripMenuItem});
            this.menuhtToolStripMenuItem1.Name = "menuhtToolStripMenuItem1";
            this.menuhtToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.menuhtToolStripMenuItem1.Text = "Hệ thống";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.signoutToolStripMenuItem.Text = "Đăng xuất";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // ttcanhanToolStripMenuItem
            // 
            this.ttcanhanToolStripMenuItem.Name = "ttcanhanToolStripMenuItem";
            this.ttcanhanToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ttcanhanToolStripMenuItem.Text = "Thông tin cá nhân";
            this.ttcanhanToolStripMenuItem.Click += new System.EventHandler(this.ttcanhanToolStripMenuItem_Click);
            // 
            // signinToolStripMenuItem1
            // 
            this.signinToolStripMenuItem1.Name = "signinToolStripMenuItem1";
            this.signinToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.signinToolStripMenuItem1.Text = "Đăng nhập";
            this.signinToolStripMenuItem1.Click += new System.EventHandler(this.signinToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // qltkToolStripMenuItem
            // 
            this.qltkToolStripMenuItem.Name = "qltkToolStripMenuItem";
            this.qltkToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.qltkToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundButton2.Location = new System.Drawing.Point(901, 333);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(397, 128);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "BẢNG TIN BỆNH VIỆN";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundButton1.Location = new System.Drawing.Point(901, 142);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(397, 128);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "GIÁM SÁT SỬ DỤNG THUỐC";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // GDngoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Name = "GDngoai";
            this.Text = "GDngoai";
            this.Load += new System.EventHandler(this.GDngoai_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuhtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttcanhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem qltkToolStripMenuItem;
    }
}