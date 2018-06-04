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
    public partial class baocaoadr1 : Form
    {
        public baocaoadr1()
        {
            InitializeComponent();
        }
        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }
        private void baocaoadr1_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }
    }
}
