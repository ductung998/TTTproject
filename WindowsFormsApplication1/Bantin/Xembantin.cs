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
    public partial class Xembantin : Form
    {
        public Xembantin()
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
        private void DSbantin2_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
            List<string> chude = new List<string>();
            chude.Add("Mọi chủ đề");
            foreach (bantin_chude item in taikhoan.Laychude())
            {
                chude.Add(item.tenchude);
            }
            comboBox1.DataSource = chude;
            loaddata(taikhoan.Laybantinxem(taikhoan.Laytaikhoan(tk).iduser));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loc_Click(object sender, EventArgs e)
        {
            int chude1;
            if (comboBox1.Text == "Mọi chủ đề")
                chude1 = 0;
            else
                chude1 = taikhoan.Laychude().Single(x => x.tenchude == comboBox1.Text).idchude;
            int iduser = taikhoan.Laytaikhoan(tk).iduser;

            if (Docchk.Checked == true || Phanhoichk.Checked == true)
                loaddata(taikhoan.Locbantin2(chude1, Tukhoa.Text, !Docchk.Checked, !Phanhoichk.Checked, iduser));
            else
                loaddata(taikhoan.Locbantin1(chude1, Tukhoa.Text, iduser));
        }
        public void loaddata(List<bantin> bantinraw)
        {
            List<bantinrutgon> dsbantinrutgon = new List<bantinrutgon>();
            foreach (bantin item in bantinraw)
            {
                string chude = taikhoan.Laychude().Single(x => x.idchude == item.idchude).tenchude;

                bantinrutgon bt = new bantinrutgon(string.Format("BT{0:0000}", item.idbantin),
                    item.tieude, chude, item.ngaysoan);
                dsbantinrutgon.Add(bt);
            }
            
            dataGridView1.DataSource = dsbantinrutgon;
            //wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].HeaderText = "Mã bản tin";
            dataGridView1.Columns[1].HeaderText = "Tiêu đề";
            dataGridView1.Columns[2].HeaderText = "Chủ đề";
            dataGridView1.Columns[3].HeaderText = "Ngày soạn";
            // sửa width
            dataGridView1.Columns[0].Width = 90;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 90;
        }
        

        private void Xemphanhoi_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            List<bantin_phanhoi_doc> phanhoiraw = taikhoan.Layphanhoi(idbantin);

            Loadphanhoi(phanhoiraw);
        }

        private void Mobantin_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            axAcroPDF1.src = bantinmo.duongdanCT.Replace(".docx", ".pdf");
            taikhoan.Xembantin(idbantin, taikhoan.Laytaikhoan(tk).iduser);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            string phanhoi;
            if (NDphanhoi.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập phản hồi", "Thông báo");
            else
            {
                phanhoi = NDphanhoi.Text;
                int iduser = taikhoan.Laytaikhoan(tk).iduser;
                DateTime thoigian = DateTime.Now;
                taikhoan.Themphanhoi(idbantin, iduser, phanhoi, thoigian);
            }

            List<bantin_phanhoi_doc> phanhoiraw = taikhoan.Layphanhoi(idbantin);
            Loadphanhoi(phanhoiraw);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            DataGridViewRow dr2 = dataGridView2.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            string nguoiph = dr2.Cells[0].Value.ToString();
            string noidungph = dr2.Cells[1].Value.ToString();

            string nguoidung = taikhoan.Laytaikhoan(tk).hoten;
            int iduser = taikhoan.Laytaikhoan(tk).iduser;
            
            if (nguoiph != nguoidung|quyen != 10)
                MessageBox.Show("Bạn không được phép xóa phản hồi này", "Thông báo");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xóa phản hồi của bạn", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    taikhoan.Xoaphanhoi(idbantin, iduser, noidungph);
            }
            List<bantin_phanhoi_doc> phanhoiraw = taikhoan.Layphanhoi(idbantin);
            Loadphanhoi(phanhoiraw);
        }

        public class bantinrutgon
        {
            public string mabantin { get; set; }
            public string tieude { get; set; }
            public string chude { get; set; }
            public DateTime ngaysoan { get; set; }

            public bantinrutgon(string Mabantin, string Tieude, string Chude, DateTime Ngaysoan)
            {
                mabantin = Mabantin;
                tieude = Tieude;
                chude = Chude;
                ngaysoan = Ngaysoan;
            }

        }

        public class phanhoirutgon
        {
            public string ten { get; set; }
            public string noidung { get; set; }
            public DateTime ngayphanhoi { get; set; }

            public phanhoirutgon(string Ten, string Noidung, DateTime Ngayphanhoi)
            {
                ten = Ten;
                noidung = Noidung;
                ngayphanhoi = Ngayphanhoi;
            }

        }

        public void Loadphanhoi(List<bantin_phanhoi_doc> phanhoiraw)
        {
            List<phanhoirutgon> dsphanhoirutgon = new List<phanhoirutgon>();
            foreach (bantin_phanhoi_doc item in phanhoiraw)
            {
                string ten = taikhoan.Laytaikhoan2(item.iduser).hoten;
                string noidungph = (item.xoa == false) ? item.noidung : "Phản hồi đã bị xóa";


                phanhoirutgon bt = new phanhoirutgon(ten, noidungph, item.ngaygio);
                dsphanhoirutgon.Add(bt);
            }
            
            dataGridView2.DataSource = dsphanhoirutgon;
            //wrap text
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView2.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView2.Columns[0].HeaderText = "Họ tên";
            dataGridView2.Columns[1].HeaderText = "Nội dung phản hồi";
            dataGridView2.Columns[2].HeaderText = "Thời điểm phản hồi";
            // Đổi màu
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 300;
            dataGridView2.Columns[2].Width = 120;
        }
    }
}
