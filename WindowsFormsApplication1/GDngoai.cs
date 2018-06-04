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
    public partial class GDngoai : Form
    {
        public GDngoai()
        {
            InitializeComponent();
        }
        public short quyen;
        public string tk;
        private void roundButton1_Click(object sender, EventArgs e)
        {
            GDchinh GDchinh = new GDchinh();
            xulymenu(GDchinh);
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            GDchinh2 GDchinh2 = new GDchinh2();
            GDchinh2.tk = tk;
            GDchinh2.quyen = quyen;
            xulymenu(GDchinh2);
        }

        private void GDngoai_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            //Dangnhap dangnhap = new Dangnhap();
            //dangnhap.ShowDialog();
            tk = "Admin";
            quyen = 10;
        }

        public void xulymenu(Form moform)
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
            quyen = 0;
            xulyquyen(quyen);
        }

        public void xulyquyen(short capquyen)
        {
            switch (capquyen)
            {
                case 0:
                    roundButton1.Enabled = false;
                    roundButton2.Enabled = false;
                    signoutToolStripMenuItem.Enabled = false;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = false;
                    break;

                case 1:
                    roundButton1.Enabled = false;
                    roundButton2.Enabled = true;
                    signoutToolStripMenuItem.Enabled = true;
                    qltkToolStripMenuItem.Enabled = false;
                    ttcanhanToolStripMenuItem.Enabled = true;
                    break;

                case 10:
                    roundButton1.Enabled = true;
                    roundButton2.Enabled = true;
                    signoutToolStripMenuItem.Enabled = true;
                    qltkToolStripMenuItem.Enabled = true;
                    ttcanhanToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void ttcanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
