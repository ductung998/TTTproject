﻿using System;
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
    public partial class KQXN : Form
    {
        public KQXN()
        {
            InitializeComponent();
        }

        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }

        private void KhoaLS1_Load(object sender, EventArgs e)
        {
                
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
