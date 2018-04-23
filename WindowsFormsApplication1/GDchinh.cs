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
    public partial class GDchinh : Form
    {
        public GDchinh()
        {
            InitializeComponent();
        }

        private void GDchinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
        }
        #region Thanh công cụ
        private void dskhoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["khoals"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                KhoaLS khoals = new KhoaLS();
                khoals.capquyen("Tùng", 1);
                khoals.TopLevel = false;
                this.Controls.Add(khoals);
                xulymenu xl = new xulymenu(khoals);
            }
        }
        private void dspbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["phongban"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
            Phongban phongban = new Phongban();
            phongban.TopLevel = false;
            phongban.capquyen("Tùng", 1);
            this.Controls.Add(phongban);
            xulymenu xl = new xulymenu(phongban);
            }
        }
        private void dsnhansuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Nhansu"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Nhansu Nhansu = new Nhansu();
                Nhansu.capquyen("Tùng", 1);
                Nhansu.TopLevel = false;
                this.Controls.Add(Nhansu);
                xulymenu xl = new xulymenu(Nhansu);
            }
        }
        private void nhomdlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Nhomdl"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Nhomdl Nhomdl = new Nhomdl();
                Nhomdl.capquyen("Tùng", 1);
                Nhomdl.TopLevel = false;
                this.Controls.Add(Nhomdl);
                xulymenu xl = new xulymenu(Nhomdl);
            }
        }
        private void hcgocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Hoatchatgoc"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Hoatchatgoc Hoatchatgoc = new Hoatchatgoc();
                Hoatchatgoc.capquyen("Tùng", 1);
                Hoatchatgoc.TopLevel = false;
                this.Controls.Add(Hoatchatgoc);
                xulymenu xl = new xulymenu(Hoatchatgoc);
            }

        }
        private void hcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Hoatchat"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Hoatchat Hoatchat = new Hoatchat();            
                Hoatchat.capquyen("Tùng", 1);            
                Hoatchat.TopLevel = false;                     
                this.Controls.Add(Hoatchat);
                xulymenu xl = new xulymenu(Hoatchat);
            }
        }

        private void thuocThuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Thuocbt"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Thuocbt Thuocbt = new Thuocbt();
                Thuocbt.capquyen("Tùng", 1);
                Thuocbt.TopLevel = false;
                this.Controls.Add(Thuocbt);
                xulymenu xl = new xulymenu(Thuocbt);
            }
        }

        private void KSDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["KSDB"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                KSDB KSDB = new KSDB();
                KSDB.capquyen("Tùng", 1);
                KSDB.TopLevel = false;
                this.Controls.Add(KSDB);
                xulymenu xl = new xulymenu(KSDB);
            }
        }

        private void xncnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["XNCN"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                XNCN XNCN = new XNCN();
                XNCN.capquyen("Tùng", 1);
                XNCN.TopLevel = false;
                this.Controls.Add(XNCN);
                xulymenu xl = new xulymenu(XNCN);
            }
        }

        private void benhphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Benhpham"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Benhpham Benhpham = new Benhpham();
                Benhpham.capquyen("Tùng", 1);
                Benhpham.TopLevel = false;
                this.Controls.Add(Benhpham);
                xulymenu xl = new xulymenu(Benhpham);
            }
        }

        private void vikhuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Vikhuan"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Vikhuan Vikhuan = new Vikhuan();
                Vikhuan.capquyen("Tùng", 1);
                Vikhuan.TopLevel = false;
                this.Controls.Add(Vikhuan);
                xulymenu xl = new xulymenu(Vikhuan);
            }
        }

        private void ttbenhnhanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Benhan"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Benhan Benhan = new Benhan();
                Benhan.capquyen("Tùng", 1);
                Benhan.TopLevel = false;
                this.Controls.Add(Benhan);
                xulymenu xl = new xulymenu(Benhan);
            }
        }

        private void dsbenhnhanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DSBenhan"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                DSBenhan DSBenhan = new DSBenhan();
                DSBenhan.capquyen("Tùng", 1);
                DSBenhan.TopLevel = false;
                this.Controls.Add(DSBenhan);
                xulymenu xl = new xulymenu(DSBenhan);
            }
        }

        private void nhapphieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["PhieuSDKS"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                Phieu PhieuSDKS = new Phieu();
                PhieuSDKS.capquyen("Tùng", 1);
                PhieuSDKS.TopLevel = false;
                this.Controls.Add(PhieuSDKS);
                xulymenu xl = new xulymenu(PhieuSDKS);
            }
        }

        private void duyetphieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Duyetphieu"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Duyetphieu Duyetphieu = new Duyetphieu();
                Duyetphieu.capquyen("Tùng", 1);
                Duyetphieu.TopLevel = false;
                this.Controls.Add(Duyetphieu);
                xulymenu xl = new xulymenu(Duyetphieu);
            }
        }
        private void DSphieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DSphieu"];
            if (fc != null){
                fc.BringToFront();
            }
            else
            {
                DSphieu DSphieu = new DSphieu();
                DSphieu.capquyen("Tùng", 1);
                DSphieu.TopLevel = false;
                this.Controls.Add(DSphieu);
                xulymenu xl = new xulymenu(DSphieu);
            }
        }

        private void xemTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Xembantin"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Xembantin Xembantin = new Xembantin();
                Xembantin.capquyen("Tùng", 1);
                Xembantin.TopLevel = false;
                this.Controls.Add(Xembantin);
                xulymenu xl = new xulymenu(Xembantin);
            }
        }

        private void soanTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Soanbantin"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Soanbantin Soanbantin = new Soanbantin();
                Soanbantin.capquyen("Tùng", 1);
                Soanbantin.TopLevel = false;
                this.Controls.Add(Soanbantin);
                xulymenu xl = new xulymenu(Soanbantin);
            }
            
        }

        private void dsTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Suabantin"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Suabantin Suabantin = new Suabantin();
                Suabantin.capquyen("Tùng", 1);
                Suabantin.TopLevel = false;
                this.Controls.Add(Suabantin);
                xulymenu xl = new xulymenu(Suabantin);
            }
        }

        private void duyetTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Duyetbantin"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Duyetbantin Duyetbantin = new Duyetbantin();
                Duyetbantin.capquyen("Tùng", 1);
                Duyetbantin.TopLevel = false;
                this.Controls.Add(Duyetbantin);
                xulymenu xl = new xulymenu(Duyetbantin);
            }
        }

        private void themADRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["baocaoadr1"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                baocaoadr1 baocaoadr1 = new baocaoadr1();
                baocaoadr1.capquyen("Tùng", 1);
                baocaoadr1.TopLevel = false;
                this.Controls.Add(baocaoadr1);
                xulymenu xl = new xulymenu(baocaoadr1);
            }
        }

        private void dsADRkhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["adrkhoa"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                adrkhoa adrkhoa = new adrkhoa();
                adrkhoa.capquyen("Tùng", 1);
                adrkhoa.TopLevel = false;
                this.Controls.Add(adrkhoa);
                xulymenu xl = new xulymenu(adrkhoa);
            }
        }

        private void dsADRallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DSadr"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                DSadr DSadr = new DSadr();
                DSadr.capquyen("Tùng", 1);
                DSadr.TopLevel = false;
                this.Controls.Add(DSadr);
                xulymenu xl = new xulymenu(DSadr);
            }
        }

        private void hddatcauhoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["Themcauhoi"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                Themcauhoi Themcauhoi = new Themcauhoi();
                Themcauhoi.capquyen("Tùng", 1);
                Themcauhoi.TopLevel = false;
                this.Controls.Add(Themcauhoi);
                xulymenu xl = new xulymenu(Themcauhoi);
            }
        }

        private void dshoidapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["DScauhoi"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                DScauhoi DScauhoi = new DScauhoi();
                DScauhoi.capquyen("Tùng", 1);
                DScauhoi.TopLevel = false;
                this.Controls.Add(DScauhoi);
                xulymenu xl = new xulymenu(DScauhoi);
            }
        }

        private void tkKSDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["thongke2"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                thongke2 thongke2 = new thongke2();
                thongke2.capquyen("Tùng", 1);
                thongke2.TopLevel = false;
                this.Controls.Add(thongke2);
                xulymenu xl = new xulymenu(thongke2);
            }
        }

        private void tkTTTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["thongkebantin"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                thongkebantin thongkebantin = new thongkebantin();
                thongkebantin.capquyen("Tùng", 1);
                thongkebantin.TopLevel = false;
                this.Controls.Add(thongkebantin);
                xulymenu xl = new xulymenu(thongkebantin);
            }
        }

        private void tkhoidapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tkADRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["thongke3"];
            if (fc != null)
            {
                fc.BringToFront();
            }
            else
            {
                thongke3 thongke3 = new thongke3();
                thongke3.capquyen("Tùng", 1);
                thongke3.TopLevel = false;
                this.Controls.Add(thongke3);
                xulymenu xl = new xulymenu(thongke3);
            }
        }
        #endregion

        
        public class xulymenu
        {
            public Form testform;
            public xulymenu(Form Testform)
            {
                testform = Testform;
                testform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                testform.Dock = DockStyle.Fill;
                testform.BringToFront();
                testform.Show();
            }
        }

        

        

        

        
                
    }
}
