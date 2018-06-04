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
    public partial class Nhansu : Form
    {
        public Nhansu()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhansu_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
            //Load nghề nghiệp
            List<string> nghe = new List<string>() { "Bác sĩ", "Dược sĩ", "Điều dưỡng", "Kỹ thuật viên" };
            cbnghe.DataSource = nghe.Union(taikhoan.Loadnghe()).ToList();
            cbnghe.Text = "";
            //Load chức vụ
            List<string> chucvu = new List<string>() { "Trưởng khoa", "Phó khoa", "Trưởng phòng", "Phó phòng" };
            cbchucvu.DataSource = chucvu.Union(taikhoan.Loadchucvu()).ToList();
            cbchucvu.Text = "";
            //Load Khoa
            List<string> khoals = new List<string>();
            foreach (khoa item in taikhoan.Loadkhoa())
            {
                khoals.Add(item.ten);
            }
            cbkhoa.DataSource = khoals;
            cbkhoa.Text = "";
            //Load phòng ban
            List<string> loadphongban = new List<string>();
            foreach (phongban item in taikhoan.Loadphongban())
            {
                loadphongban.Add(item.ten);
            }
            cbpb.DataSource = loadphongban;
            cbpb.Text = "";
            loaddata();
        }

        private void loaddata()
        {
            List<nhansu> loadnhansu = taikhoan.Loadnhansu();
            List<nhansurutgon> nsrutgon = new List<nhansurutgon>();
            foreach (nhansu item in loadnhansu)
            {
                nhansurutgon tk = new nhansurutgon("", "", "", "", "", "");
                tk.ten = item.hoten;
                tk.manv = item.manv;
                tk.nghe = item.nghenghiep;
                
                if (item.idphongban != null)
                    tk.pb = taikhoan.Layphongban(item.idphongban);
                
                tk.chucvu = item.chucvu;

                if (item.idkhoa != null)
                    tk.khoa = taikhoan.Laykhoa(item.idkhoa);

                nsrutgon.Add(tk);
            }
            dataGridView1.DataSource = nsrutgon;
            // wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Nghề nghiệp";
            dataGridView1.Columns[3].HeaderText = "Chức vụ";
            dataGridView1.Columns[4].HeaderText = "Khoa lâm sàng";
            dataGridView1.Columns[5].HeaderText = "Phòng ban";
            //for (int i = 7; i < 14; i++)
            //{
            //    dataGridView1.Columns[i].Visible = false;
            //}

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            manv.Text = dr.Cells[0].Value.ToString();
            ten.Text = dr.Cells[1].Value.ToString();
            cbnghe.Text = (dr.Cells[2].Value == null) ? "" : dr.Cells[2].Value.ToString();
            cbchucvu.Text = (dr.Cells[3].Value == null) ? "" : dr.Cells[3].Value.ToString();
            cbkhoa.Text = (dr.Cells[4].Value == null) ? "" : dr.Cells[4].Value.ToString();
            cbpb.Text = (dr.Cells[5].Value == null) ? "" : dr.Cells[5].Value.ToString();
            email.Text = taikhoan.Loadnhansu().Single(x => x.manv == dr.Cells[0].Value.ToString()).email;
            sdt.Text = taikhoan.Loadnhansu().Single(x => x.manv == dr.Cells[0].Value.ToString()).sdt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool tontai = false;
            foreach (nhansu item in taikhoan.Loadnhansu())
            {
                if (item.manv == manv.Text)
                    tontai = true;
            }
            if (tontai)
                MessageBox.Show("Nhân viên đã tồn tại", "Thông báo");
            else
            {
                short idkhoa = (cbkhoa.Text == "") ? short.Parse("0") : taikhoan.Loadkhoa().Single(x => x.ten == cbkhoa.Text).idkhoa;
                short idpb = (cbpb.Text == "") ? short.Parse("0") : taikhoan.Loadphongban().Single(x => x.ten == cbpb.Text).idphongban;

                taikhoan.Themnhansu(ten.Text, manv.Text, idkhoa, idpb, cbnghe.Text, cbchucvu.Text, email.Text, sdt.Text, manv.Text);
                MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo");
                clear();
                loaddata();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            nhansurutgon nscu = new nhansurutgon(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(),
                (dr.Cells[2].Value == null) ? "" : dr.Cells[2].Value.ToString(),
                (dr.Cells[3].Value == null) ? "" : dr.Cells[3].Value.ToString(),
                (dr.Cells[4].Value == null) ? "" : dr.Cells[4].Value.ToString(),
                (dr.Cells[5].Value == null) ? "" : dr.Cells[5].Value.ToString());
            nhansurutgon nsmoi = new nhansurutgon(manv.Text, ten.Text, cbnghe.Text, cbchucvu.Text, cbkhoa.Text, cbpb.Text);

            DialogResult dialogResult = MessageBox.Show(string.Format("Xác nhận cập nhật thông tin nhân sự {0}?", nscu.ten),
                "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int iduser =taikhoan.Loadnhansu().Single(x=>x.manv == nscu.manv).iduser;

                short idkhoa = (cbkhoa.Text == "") ? short.Parse("0") : taikhoan.Loadkhoa().Single(x => x.ten == nsmoi.khoa).idkhoa;
                short idpb = (cbpb.Text == "") ? short.Parse("0") : taikhoan.Loadphongban().Single(x => x.ten == nsmoi.pb).idphongban;

                taikhoan.Capnhatnhansu(iduser, nsmoi.ten, nsmoi.manv, idkhoa, idpb,
                    nsmoi.nghe, nsmoi.chucvu, email.Text, sdt.Text, manv.Text);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            clear();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            int idxoa = taikhoan.Loadnhansu().Single(x => x.manv == dr.Cells[0].Value.ToString()).iduser;
            string tenxoa = dr.Cells[0].Value.ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Xóa nhân viên {0}?", tenxoa),
                "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    taikhoan.Xoanhansu(idxoa);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa", "Lỗi");
            }
            finally
            {
                clear();
                loaddata();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
            loaddata();
        }
        public void clear()
        {
            ten.Text = "";
            manv.Text = "";
            cbchucvu.Text = "";
            cbkhoa.Text = "";
            cbnghe.Text = "";
            cbpb.Text = "";
            sdt.Text = "";
            email.Text = "";
        }
        public class nhansurutgon
        {
            public string manv { get; set; }
            public string ten { get; set; }
            public string nghe { get; set; }
            public string chucvu { get; set; }
            public string khoa { get; set; }
            public string pb { get; set; }

            public nhansurutgon(string Manv, string Ten, string Nghe, string Chucvu, string Khoa, string Pb)
            {
                manv = Manv;
                ten = Ten;
                nghe = Nghe;
                chucvu = Chucvu;
                khoa = Khoa;
                pb = Pb;
                
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GDchinh2 gd = System.Windows.Forms.Application.OpenForms["GDchinh2"] as GDchinh2;
            KhoaLS khoals = new KhoaLS();
            khoals.capquyen(tk, quyen);
            gd.xulymenu2(khoals);
        }

        private void Nhansu_Enter(object sender, EventArgs e)
        {
            //Load Khoa
            List<string> khoals = new List<string>();
            foreach (khoa item in taikhoan.Loadkhoa())
            {
                khoals.Add(item.ten);
            }
            cbkhoa.DataSource = khoals;
            //Load phòng ban
            List<string> phongban = new List<string>();
            foreach (phongban item in taikhoan.Loadphongban())
            {
                phongban.Add(item.ten);
            }
            cbpb.DataSource = phongban;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GDchinh2 gd = System.Windows.Forms.Application.OpenForms["GDchinh2"] as GDchinh2;
            Phongban pb = new Phongban();
            pb.capquyen(tk, quyen);
            gd.xulymenu2(pb);
        }
    }
}
