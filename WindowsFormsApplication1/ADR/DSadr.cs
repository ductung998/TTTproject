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
    public partial class DSadr : Form
    {
        public DSadr()
        {
            InitializeComponent();
        }
        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }

        private void DSphieu_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idbc = 1;
            chitietadr chitietadr = new chitietadr();
            chitietadr.laybc(idbc);
            chitietadr.TopLevel = false;
            this.Controls.Add(chitietadr);
            GDchinh.xulymenu xl = new GDchinh.xulymenu(chitietadr);
        }

        
    }
}
