using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Microsoft.Office.Interop.Word;


namespace WindowsFormsApplication1
{
    public partial class Duyetbantin : Form
    {
        public Duyetbantin()
        {
            InitializeComponent();
        }
        int quyen;
        string tk;
        public nhansu dangnhap = new nhansu();
        BUS taikhoan = new BUS();

        public void capquyen(string ten, int quyenhan)
        {
            tk = ten;
            quyen = quyenhan;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Age");
            //dt.Rows.Add(new object[] { "http://tungsto03.000webhostapp.com/test2/getfile.php", "33AgeVeryLooooooooooooooooooooong" });
            //dt.Rows.Add(new object[] { "http://tungsto03.000webhostapp.com/getdata/datarequest.php", "44AgeVeryLooooooooooooooooooooong" });
            //dataGridView2.DataSource = dt;

            //dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView2.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView2.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //dataGridView1.AutoResizeRow(1, DataGridViewAutoSizeRowMode.AllCells);
            //webBrowser1.Navigate(new Uri("google.com"));

            int i = 1366 / 2 - label1.Size.Width / 2;
            label1.Location = new System.Drawing.Point(i, 23);
            List<string> chude = new List<string>();
            chude.Add("Mọi chủ đề");
            foreach (bantin_chude item in taikhoan.Laychude())
            {
                chude.Add(item.tenchude);
            }
            comboBox1.DataSource = chude;
            mucdocb.DataSource = new List<string>() { "Bình thường", "Quan trọng" };
            loaddata(taikhoan.Laybantinduyet());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loaddata(List<bantin> bantinraw)
        {
            List<bantinduyetrutgon> dsbantinrutgon = new List<bantinduyetrutgon>();
            foreach (bantin item in bantinraw)
            {
                string tinhtrangduyet = (item.tinhtrangduyet == "CD") ? "Chờ duyệt" : "Có ý kiến";

                bantinduyetrutgon bt = new bantinduyetrutgon(string.Format("BT{0:0000}", item.idbantin),
                    item.tieude, tinhtrangduyet, taikhoan.Laytaikhoan2(item.iduser).hoten, item.ngaysoan, item.hinhthuc);
                dsbantinrutgon.Add(bt);
            }
            dataGridView1.DataSource = dsbantinrutgon;
            //wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].HeaderText = "Mã bản tin";
            dataGridView1.Columns[1].HeaderText = "Tiêu đề";
            dataGridView1.Columns[2].HeaderText = "Chủ đề";
            dataGridView1.Columns[3].HeaderText = "Người soạn";
            dataGridView1.Columns[4].HeaderText = "Ngày soạn";
            dataGridView1.Columns[5].HeaderText = "Hình thức soạn";
        }

        private void Loc_Click(object sender, EventArgs e)
        {
            int chude1;
            if (comboBox1.Text == "Mọi chủ đề")
                chude1 = 0;
            else
                chude1 = taikhoan.Laychude().Single(x => x.tenchude == comboBox1.Text).idchude;
            if (mucdocb.Text == "Mọi mức độ")
                loaddata(taikhoan.Locbantinduyet2(chude1, Tukhoa.Text));
            else
                loaddata(taikhoan.Locbantinduyet1(chude1, Tukhoa.Text, (mucdocb.Text == "Bình thường") ? 'B' : 'C'));
        }

        private void XemtruocCT_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            axAcroPDF2.src = bantinmo.duongdanCT.Replace(".docx", ".pdf");
        }

        private void Xemnhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            axAcroPDF1.src = bantinmo.duongdanNhap.Replace(".docx", ".pdf");
        }

