﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Benhpham : Form
    {
        public Benhpham()
        {
            InitializeComponent();
        }
        int quyen;
        string tk;
        public nhansu dangnhap = new nhansu();
        BUS taikhoan = new BUS();
        public void capquyen(string ten, int quyenhan)
        {
            tk = ten;
            quyen = quyenhan;
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            int i = this.Width / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loaddata()
        {
            dataGridView1.DataSource = taikhoan.Loadtenbenhpham();
            // wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Tên khoa";

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 1212 - 60;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool tontai = false;
            foreach (tenbenhpham item in taikhoan.Loadtenbenhpham())
            {
                if (item.tenbp == textBox1.Text)
                    tontai = true;
            }
            if (tontai)
                MessageBox.Show("Tên khoa lâm sàng đã tồn tại", "Thông báo");
            else
            {
                taikhoan.Themtenbenhpham(textBox1.Text);
                MessageBox.Show("Thêm khoa lâm sàng mới thành công", "Thông báo");
                loaddata();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string tencu = dr.Cells[1].Value.ToString();
            string tenmoi = textBox1.Text;
            DialogResult dialogResult = MessageBox.Show(string.Format("Cập nhật {0} thành {1}?", tencu, tenmoi),
                "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                taikhoan.Capnhattenbenhpham(tencu, tenmoi);
            }
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string tenxoa = dr.Cells[1].Value.ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Xóa {0}?", tenxoa),
                "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    taikhoan.Xoatenbenhpham(tenxoa);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show(@"Không thể xóa
                                  Tồn tại nhân sự thuộc khoa này", "Lỗi");
            }
            finally
            {
                loaddata();
            }

        }
    }
}
