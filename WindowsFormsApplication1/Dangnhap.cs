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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        BUS taikhoan = new BUS();
        private void button1_Click(object sender, EventArgs e)
        {
            xulydangnhap(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                xulydangnhap();
        }

        private void xulydangnhap()
        {
            bool kiemtra = taikhoan.KTdangnhap(thUsername.Text, thPass.Text);
            GDngoai f2 = Application.OpenForms["GDngoai"] as GDngoai;
            if (kiemtra == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                f2.tk = thUsername.Text;
                f2.quyen = taikhoan.KTquyen(thUsername.Text);
                this.Close();
            }
            else
            {
                f2.quyen = 0;
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }
    }
}
