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
    public partial class Nhombantin : Form
    {
        public Nhombantin()
        {
            InitializeComponent();
        }
        int quyen;
        string tk;
        public nhansu dangnhap = new nhansu();
        BUS taikhoan = new BUS();

        List<nhansurutgon> danhsach1 = new List<nhansurutgon>();
        List<nhansurutgon> danhsach2 = new List<nhansurutgon>();
        public void capquyen(string ten, int quyenhan)
        {
            tk = ten;
            quyen = quyenhan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows[2].Cells[3].Value = true;
            //DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            //dataGridView4.Columns.Add(chk2);
            //chk2.HeaderText = "Hủy chọn";
            //chk2.Name = "chk2";
            //dataGridView1.Rows[2].Cells[3].Value = true;
            chuyends12();
            if (danhsach2.Count == 0)
                MessageBox.Show("Yêu cầu chọn người nhận bản tin từ danh sách", "Thông báo");
            else
                loaddatarightgrid();
            loaddataleftgrid();

        }

        private void Nhombantin_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);

            btnqua.Location = new Point(this.Width/2 - btnqua.Width/2, btnqua.Location.Y);
            
            loaddatadau();
            loaddatadsgrid();
            loaddataleftgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loaddatadau()
        {
            List<nhansu> loadnhansu = taikhoan.Loadnhansu();
            List<nhansurutgon> nsrutgon = rutgon(loadnhansu);
            dataGridView1.DataSource = nsrutgon;
            danhsach1 = nsrutgon;
            // wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Nghề nghiệp";
            dataGridView1.Columns[3].HeaderText = "Chức vụ";
            dataGridView1.Columns[4].HeaderText = "Khoa lâm sàng";
            dataGridView1.Columns[5].HeaderText = "Phòng ban";
            
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "Chọn";
            chk.Name = "chk";
            
        }

        private void loaddataleftgrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.RemoveAt(0);
            dataGridView1.DataSource = danhsach1;
            // wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Nghề nghiệp";
            dataGridView1.Columns[3].HeaderText = "Chức vụ";
            dataGridView1.Columns[4].HeaderText = "Khoa lâm sàng";
            dataGridView1.Columns[5].HeaderText = "Phòng ban";

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(chk);
            chk.HeaderText = "Chọn";
            chk.Name = "chk";
        }
        private void loaddatarightgrid()
        {
            dataGridView4.DataSource = null;
            if (dataGridView4.ColumnCount != 0)
                dataGridView4.Columns.RemoveAt(0);
            dataGridView4.DataSource = danhsach2;
            // wrap text
            dataGridView4.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView4.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].HeaderText = "Họ tên";
            dataGridView4.Columns[2].HeaderText = "Nghề nghiệp";
            dataGridView4.Columns[3].HeaderText = "Chức vụ";
            dataGridView4.Columns[4].HeaderText = "Khoa lâm sàng";
            dataGridView4.Columns[5].HeaderText = "Phòng ban";

            DataGridViewCheckBoxColumn chk2 = new DataGridViewCheckBoxColumn();
            dataGridView4.Columns.Add(chk2);
            chk2.HeaderText = "Hủy chọn";
            chk2.Name = "chk2";
        }
        private void loaddatadsgrid()
        {
            dataGridView3.DataSource = taikhoan.Laynhomall();
            // wrap text
            dataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView3.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].HeaderText = "Tên nhóm";
            dataGridView3.Columns[2].HeaderText = "Mô tả nhóm";

            dataGridView3.Columns[0].Width = 60;
            dataGridView3.Columns[1].Width = 300;
            dataGridView3.Columns[2].Width = 1212 - 260; 
        }

        private void chuyends12()
        {
            List<string> nvchuyen = new List<string>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                int cotchk = dataGridView1.Columns["chk"].Index;
                int cotmanv = dataGridView1.Columns["manv"].Index;
                
                if (Convert.ToBoolean(item.Cells[cotchk].Value))
                {
                    string chuyen = item.Cells[cotmanv].Value.ToString();
                    nvchuyen.Add(chuyen);
                    //string chuyen = danhsach1.Single(x => x.manv == item.Cells[cotmanv].Value.ToString()).manv;
                    //danhsach1.Remove(chuyen);
                    //danhsach2.Add(chuyen);
                }
            }
            foreach (string item in nvchuyen)
            {
                danhsach2.Add(danhsach1.Single(x => x.manv == item));
                danhsach1.Remove(danhsach1.Single(x => x.manv == item));
            }
                
        }

        private void chuyends21()
        {
            List<string> nvchuyen = new List<string>();
            foreach (DataGridViewRow item in dataGridView4.Rows)
            {
                int cotchk = dataGridView4.Columns["chk2"].Index;
                int cotmanv = dataGridView4.Columns["manv"].Index;

                if (Convert.ToBoolean(item.Cells[cotchk].Value))
                {
                    string chuyen = item.Cells[cotmanv].Value.ToString();
                    nvchuyen.Add(chuyen);
                    //string chuyen = danhsach1.Single(x => x.manv == item.Cells[cotmanv].Value.ToString()).manv;
                    //danhsach1.Remove(chuyen);
                    //danhsach2.Add(chuyen);
                }
            }
            foreach (string item in nvchuyen)
            {
                danhsach1.Add(danhsach2.Single(x => x.manv == item));
                danhsach2.Remove(danhsach2.Single(x => x.manv == item));
            }

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

        private void btnlai_Click(object sender, EventArgs e)
        {
            chuyends21();
            if (danhsach1.Count == 0)
                MessageBox.Show("Yêu cầu chọn người nhận bản tin cần hủy", "Thông báo");
            else
                loaddataleftgrid();
            loaddatarightgrid();
        }

        private void Xoatrang_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tennhom = textBox1.Text;
            string motanhom = textBox2.Text;
            List<int> dsnhansu = new List<int>();
            foreach (nhansurutgon item in danhsach2)
            {
                int them = taikhoan.Loadnhansu().Single(x => x.manv == item.manv).iduser;
                dsnhansu.Add(them);
            }
            taikhoan.Themnhombantin(tennhom, motanhom, dsnhansu);
            clear();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            danhsach2 = null;
            danhsach1 = null;
            dataGridView4.DataSource = null;
            loaddatadau();
            loaddatadsgrid();
            loaddataleftgrid();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dr = dataGridView3.SelectedRows[0];
            string tennhom = dr.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(string.Format("Xác nhận cập nhật {0}?", tennhom),
                "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int idnhombt = taikhoan.Laynhomall().Single(x => x.tennhom == tennhom).idnhombantin;
                List<int> dsnhansu = new List<int>();
                foreach (nhansurutgon item in danhsach2)
                {
                    int them = taikhoan.Loadnhansu().Single(x => x.manv == item.manv).iduser;
                    dsnhansu.Add(them);
                }

                taikhoan.Capnhatnhombantin(idnhombt, textBox1.Text, textBox2.Text, dsnhansu);
                clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView3.SelectedRows[0];
            string tennhom = dr.Cells[1].Value.ToString();
            int idxoa = taikhoan.Laynhomall().Single(x => x.tennhom == tennhom).idnhombantin;
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("Xóa {0}?", tennhom),
                "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    taikhoan.Xoanhombantin(idxoa);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show(@"Không thể xóa
Nhóm bản tin đang được sử dụng", "Thông báo");
            }
            finally
            {
                clear();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView3.SelectedRows[0];
            string tennhom = dr.Cells[1].Value.ToString();
                MessageBox.Show(tennhom);
            int idnhom = taikhoan.Laynhomall().Single(x => x.tennhom == tennhom).idnhombantin;
            textBox1.Text = taikhoan.Laynhom(idnhom).tennhom.ToString();
            textBox2.Text = taikhoan.Laynhom(idnhom).mota.ToString();
            danhsach1 = null;
            danhsach2 = null;
            danhsach2 = rutgon(taikhoan.Laykqnhombantin(idnhom));
            danhsach1 = rutgon(taikhoan.Laykqbtconlai(taikhoan.Laykqnhombantin(idnhom)));
            loaddataleftgrid();
            loaddatarightgrid();
        }

        private List<nhansurutgon> rutgon(List<nhansu> nhansuraw)
        {
            List<nhansurutgon> nsrutgon = new List<nhansurutgon>();
            foreach (nhansu item in nhansuraw)
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
            return nsrutgon;
        }
    }
}
