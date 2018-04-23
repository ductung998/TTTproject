using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;


namespace WindowsFormsApplication1
{
    public partial class Duyetbantin : Form
    {
        public Duyetbantin()
        {
            InitializeComponent();
        }
        bool quyen;
        public void capquyen(string ten, int quyenhan)
        {
            quyen = (quyenhan > 9) ? true : false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Rows.Add(new object[] { "http://tungsto03.000webhostapp.com/test2/getfile.php", "33AgeVeryLooooooooooooooooooooong" });
            dt.Rows.Add(new object[] { "http://tungsto03.000webhostapp.com/getdata/datarequest.php", "44AgeVeryLooooooooooooooooooooong" });
            //dataGridView2.DataSource = dt;

            //dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView2.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView2.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView1.AutoResizeRow(1, DataGridViewAutoSizeRowMode.AllCells);
            //webBrowser1.Navigate(new Uri("google.com"));
            checkBox1.Checked = true;
            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new Point(i, 23);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
