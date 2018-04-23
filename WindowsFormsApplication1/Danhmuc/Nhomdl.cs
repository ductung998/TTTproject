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
    public partial class Nhomdl : Form
    {
        public Nhomdl()
        {
            InitializeComponent();
        }
        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }

        private void Nhomdl_Load(object sender, EventArgs e)
        {
            if (quyen == false) {
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
            }
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
