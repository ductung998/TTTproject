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
    public partial class GDchinh2 : Form
    {
        public GDchinh2()
        {
            InitializeComponent();
        }
        public short quyen;
        public string tk;
        private void GDchinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            xulyquyen(quyen);
            
        }
        #region Thanh công cụ
        private void dskhoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoaLS khoals = new KhoaLS();
            khoals.capquyen(tk, quyen);
            xulymenu2(khoals);
        }
        private void dspbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongban phongban = new Phongban();
            phongban.capquyen(tk, quyen);
            xulymenu2(phongban);
        }
        private void dsnhansuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhansu Nhansu = new Nhansu();
            Nhansu.capquyen(tk, quyen);
            xulymenu2(Nhansu);
        }

        private void xemTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xembantin Xembantin = new Xembantin();
            Xembantin.capquyen(tk, quyen);
            xulymenu2(Xembantin);
        }

        private void soanTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soanbantin Soanbantin = new Soanbantin();
            Soanbantin.capquyen(tk, quyen);
            xulymenu2(Soanbantin);
        }

        private void dsTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSbantin DSbantin = new DSbantin();
            DSbantin.capquyen(tk, quyen);
            xulymenu2(DSbantin);
        }

        private void duyetTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duyetbantin Duyetbantin = new Duyetbantin();
            Duyetbantin.capquyen(tk, quyen);
            xulymenu2(Duyetbantin);
        }

        private void hddatcauhoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Themcauhoi Themcauhoi = new Themcauhoi();
            Themcauhoi.capquyen(tk, quyen);
            xulymenu2(Themcauhoi);
        }

        private void dshoidapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DScauhoi DScauhoi = new DScauhoi();
            DScauhoi.capquyen(tk, quyen);
            xulymenu2(DScauhoi);
        }

        private void tkTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongkebantin thongkebantin = new thongkebantin();
            thongkebantin.capquyen(tk, quyen);
            xulymenu2(thongkebantin);
        }

        private void tkhoidapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongkehoidap thongkehoidap = new thongkehoidap();
            xulymenu2(thongkehoidap);
        }

        private void nhombantinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhombantin Nhombantin = new Nhombantin();
            Nhombantin.capquyen(tk, quyen);
            xulymenu2(Nhombantin);
        }
        
        private void ChudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chude Chude = new Chude();
            Chude.capquyen(tk, quyen);
            xulymenu2(Chude);
        }

        private void qltkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlytk quanlytk = new quanlytk();
            xulymenu2(quanlytk);
        }

        private void ttcanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công", "Thông báo");
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "GDngoai")
                {
                    Application.OpenForms[i].Close();
                }
            }
            GDngoai gdngoai = Application.OpenForms["GDngoai"] as GDngoai;
            gdngoai.xulyquyen(0);
            this.Close();
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
                    menuTTTToolStripMenuItem.Enabled = false;
                    menudanhmucToolStripMenuItem.Enabled = false;
                    signoutToolStripMenuItem.Enabled = false;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = false;
                    break;

                case 1:
                    menuADRToolStripMenuItem.Enabled = false;
                    menuTTTToolStripMenuItem.Enabled = true;
                    menudanhmucToolStripMenuItem.Enabled = true;
                    signoutToolStripMenuItem.Enabled = true;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = true;
                    break;

                case 10:
                    GDchinh panel = Application.OpenForms["GDchinh2"] as GDchinh;
                    
                    foreach (ToolStripMenuItem item in (menuStrip1.Items))
                    {
                        foreach (ToolStripItem e in item.DropDownItems)
                            e.Enabled = true;
                        
                        item.Enabled = true;
                    }
                    break;
            }
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
