namespace WindowsFormsApplication1
{
    partial class DSbantin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSbantin));
            this.label11 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ykien = new System.Windows.Forms.TextBox();
            this.Suabantin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Mobantinduyet = new System.Windows.Forms.Button();
            this.duongdanDuyet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label3 = new System.Windows.Forms.Label();
            this.Xemykien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tinhtrang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Ý kiến của người duyệt";
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(1227, 669);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(128, 41);
            this.Thoat.TabIndex = 60;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 182);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "DANH SÁCH BẢN TIN PHẢN HỒI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ykien
            // 
            this.Ykien.Location = new System.Drawing.Point(12, 377);
            this.Ykien.Multiline = true;
            this.Ykien.Name = "Ykien";
            this.Ykien.ReadOnly = true;
            this.Ykien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Ykien.Size = new System.Drawing.Size(568, 273);
            this.Ykien.TabIndex = 66;
            // 
            // Suabantin
            // 
            this.Suabantin.Location = new System.Drawing.Point(1093, 669);
            this.Suabantin.Name = "Suabantin";
            this.Suabantin.Size = new System.Drawing.Size(128, 41);
            this.Suabantin.TabIndex = 1;
            this.Suabantin.Text = "Sửa bản tin";
            this.Suabantin.UseVisualStyleBackColor = true;
            this.Suabantin.Click += new System.EventHandler(this.Suabantin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(593, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 573);
            this.tabControl1.TabIndex = 70;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Mobantinduyet);
            this.tabPage3.Controls.Add(this.duongdanDuyet);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.axAcroPDF1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(754, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tập tin duyệt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Mobantinduyet
            // 
            this.Mobantinduyet.Location = new System.Drawing.Point(650, 518);
            this.Mobantinduyet.Name = "Mobantinduyet";
            this.Mobantinduyet.Size = new System.Drawing.Size(101, 23);
            this.Mobantinduyet.TabIndex = 23;
            this.Mobantinduyet.Text = "Xem";
            this.Mobantinduyet.UseVisualStyleBackColor = true;
            this.Mobantinduyet.Click += new System.EventHandler(this.Mobantinduyet_Click);
            // 
            // duongdanDuyet
            // 
            this.duongdanDuyet.Location = new System.Drawing.Point(78, 520);
            this.duongdanDuyet.Name = "duongdanDuyet";
            this.duongdanDuyet.ReadOnly = true;
            this.duongdanDuyet.Size = new System.Drawing.Size(566, 20);
            this.duongdanDuyet.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tập tin duyệt";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(754, 512);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Danh sách bản tin";
            // 
            // Xemykien
            // 
            this.Xemykien.Location = new System.Drawing.Point(959, 669);
            this.Xemykien.Name = "Xemykien";
            this.Xemykien.Size = new System.Drawing.Size(128, 41);
            this.Xemykien.TabIndex = 74;
            this.Xemykien.Text = "Xem ý kiến";
            this.Xemykien.UseVisualStyleBackColor = true;
            this.Xemykien.Click += new System.EventHandler(this.Xemykien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Tình trạng bản tin";
            // 
            // tinhtrang
            // 
            this.tinhtrang.FormattingEnabled = true;
            this.tinhtrang.Location = new System.Drawing.Point(108, 86);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(365, 21);
            this.tinhtrang.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSbantin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tinhtrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Xemykien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Suabantin);
            this.Controls.Add(this.Ykien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "DSbantin";
            this.Text = "Suabantin";
            this.Activated += new System.EventHandler(this.DSbantin_Activated);
            this.Load += new System.EventHandler(this.DSbantin3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ykien;
        private System.Windows.Forms.Button Suabantin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox duongdanDuyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Xemykien;
        private System.Windows.Forms.Button Mobantinduyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tinhtrang;
        private System.Windows.Forms.Button button1;
    }
}