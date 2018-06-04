namespace WindowsFormsApplication1
{
    partial class Duyetbantin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyetbantin));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NDykien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tukhoa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Loc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mucdocb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Guiykien = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axAcroPDF2 = new AxAcroPDFLib.AxAcroPDF();
            this.XemtruocCT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.duongdanCT = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Xemnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.duongdanNhap = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axAcroPDF3 = new AxAcroPDFLib.AxAcroPDF();
            this.Soanduyet = new System.Windows.Forms.Button();
            this.Xemduyet = new System.Windows.Forms.Button();
            this.Suaduyet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.duongdanDuyet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Hoantat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUYỆT BẢN TIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 228);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1227, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 48;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Danh sách bản tin chờ duyệt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ý kiến";
            // 
            // NDykien
            // 
            this.NDykien.Location = new System.Drawing.Point(6, 465);
            this.NDykien.Multiline = true;
            this.NDykien.Name = "NDykien";
            this.NDykien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NDykien.Size = new System.Drawing.Size(565, 195);
            this.NDykien.TabIndex = 65;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tukhoa);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Loc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.mucdocb);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(9, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 82);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // Tukhoa
            // 
            this.Tukhoa.Location = new System.Drawing.Point(59, 48);
            this.Tukhoa.Name = "Tukhoa";
            this.Tukhoa.Size = new System.Drawing.Size(278, 20);
            this.Tukhoa.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Từ khóa";
            // 
            // Loc
            // 
            this.Loc.Location = new System.Drawing.Point(437, 46);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(114, 23);
            this.Loc.TabIndex = 16;
            this.Loc.Text = "Lọc";
            this.Loc.UseVisualStyleBackColor = true;
            this.Loc.Click += new System.EventHandler(this.Loc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mức độ cấp thiết";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // mucdocb
            // 
            this.mucdocb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mucdocb.FormattingEnabled = true;
            this.mucdocb.Location = new System.Drawing.Point(437, 18);
            this.mucdocb.Name = "mucdocb";
            this.mucdocb.Size = new System.Drawing.Size(114, 21);
            this.mucdocb.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Chủ đề";
            // 
            // Guiykien
            // 
            this.Guiykien.Location = new System.Drawing.Point(1093, 669);
            this.Guiykien.Name = "Guiykien";
            this.Guiykien.Size = new System.Drawing.Size(128, 41);
            this.Guiykien.TabIndex = 66;
            this.Guiykien.Text = "Gửi ý kiến";
            this.Guiykien.UseVisualStyleBackColor = true;
            this.Guiykien.Click += new System.EventHandler(this.Guiykien_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(593, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 573);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.axAcroPDF2);
            this.tabPage1.Controls.Add(this.XemtruocCT);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.duongdanCT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tập tin chính thức";
            // 
            // axAcroPDF2
            // 
            this.axAcroPDF2.Enabled = true;
            this.axAcroPDF2.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF2.Name = "axAcroPDF2";
            this.axAcroPDF2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF2.OcxState")));
            this.axAcroPDF2.Size = new System.Drawing.Size(754, 489);
            this.axAcroPDF2.TabIndex = 80;
            // 
            // XemtruocCT
            // 
            this.XemtruocCT.Location = new System.Drawing.Point(647, 518);
            this.XemtruocCT.Name = "XemtruocCT";
            this.XemtruocCT.Size = new System.Drawing.Size(101, 23);
            this.XemtruocCT.TabIndex = 77;
            this.XemtruocCT.Text = "Xem";
            this.XemtruocCT.UseVisualStyleBackColor = true;
            this.XemtruocCT.Click += new System.EventHandler(this.XemtruocCT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Đường dẫn tập tin";
            // 
            // duongdanCT
            // 
            this.duongdanCT.Location = new System.Drawing.Point(104, 492);
            this.duongdanCT.Name = "duongdanCT";
            this.duongdanCT.ReadOnly = true;
            this.duongdanCT.Size = new System.Drawing.Size(644, 20);
            this.duongdanCT.TabIndex = 79;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.axAcroPDF1);
            this.tabPage2.Controls.Add(this.Xemnhap);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.duongdanNhap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tập tin nháp";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(754, 489);
            this.axAcroPDF1.TabIndex = 87;
            // 
            // Xemnhap
            // 
            this.Xemnhap.Location = new System.Drawing.Point(647, 518);
            this.Xemnhap.Name = "Xemnhap";
            this.Xemnhap.Size = new System.Drawing.Size(101, 23);
            this.Xemnhap.TabIndex = 84;
            this.Xemnhap.Text = "Xem";
            this.Xemnhap.UseVisualStyleBackColor = true;
            this.Xemnhap.Click += new System.EventHandler(this.Xemnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Đường dẫn tập tin";
            // 
            // duongdanNhap
            // 
            this.duongdanNhap.Location = new System.Drawing.Point(104, 492);
            this.duongdanNhap.Name = "duongdanNhap";
            this.duongdanNhap.ReadOnly = true;
            this.duongdanNhap.Size = new System.Drawing.Size(644, 20);
            this.duongdanNhap.TabIndex = 86;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.axAcroPDF3);
            this.tabPage3.Controls.Add(this.Soanduyet);
            this.tabPage3.Controls.Add(this.Xemduyet);
            this.tabPage3.Controls.Add(this.Suaduyet);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.duongdanDuyet);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(754, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tập tin duyệt";
            // 
            // axAcroPDF3
            // 
            this.axAcroPDF3.Enabled = true;
            this.axAcroPDF3.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF3.Name = "axAcroPDF3";
            this.axAcroPDF3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF3.OcxState")));
            this.axAcroPDF3.Size = new System.Drawing.Size(754, 489);
            this.axAcroPDF3.TabIndex = 87;
            // 
            // Soanduyet
            // 
            this.Soanduyet.Location = new System.Drawing.Point(433, 518);
            this.Soanduyet.Name = "Soanduyet";
            this.Soanduyet.Size = new System.Drawing.Size(101, 23);
            this.Soanduyet.TabIndex = 81;
            this.Soanduyet.Text = "Soạn";
            this.Soanduyet.UseVisualStyleBackColor = true;
            this.Soanduyet.Click += new System.EventHandler(this.Soanduyet_Click);
            // 
            // Xemduyet
            // 
            this.Xemduyet.Location = new System.Drawing.Point(647, 518);
            this.Xemduyet.Name = "Xemduyet";
            this.Xemduyet.Size = new System.Drawing.Size(101, 23);
            this.Xemduyet.TabIndex = 84;
            this.Xemduyet.Text = "Xem trước";
            this.Xemduyet.UseVisualStyleBackColor = true;
            this.Xemduyet.Click += new System.EventHandler(this.Xemduyet_Click);
            // 
            // Suaduyet
            // 
            this.Suaduyet.Location = new System.Drawing.Point(540, 518);
            this.Suaduyet.Name = "Suaduyet";
            this.Suaduyet.Size = new System.Drawing.Size(101, 23);
            this.Suaduyet.TabIndex = 82;
            this.Suaduyet.Text = "Sửa";
            this.Suaduyet.UseVisualStyleBackColor = true;
            this.Suaduyet.Click += new System.EventHandler(this.Suaduyet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Đường dẫn tập tin";
            // 
            // duongdanDuyet
            // 
            this.duongdanDuyet.Location = new System.Drawing.Point(104, 492);
            this.duongdanDuyet.Name = "duongdanDuyet";
            this.duongdanDuyet.ReadOnly = true;
            this.duongdanDuyet.Size = new System.Drawing.Size(644, 20);
            this.duongdanDuyet.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Đường dẫn tập tin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 494);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(544, 20);
            this.textBox1.TabIndex = 69;
            // 
            // Hoantat
            // 
            this.Hoantat.Location = new System.Drawing.Point(959, 669);
            this.Hoantat.Name = "Hoantat";
            this.Hoantat.Size = new System.Drawing.Size(128, 41);
            this.Hoantat.TabIndex = 69;
            this.Hoantat.Text = "Hoàn tất";
            this.Hoantat.UseVisualStyleBackColor = true;
            this.Hoantat.Click += new System.EventHandler(this.Hoantat_Click);
            // 
            // Duyetbantin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 722);
            this.Controls.Add(this.Hoantat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Guiykien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NDykien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Duyetbantin";
            this.Text = "Duyet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NDykien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Loc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox mucdocb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Tukhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Guiykien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Hoantat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF2;
        private System.Windows.Forms.Button XemtruocCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duongdanCT;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button Xemnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox duongdanNhap;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF3;
        private System.Windows.Forms.Button Soanduyet;
        private System.Windows.Forms.Button Xemduyet;
        private System.Windows.Forms.Button Suaduyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duongdanDuyet;
    }
}