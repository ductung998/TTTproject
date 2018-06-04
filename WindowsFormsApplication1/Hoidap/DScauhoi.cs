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
    public partial class DScauhoi : Form
    {
        public DScauhoi()
        {
            InitializeComponent();
        }
        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }
        private void DSbantin2_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GDchinh gd = Application.OpenForms["GDchinh"] as GDchinh;
            NDcauhoi dinhkem = new NDcauhoi();
            gd.xulymenu2(dinhkem);
        }
    }
}
