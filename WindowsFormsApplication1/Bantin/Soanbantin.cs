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
using Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1
{
    public partial class Soanbantin : Form
    {
        public Soanbantin()
        {
            InitializeComponent();
        }

        int quyen;
        string tk;
        public nhansu dangnhap = new nhansu();
        BUS taikhoan = new BUS();
        List<bantin_nhom> nhomduocchon = new List<bantin_nhom>();

        List<bantin_chude> chudebantin = new List<bantin_chude>();
        
        public void capquyen(string ten, int quyenhan)
        {
            tk = ten;
            quyen = quyenhan;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int i = (1383 - label1.Size.Width) / 2;
            label1.Location = new System.Drawing.Point(i, 23);
            List<string> hinhthuc = new List<string>() {"Dịch", "Viết mới", "Nguyên văn"};
            htsoancb.DataSource = hinhthuc;

            List<string> mucdo = new List<string>() { "Bình thường", "Quan trọng"};
            mucdocb.DataSource = mucdo;
            dangnhap = taikhoan.Laytaikhoan(tk);

            nguoisoan.Text = dangnhap.hoten.ToString();
            chucvu.Text = (dangnhap.chucvu == null) ? "" : dangnhap.chucvu.ToString();
            ngaysoan.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);

            Mabantin.Text = "BT" + string.Format("{0:0000}", (int.Parse(taikhoan.Laybantincuoi().idbantin.ToString()) + 1));

            chudebantin = taikhoan.Laychude();
            List<string> dschude = new List<string>();
            foreach (bantin_chude chude1 in chudebantin)
            {
                dschude.Add(chude1.tenchude.ToString());
            }
            chudecb.DataSource = dschude;
            nhomnhancb.DataSource = taikhoan.Laytennhom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        #region Tập tin chính thức
        private void SoanCT_Click(object sender, EventArgs e)
        {

            //Tạo file word + đường dẫn
            string path = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy");
            System.IO.Directory.CreateDirectory(path);
            object path2 = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy") + @"\CT" + Mabantin.Text + ".docx";
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            object oMissing = System.Reflection.Missing.Value; 
            Document document = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            document.SaveAs2(ref path2, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            //Document document2 = word.Documents.Open(path2);
            duongdanCT.Text = path2.ToString();
        }

        private void SuaCT_Click(object sender, EventArgs e)
        {
            if (duongdanCT.Text.Length == 0)
            {
                MessageBox.Show("File chưa tồn tại", "Thông báo");
            }
            else
            {
                object path2 = duongdanCT.Text;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = true;
                Document document = word.Documents.Open(path2);
            }
        }

        private void ImportCT_Click(object sender, EventArgs e)
        {
            string path = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy");
            System.IO.Directory.CreateDirectory(path);
            object sFileName;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = ".docx file|*.docx"; //"All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = false;
                object path2 = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy") + @"\CT" + Mabantin.Text + ".docx";
                object oMissing = System.Reflection.Missing.Value;

                Document document = word.Documents.Open(sFileName);

                document.SaveAs2(ref path2, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)document).Close(ref saveChanges, ref oMissing, ref oMissing);
                duongdanCT.Text = path2.ToString();
            }
        }

        private void XemtruocCT_Click(object sender, EventArgs e)
        {
            //IsFileLocked(new FileInfo(duongdanCT.Text));
            if (duongdanCT.Text.Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập tập tin Bản tin chính thức", "Thông báo");
            }
            else
            {
                Converttopdf(duongdanCT.Text, duongdanCT.Text.Substring(duongdanCT.Text.LastIndexOf(@"\") + 1,
                    duongdanCT.Text.Length - duongdanCT.Text.LastIndexOf(@"\") - 1));
            }
            axAcroPDF2.src = duongdanCT.Text.Replace(".docx", ".pdf");
        }
        #endregion

        #region Tập tin nháp
        private void Soannhap_Click(object sender, EventArgs e)
        {
            //Tạo file word + đường dẫn
            string path = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy");
            System.IO.Directory.CreateDirectory(path);
            object path2 = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy") + @"\NH" + Mabantin.Text + ".docx";
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            object oMissing = System.Reflection.Missing.Value;
            Document document = word.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            document.SaveAs2(ref path2, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            //Document document2 = word.Documents.Open(path2);
            duongdanNhap.Text = path2.ToString();
        }

        private void Suanhap_Click(object sender, EventArgs e)
        {
            if (duongdanNhap.Text.Length == 0)
            {
                MessageBox.Show("File chưa tồn tại", "Thông báo");
            }
            else
            {
                object path2 = duongdanNhap.Text;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = true;
                Document document = word.Documents.Open(path2);
            }
        }

        private void Importnhap_Click(object sender, EventArgs e)
        {
            string path = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy");
            System.IO.Directory.CreateDirectory(path);
            object sFileName;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = ".docx file|*.docx";
            choofdlog.FilterIndex = 1;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Visible = false;
                object path2 = @"D:\Stuffs\Luutru\" + DateTime.Now.ToString("ddMMyy") + @"\NH" + Mabantin.Text + ".docx";
                object oMissing = System.Reflection.Missing.Value;

                Document document = word.Documents.Open(sFileName);

                document.SaveAs2(ref path2, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)document).Close(ref saveChanges, ref oMissing, ref oMissing);
                duongdanNhap.Text = path2.ToString();
            }
        }

        private void Xemtruocnhap_Click(object sender, EventArgs e)
        {
            if (duongdanNhap.Text.Length == 0)
            {
                MessageBox.Show("Yêu cầu nhập tập tin Bản tin nháp", "Thông báo");
            }
            else
            {
                Converttopdf(duongdanNhap.Text, duongdanNhap.Text.Substring(duongdanNhap.Text.LastIndexOf(@"\") + 1,
                    duongdanNhap.Text.Length - duongdanNhap.Text.LastIndexOf(@"\") - 1));
            }
            axAcroPDF1.src = duongdanNhap.Text.Replace(".docx", ".pdf");
        }
        #endregion
        private bool checkfile()
        {
            if (duongdanCT.Text.Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show(@"Đường dẫn tập tin đã tồn tại
                /b Xác nhận ghi đè?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                    return false;
                else
                    return true;                
            }
            else
                return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mabantin.Text = "BT" + string.Format("{0:0000}", (int.Parse(taikhoan.Laybantincuoi().idbantin.ToString()) + 1));
            tukhoa.Text = "";
            tieude.Text = "";
            dataGridView1.DataSource = null;
            duongdanCT.Text = "";
            duongdanNhap.Text = "";
            axAcroPDF1.src = null;
            axAcroPDF2.src = null;
        }

        private void Themnhom_Click(object sender, EventArgs e)
        {
            int idnhom1 = nhomnhancb.SelectedIndex + 1;
            bool tontai = nhomduocchon.Any(item => item.idnhombantin == taikhoan.Laynhom(idnhom1).idnhombantin);
            if (tontai)
                MessageBox.Show("Nhóm đã tồn tại trong danh sách", "Thông báo");
            else
            {
                nhomduocchon.Add(taikhoan.Laynhom(idnhom1));
                loaddata();
            }
        }

        private void Xoanhom_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string nhomxoa = dr.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(string.Format("Xóa nhóm {0} khỏi danh sách?", nhomxoa),
                "Thông báo",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var itemToRemove = nhomduocchon.Single(r => r.tennhom == nhomxoa);
                nhomduocchon.Remove(itemToRemove);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            loaddata();
        }
        private void GDnhom_Click(object sender, EventArgs e)
        {
            GDchinh2 gd = System.Windows.Forms.Application.OpenForms["GDchinh2"] as GDchinh2;
            Nhombantin Nhombantin = new Nhombantin();
            Nhombantin.capquyen(tk, quyen);
            gd.xulymenu2(Nhombantin);
        }

        private void GDchude_Click(object sender, EventArgs e)
        {
            GDchinh2 gd = System.Windows.Forms.Application.OpenForms["GDchinh2"] as GDchinh2;
            Chude chude = new Chude();
            chude.capquyen(tk, quyen);
            gd.xulymenu2(chude);
        }

        public void loaddata() //Load lên datagidview
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nhomduocchon;
            //wrap text
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tên nhóm";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
        }

        private void Hoantat_Click(object sender, EventArgs e)
        {
            if (duongdanCT.Text.Length == 0 | duongdanNhap.Text.Length == 0|tieude.Text.Length == 0 | dataGridView1.DataSource == null)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ tập tin bản tin", "Thông báo");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Hoàn tất và gửi bản tin đi?", "Thông báo",
                MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bantin bt = new bantin();
                    bt.idbantin = int.Parse(Mabantin.Text.Substring(Mabantin.Text.LastIndexOf("T") + 1, 4));
                    bt.idchude = chudebantin.Find(x => x.tenchude == chudecb.Text).idchude;
                    bt.iduser = dangnhap.iduser;
                    bt.hinhthuc = htsoancb.Text;
                    bt.mucdo = (mucdocb.Text == "Bình thường") ? 'B' : 'C';
                    bt.tieude = tieude.Text;
                    bt.tukhoa = tukhoa.Text;
                    bt.nhomnhan = Layidnhomdachon();
                    bt.duongdanCT = duongdanCT.Text;
                    bt.duongdanNhap = duongdanNhap.Text;
                    bt.tinhtrangduyet = "CD";
                    bt.ngaysoan = DateTime.Now.Date;
                    taikhoan.Thembantin(bt.idbantin, bt.idchude, bt.iduser, bt.tukhoa, bt.tieude, bt.hinhthuc,
                        bt.mucdo, bt.duongdanCT, bt.duongdanNhap, bt.nhomnhan, bt.ngaysoan);

                    List<int> nhomdachon = Laynhomdachon();
                    List<int> dsnguoinhan = taikhoan.Laynguoinhan(nhomdachon);
                    taikhoan.Themnguoinhan(bt.idbantin, dsnguoinhan);
                }
            }
            GDchinh2 gd = System.Windows.Forms.Application.OpenForms["GDchinh2"] as GDchinh2;
            DSbantin DSbantin = new DSbantin();
            DSbantin.capquyen(tk, quyen);
            gd.xulymenu2(DSbantin);
            this.Close();
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

        public List<int> Laynhomdachon()// Lấy idnhóm tại cột X từ nhomduocchon
        {
            List<int> ketqua = new List<int>();
            foreach (bantin_nhom item in nhomduocchon)
            {
                int kq = item.idnhombantin;
                ketqua.Add(kq);
            }
            return ketqua;
        }

        public string Layidnhomdachon() // Lấy tên nhóm tại cột X từ datagrid1
        {
            string ketqua = "";
            foreach (bantin_nhom item in nhomduocchon)
            {
                string kq = item.idnhombantin.ToString();
                if (ketqua == "")
                    ketqua = kq;
                else
                    ketqua = ketqua + "," + kq;
            }
            return ketqua;
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}
