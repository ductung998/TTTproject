using System;
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
    public partial class DSbantin : Form
    {
        public DSbantin()
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
        private void DSbantin3_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
            tinhtrang.DataSource = new List<string>() { "Chưa duyệt", "Đã duyệt", "Đã soạn" };
            tinhtrang.Text = "Chưa duyệt";
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSbantin_Activated(object sender, EventArgs e)
        {
            
        }

        private void loaddata()
        {
            List<bantinrutgon> dsbantinrutgon = new List<bantinrutgon>();
            if (tinhtrang.Text == "Chưa duyệt")
            {
                List<bantin> dsbantin = taikhoan.Laybantinduyet();
                foreach (bantin item in dsbantin)
                {
                    string TTduyet = (item.tinhtrangduyet == "CD") ? "Chờ duyệt" : (item.tinhtrangduyet == "YK") ? "Có ý kiến" : "Khác";

                    bantinrutgon bt = new bantinrutgon(string.Format("BT{0:0000}", item.idbantin),
                        item.tieude, TTduyet, item.ngaysoan);
                    dsbantinrutgon.Add(bt);
                }
            }
            else if (tinhtrang.Text == "Đã duyệt")
            {
                List<bantin> dsbantin = taikhoan.Laybantindaduyet();
                foreach (bantin item in dsbantin)
                {
                    string TTduyet = (item.tinhtrangduyet == "DD") ? "Đã duyệt" : "Khác";

                    bantinrutgon bt = new bantinrutgon(string.Format("BT{0:0000}", item.idbantin),
                        item.tieude, TTduyet, item.ngaysoan);
                    dsbantinrutgon.Add(bt);
                }
            }
            else
            {
                List<bantin> dsbantin = taikhoan.Laybantinsoan(taikhoan.Laytaikhoan(tk).iduser);
                foreach (bantin item in dsbantin)
                {
                    string TTduyet = (item.tinhtrangduyet == "CD") ? "Chờ duyệt" : (item.tinhtrangduyet == "YK") ? "Có ý kiến" : "Đã duyệt";

                    bantinrutgon bt = new bantinrutgon(string.Format("BT{0:0000}", item.idbantin),
                        item.tieude, TTduyet, item.ngaysoan);
                    dsbantinrutgon.Add(bt);
                }
            }

            

            dataGridView1.DataSource = dsbantinrutgon;
            // wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].HeaderText = "Mã bản tin";
            dataGridView1.Columns[1].HeaderText = "Tiêu đề";
            dataGridView1.Columns[2].HeaderText = "Tình trạng duyệt";
            dataGridView1.Columns[3].HeaderText = "Ngày soạn";

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 292;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
        }

        private void Xemykien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            string ndykien = "";
            int dem = 0;
            if (taikhoan.Layykien(idbantin).Count == 0)
            {
                ndykien = "Bản tin chưa có ý kiến";
            }
            else
            {
                foreach (bantin_ykien_duyet item in taikhoan.Layykien(idbantin))
                {
                    dem += 1;
                    nhansu nguoiviet = taikhoan.Laytaikhoan2(item.iduser);
                    ndykien += string.Format("Thời gian: {1:hh} giờ, {2:mm} phút, ngày {3:dd/MM/yyyy}", dem.ToString(), item.ngay, item.ngay, item.ngay);
                    ndykien += string.Format("\r\nÝ kiến {0}:", dem);
                    ndykien += string.Format("\r\n{0}", item.noidung.ToString());
                    ndykien += string.Format("\r\n{0}", nguoiviet.hoten);
                    ndykien += "\r\n" + "----------" + "\r\n";
                }
            }
            Ykien.Text = ndykien;
        }

        private void Mobantinduyet_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            axAcroPDF1.src = bantinmo.duongdanDuyet.Replace(".docx", ".pdf");
        }

        private void Suabantin_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));

            Suabantin suabantin = new Suabantin();
            suabantin.capquyen(tk, quyen);
            suabantin.mobantin(idbantin);
            GDchinh2 Gd = System.Windows.Forms.Application.OpenForms["Gdchinh2"] as GDchinh2;
            Gd.xulymenu2(suabantin);
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            duongdanDuyet.Text = (bantinmo.duongdanDuyet == null) ? "Tập tin duyệt không tồn tại" : bantinmo.duongdanDuyet;
            if (duongdanDuyet.Text.Length > 0 && duongdanDuyet.Text != "Tập tin duyệt không tồn tại")
                Mobantinduyet.Enabled = true;
            else
                Mobantinduyet.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        
    }
    public class bantinrutgon
    {
        public string mabantin { get; set; }
        public string tieude { get; set; }
        public string tinhtrangduyet { get; set; }
        public DateTime ngaysoan { get; set; }

        public bantinrutgon(string Mabantin, string Tieude, string TTDuyet, DateTime Ngaysoan)
        {
            mabantin = Mabantin;
            tieude = Tieude;
            tinhtrangduyet = TTDuyet;
            ngaysoan = Ngaysoan;
        }

    }

    public class bantinduyetrutgon
    {
        public string mabantin { get; set; }
        public string tieude { get; set; }
        public string tinhtrangduyet { get; set; }
        public string nguoisoan { get; set; }
        public DateTime ngaysoan { get; set; }

        public string hinhthuc { get; set; }

        public bantinduyetrutgon(string Mabantin, string Tieude, string TTDuyet, string Nguoisoan, DateTime Ngaysoan, string Hinhthuc)
        {
            mabantin = Mabantin;
            tieude = Tieude;
            tinhtrangduyet = TTDuyet;
            nguoisoan = Nguoisoan;
            ngaysoan = Ngaysoan;
            hinhthuc = Hinhthuc;
        }
    }
}
