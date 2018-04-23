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
    public partial class chitietadr : Form
    {
        public chitietadr()
        {
            InitializeComponent();
        }
        private int idbaocao;
        public void laybc (int idbc)
        {
            idbaocao = idbc;
        }
        private void baocaoadr1_Load(object sender, EventArgs e)
        {
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
            textBox7.Text = idbaocao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
