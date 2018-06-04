namespace WindowsFormsApplication1
{
    partial class Xembantin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xembantin));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Docchk = new System.Windows.Forms.CheckBox();
            this.Loc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tukhoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NDphanhoi = new System.Windows.Forms.TextBox();
            this.Phanhoichk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mobantin = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Xemphanhoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Phản hồi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Danh sách bản tin";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 477);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(568, 99);
            this.dataGridView2.TabIndex = 63;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1227, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 62;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 243);
            this.dataGridView1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "XEM BẢN TIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Chủ đề";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 70;
            // 
            // Docchk
            // 
            this.Docchk.AutoSize = true;
            this.Docchk.Location = new System.Drawing.Point(378, 15);
            this.Docchk.Name = "Docchk";
            this.Docchk.Size = new System.Drawing.Size(73, 17);
            this.Docchk.TabIndex = 71;
            this.Docchk.Text = "Chưa đọc";
            this.Docchk.UseVisualStyleBackColor = true;
            // 
            // Loc
            // 
            this.Loc.Location = new System.Drawing.Point(488, 11);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(75, 23);
            this.Loc.TabIndex = 72;
            this.Loc.Text = "Lọc";
            this.Loc.UseVisualStyleBackColor = true;
            this.Loc.Click += new System.EventHandler(this.Loc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Từ khóa";
            // 
            // Tukhoa
            // 
            this.Tukhoa.Location = new System.Drawing.Point(55, 44);
            this.Tukhoa.Name = "Tukhoa";
            this.Tukhoa.Size = new System.Drawing.Size(259, 20);
            this.Tukhoa.TabIndex = 74;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Thêm phản hồi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(330, 623);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 76;
            this.button4.Text = "Xóa phản hồi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NDphanhoi
            // 
            this.NDphanhoi.Location = new System.Drawing.Point(92, 582);
            this.NDphanhoi.Multiline = true;
            this.NDphanhoi.Name = "NDphanhoi";
            this.NDphanhoi.Size = new System.Drawing.Size(488, 35);
            this.NDphanhoi.TabIndex = 77;
            // 
            // Phanhoichk
            // 
            this.Phanhoichk.AutoSize = true;
            this.Phanhoichk.Location = new System.Drawing.Point(378, 46);
            this.Phanhoichk.Name = "Phanhoichk";
            this.Phanhoichk.Size = new System.Drawing.Size(95, 17);
            this.Phanhoichk.TabIndex = 78;
            this.Phanhoichk.Text = "Chưa phản hồi";
            this.Phanhoichk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Phanhoichk);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Docchk);
            this.groupBox1.Controls.Add(this.Loc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tukhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 73);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Nhập phản hồi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Nội dung bản tin";
            // 
            // Mobantin
            // 
            this.Mobantin.Location = new System.Drawing.Point(1093, 669);
            this.Mobantin.Name = "Mobantin";
            this.Mobantin.Size = new System.Drawing.Size(128, 41);
            this.Mobantin.TabIndex = 82;
            this.Mobantin.Text = "Mở bản tin";
            this.Mobantin.UseVisualStyleBackColor = true;
            this.Mobantin.Click += new System.EventHandler(this.Mobantin_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(593, 105);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(762, 553);
            this.axAcroPDF1.TabIndex = 83;
            // 
            // Xemphanhoi
            // 
            this.Xemphanhoi.Location = new System.Drawing.Point(959, 669);
            this.Xemphanhoi.Name = "Xemphanhoi";
            this.Xemphanhoi.Size = new System.Drawing.Size(128, 41);
            this.Xemphanhoi.TabIndex = 84;
            this.Xemphanhoi.Text = "Xem phản hồi";
            this.Xemphanhoi.UseVisualStyleBackColor = true;
            this.Xemphanhoi.Click += new System.EventHandler(this.Xemphanhoi_Click);
            // 
            // Xembantin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 722);
            this.Controls.Add(this.Xemphanhoi);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.Mobantin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NDphanhoi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Xembantin";
            this.Text = "Xembantin";
            this.Load += new System.EventHandler(this.DSbantin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox Docchk;
        private System.Windows.Forms.Button Loc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tukhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox NDphanhoi;
        private System.Windows.Forms.CheckBox Phanhoichk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Mobantin;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button Xemphanhoi;


    }
}