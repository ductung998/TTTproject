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
    public partial class GDchinh : Form
    {
        public GDchinh()
        {
            InitializeComponent();
        }
        public short quyen;
        private void GDchinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            //Dangnhap dangnhap = new Dangnhap();
            //dangnhap.ShowDialog();
            quyen = 10;
            xulyquyen(quyen);
            
        }
        #region Thanh công cụ
        private void dskhoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoaLS khoals = new KhoaLS();
            khoals.capquyen("Tùng", 1);
            xulymenu2(khoals);
        }
        private void dspbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongban phongban = new Phongban();
            phongban.capquyen("Tùng", 1);
            xulymenu2(phongban);
        }
        private void dsnhansuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhansu Nhansu = new Nhansu();
            Nhansu.capquyen("Tùng", 1);
            xulymenu2(Nhansu);
        }
        private void nhomdlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhomdl Nhomdl = new Nhomdl();
            Nhomdl.capquyen("Tùng", 1);
            xulymenu2(Nhomdl);
        }
        private void hcgocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoatchatgoc Hoatchatgoc = new Hoatchatgoc();
            Hoatchatgoc.capquyen("Tùng", 1);
            xulymenu2(Hoatchatgoc);
        }
        private void hcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoatchat Hoatchat = new Hoatchat();
            Hoatchat.capquyen("Tùng", 1);
            xulymenu2(Hoatchat);
        }

        private void thuocThuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuocbt Thuocbt = new Thuocbt();
            Thuocbt.capquyen("Tùng", 1);
            xulymenu2(Thuocbt);
        }

        private void KSDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KSDB KSDB = new KSDB();
            KSDB.capquyen("Tùng", 1);
            xulymenu2(KSDB);
        }

        private void xncnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XNCN XNCN = new XNCN();
            XNCN.capquyen("Tùng", 1);
            xulymenu2(XNCN);
        }

        private void benhphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benhpham Benhpham = new Benhpham();
            Benhpham.capquyen("Tùng", 1);
            xulymenu2(Benhpham);
        }

        private void vikhuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vikhuan Vikhuan = new Vikhuan();
            Vikhuan.capquyen("Tùng", 1);
            xulymenu2(Vikhuan);
        }

        private void ttbenhnhanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Benhan Benhan = new Benhan();
            Benhan.capquyen("Tùng", 1);
            xulymenu2(Benhan);
        }

        private void dsbenhnhanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KQXN KQXN = new KQXN();
            KQXN.capquyen("Tùng", 1);
            xulymenu2(KQXN);
        }

        private void nhapphieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieu PhieuSDKS = new Phieu();
            PhieuSDKS.capquyen("Tùng", 1);
            xulymenu2(PhieuSDKS);
        }

        private void duyetphieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duyetphieu Duyetphieu = new Duyetphieu();
            Duyetphieu.capquyen("Tùng", 1);
            xulymenu2(Duyetphieu);
        }

        private void themADRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaoadr1 baocaoadr1 = new baocaoadr1();
            baocaoadr1.capquyen("Tùng", 1);
            xulymenu2(baocaoadr1);
        }

        private void dsADRkhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adrkhoa adrkhoa = new adrkhoa();
            adrkhoa.capquyen("Tùng", 1);
            xulymenu2(adrkhoa);
        }

        private void dsADRallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSadr DSadr = new DSadr();
            DSadr.capquyen("Tùng", 1);
            xulymenu2(DSadr);
        }

        private void tkKSDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tkADRToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void qltkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlytk quanlytk = new quanlytk();
            xulymenu2(quanlytk);
        }

        private void signinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (quyen != 0)
            {
                MessageBox.Show("Bạn phải đăng xuất trước", "Thông báo");
            }
            else
            {
                Dangnhap dangnhap = new Dangnhap();
                dangnhap.ShowDialog();
                xulyquyen(quyen);
            }
        }
        #endregion

        

        public void xulyquyen(short capquyen)
        {
            switch (capquyen)
            {
                case 0:
                    menuADRToolStripMenuItem.Enabled = false;
                    menunhapdlToolStripMenuItem.Enabled = false;
                    menuKSDBToolStripMenuItem.Enabled = false;
                    menudanhmucToolStripMenuItem.Enabled = false;
                    signoutToolStripMenuItem.Enabled = false;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = false;
                    break;

                case 1:
                    menuADRToolStripMenuItem.Enabled = false;
                    menunhapdlToolStripMenuItem.Enabled = false;
                    menuKSDBToolStripMenuItem.Enabled = false;
                    menudanhmucToolStripMenuItem.Enabled = true;
                    signoutToolStripMenuItem.Enabled = true;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = true;
                    break;

                case 10:
                    GDchinh panel = Application.OpenForms["GDchinh"] as GDchinh;
                    
                    foreach (ToolStripMenuItem item in (menuStrip1.Items))
                    {
                        foreach (ToolStripItem e in item.DropDownItems)
                            e.Enabled = true;
                        
                        item.Enabled = true;
                    }
                    break;
            }
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công", "Thông báo");
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "GDchinh")
                {
                    Application.OpenForms[i].Close();
                }
            }
            quyen = 0;
            xulyquyen(quyen);
        }

        public void xulymenu2(Form moform)
        {
            Form fc = Application.OpenForms[moform.Text.ToString()];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                moform.TopLevel = false;
                this.Controls.Add(moform);
                moform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                moform.Dock = DockStyle.Fill;
                moform.BringToFront();
                moform.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
                
    }
}