        private void Xemduyet_Click(object sender, EventArgs e)
        {
            if (duongdanDuyet.Text.Length == 0)
            {
                MessageBox.Show("Tập tin duyệt chưa được tạo", "Thông báo");
            }
            else
            {
                Soanbantin soan = new Soanbantin();

                Converttopdf(duongdanDuyet.Text, duongdanDuyet.Text.Substring(duongdanDuyet.Text.LastIndexOf(@"\") + 1,
                    duongdanDuyet.Text.Length - duongdanDuyet.Text.LastIndexOf(@"\") - 1));
            }
            axAcroPDF3.src = duongdanDuyet.Text.Replace(".docx", ".pdf");
        }

        private void Soanduyet_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = false;

            //Lấy bản tin chính thức
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            string path = bantinmo.duongdanCT;
            //Sao chép + tạo mới
            object sFileName = path;
            object path2 = path.Replace("CT", "D");
            object oMissing = System.Reflection.Missing.Value;

            Document document = word.Documents.Open(sFileName);

            document.SaveAs2(ref path2, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            ((_Document)document).Close(ref saveChanges, ref oMissing, ref oMissing);
            word.Visible = true;
            Document document2 = word.Documents.Open(path2);
            duongdanDuyet.Text = path2.ToString();
        }

        private void Suaduyet_Click(object sender, EventArgs e)
        {
            if (duongdanDuyet.Text.Length == 0|duongdanDuyet.Text == "Tập tin duyệt chưa được tạo")
            {
                MessageBox.Show("Cần tạo tập tin duyệt trước", "Thông báo");
            }
            else
            {
                object path2 = duongdanDuyet.Text;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = true;
                Document document = word.Documents.Open(path2);
            }
        }

        private void Converttopdf(string duongdan, string tenfile) //COnver docx -> pdf
        {
            //Chuyển word thành pdf
            string path = duongdanCT.Text.Substring(0, duongdanCT.Text.LastIndexOf(@"\"));
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object oMissing = System.Reflection.Missing.Value;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] wordFiles = dirInfo.GetFiles(tenfile);

            word.Visible = false;
            word.ScreenUpdating = false;

            foreach (FileInfo wordFile in wordFiles)
            {
                // Cast as Object for word Open method
                Object filename = (Object)wordFile.FullName;

                // Use the dummy value as a placeholder for optional arguments
                Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();

                object outputFileName = wordFile.FullName.Replace(".docx", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;

                // Save document into PDF Format
                doc.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                // Close the Word document, but leave the Word application open.
                // doc has to be cast to type _Document so that it will find the
                // correct Close method.                
                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;
            }

            // word has to be cast to type _Application so that it will find
            // the correct Quit method.
            ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
            word = null;
        }

        private void Guiykien_Click(object sender, EventArgs e)
        {
            string noidungykien = "";
            if (NDykien.Text.Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập nội dung ý kiến", "Thông báo");
            }
            else
            {
                noidungykien = NDykien.Text;
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                string Mabantin = dr.Cells[0].Value.ToString();
                int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
                bantin bantinmo = taikhoan.Laybantin(idbantin);

                int iduser = taikhoan.Laytaikhoan(tk).iduser;
                DateTime ngaygui = DateTime.Now;
                string duongdanD = (duongdanDuyet.Text == "Tập tin duyệt chưa được tạo") ? null : duongdanDuyet.Text;
                if (duongdanD == null)
                {
                    taikhoan.Luuykienduyet(idbantin, iduser, noidungykien, ngaygui);
                    MessageBox.Show("Ý kiến đã được gửi đi", "Thông báo");
                }
                else
                {
                    taikhoan.Luuykienduyet2(idbantin, iduser, noidungykien, ngaygui, duongdanD);
                    MessageBox.Show("Ý kiến và Tập tin duyệt đã được gửi đi", "Thông báo");
                }
            }
            
        }

        private void Hoantat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận duyệt hoàn tất bản tin", "Thông báo",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                string Mabantin = dr.Cells[0].Value.ToString();
                int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
                taikhoan.Duyetbantin(idbantin);
            }
            loaddata(taikhoan.Laybantinduyet());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string Mabantin = dr.Cells[0].Value.ToString();
            int idbantin = int.Parse(Mabantin.Substring(Mabantin.LastIndexOf("T") + 1, 4));
            bantin bantinmo = taikhoan.Laybantin(idbantin);
            duongdanCT.Text = bantinmo.duongdanCT;
            duongdanNhap.Text = bantinmo.duongdanNhap;
            duongdanDuyet.Text = (bantinmo.duongdanDuyet == null) ? "Tập tin duyệt chưa được tạo" : bantinmo.duongdanDuyet;
        }
    }
}
