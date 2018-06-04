using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public class BUS
    {
         
        KetnoiCSDLDataContext data = new KetnoiCSDLDataContext();
        #region Đăng nhập
        public bool KTdangnhap(string tendn, string matkhau)
        {
            int taikhoan = (from tk in data.nhansus
                            where tk.acc == tendn && tk.pw == matkhau
                            select tk).Count();
            if (taikhoan == 1)
                return true;
            else
                return false;
        }
        public short KTquyen(string tendn)
        {
            short taikhoan = (from tk in data.nhansus
                              where tk.acc == tendn
                              select tk.quyen).Single();
            return taikhoan;
        }

         public IEnumerable<nhansu> Laydstk()
         {
            IEnumerable<nhansu> taikhoan = from tk in data.nhansus
                                           select tk;
            return taikhoan;
         }

         public nhansu Laytaikhoan(string tendn)
         {
             nhansu taikhoan = (from tk in data.nhansus
                                where tk.acc == tendn
                                select tk).Single();
             return taikhoan;
         }
         public nhansu Laytaikhoan2(int iduser)
         {
             nhansu taikhoan = (from tk in data.nhansus
                                where tk.iduser == iduser
                                select tk).Single();
             return taikhoan;
         }
         public List<bantin_ykien_duyet> Layykien(int idbantin)
         {
             List<bantin_ykien_duyet> ketqua = (from tk in data.bantin_ykien_duyets
                                                where tk.idbantin == idbantin
                                                select tk).ToList();
             return ketqua;
         }
//        public string layten(string tendn)
//        {
//            string ten = (from tk in data.nguoidungs
//                          where tk.Taikhoan == tendn
//                          select tk.Ten).Single();
//            return ten;
//        }
//        #endregion
//        #region Thêm tài khoản
//        public bool KTtontai(string tendn)
//        {
//            int taikhoan = (from tk in data.nguoidungs
//                            where tk.Taikhoan == tendn
//                            select tk).Count();
//            if (taikhoan == 1)
//                return true;
//            else
//                return false;
//        }

//        public IEnumerable<nguoidung> Laytaikhoan()
//        {
//            IEnumerable<nguoidung> taikhoan = from tk in data.nguoidungs
//                                              select tk;
//            return taikhoan;
//        }
//        public void Themtaikhoan(string tendn, string mk, string ten, bool quyen)
//        {
//            nguoidung themtk = new nguoidung();
//            themtk.Taikhoan = tendn;
//            themtk.Matkhau = mk;
//            themtk.Ten = ten;
//            themtk.Quyen = quyen;
//            data.nguoidungs.InsertOnSubmit(themtk);
//            data.SubmitChanges();

//        }

//        public void xoatk(string tendn)
//        {
//            nguoidung xoanguoidung = (from tk in data.nguoidungs
//                                      select tk).Single(t => t.Taikhoan == tendn);
            
//            data.nguoidungs.DeleteOnSubmit(xoanguoidung);
//            data.SubmitChanges();
//        }
//        #endregion
//        #region Cập nhật sản phẩm
         //public bool KTBTtontai(int idbantin)
         //{
         //    int bantin = (from tk in data.bantins
         //                   where tk.idbantin == idbantin
         //                   select tk).Count();
         //    if (bantin == 1)
         //        return true;
         //    else
         //        return false;
         //}

//        public IEnumerable<Sanpham> Laysanpham()
//        {
//            IEnumerable<Sanpham> sanpham = from tk in data.Sanphams
//                                              select tk;
//            return sanpham;
//        }
         
//        public int Layspmoinhat()
//        {
//            Sanpham spmoi = new Sanpham();
//            List<int> idsp = (from tk in data.Sanphams
//                              select tk.IDsp).ToList();
//            return idsp.Max();
//        }

//        public void Capnhatspmoi(int idsp, string idngay)
//        {
//            luungay spmoi = new luungay();

//            spmoi.IDsp = idsp;
//            spmoi.IDngay = idngay;
//            spmoi.Nhap = 0;
//            spmoi.Xuat = 0;
//            spmoi.Ghichu = "";
//            spmoi.Ton = 0;
//            List<int> id = (from tk in data.luungays
//                            select tk.ID).ToList();

//            if (id.Count() == 0)
//                spmoi.IDsp = 1;
//            else
//                spmoi.ID = id.Max() + 1;

//            data.luungays.InsertOnSubmit(spmoi);
//            data.SubmitChanges();
//        }

//        public void Capnhatsp(string tenspcu, string tenspmoi, string quycachcu, string quycachmoi)
//        {
//            Sanpham suasanpham = (from sp in data.Sanphams
//                                  select sp).Single(t => t.Tensp == tenspcu && t.Quycachsp == quycachcu);
//            suasanpham.Tensp = tenspmoi;
//            suasanpham.Quycachsp = quycachmoi;
//            data.SubmitChanges();
//        }

//        public void Xoasp (int idsp)
//        {
//            Sanpham xoasanpham = (from sp in data.Sanphams
//                                  select sp).Single(t => t.IDsp == idsp);
//            data.Sanphams.DeleteOnSubmit(xoasanpham);

//            List<string> ngaysanpham = (from spx in data.luungays
//                                          where spx.IDsp == xoasanpham.IDsp
//                                          select spx.IDngay).ToList();

//            foreach (string idngay in ngaysanpham)
//            {
//                luungay sanphamngay = (from sp2 in data.luungays
//                                       where sp2.IDngay == idngay && sp2.IDsp == idsp
//                                       select sp2).Single();
//                data.luungays.DeleteOnSubmit(sanphamngay);
//            }
            
//            data.SubmitChanges();
//        }
//        #endregion
//        #region Cập nhật ngày
//        public bool KTngaymoi(string idngay)
//        {
//            int ngay = (from day in data.Ngays
//                        where day.IDngay == idngay
//                        select day).Count();
//            if (ngay == 1)
//                return true;
//            else
//                return false;
//        }
        
//        public void taongaymoi(string idngay, DateTime ngay)
//        {
//            Ngay ngaymoi = new Ngay();

//            ngaymoi.IDngay = idngay;
//            ngaymoi.Ngay1 = ngay;
//            data.Ngays.InsertOnSubmit(ngaymoi);
//            data.SubmitChanges();
//        }

//        public void xoangay(string idngay)
//        {
//            List<luungay> sanphamngay = (from sp2 in data.luungays
//                                       where sp2.IDngay == idngay
//                                       select sp2).ToList();
//            foreach (luungay item in sanphamngay)
//            {
//                data.luungays.DeleteOnSubmit(item);
//            }
            
//            data.SubmitChanges();
//        }

//        public void Themngay(string idngaycu, string idngaymoi)
//        {
//            IEnumerable<Sanpham> sanpham = (from sp in data.Sanphams
//                                            select sp).ToList();
//            List<int> ton = (from luu in data.luungays
//                                        where luu.IDngay == idngaycu
//                                        select luu.Ton).ToList();
//            int i = 0;
//            foreach (Sanpham item in sanpham)
//            {
//                luungay themngay = new luungay();
//                themngay.IDsp = item.IDsp;
//                themngay.IDngay = idngaymoi;
//                themngay.Nhap = 0;
//                themngay.Xuat = 0;
//                themngay.Ghichu = "";
//                themngay.Ton = ton[i];
//                List<int> id = (from tk in data.luungays
//                                select tk.ID).ToList();
//                themngay.ID = id.Max() + 1;
//                data.luungays.InsertOnSubmit(themngay);
//                data.SubmitChanges();
//                i += 1;

//            }
//        }

//        //public List<string> Layidngay()
//        //{
//        //    int songay = (from ngay in data.Ngays
//        //                     select ngay).Count();

//        //    List<string> listngay = (from ngay in data.Ngays
//        //                         select ngay.IDngay.ToString()).ToList();

//        //    string ngaycu = listngay[songay - 1];
//        //    string ngaymoi = listngay[songay - 2];


//        //    List<string> xuat = new List<string>();
//        //    xuat.Add(ngaycu);
//        //    xuat.Add(ngaymoi);
//        //    return xuat;
//        //}
//        public IEnumerable<sanphamxuat> Layngay(string idngay)
//        {
//            IEnumerable<sanphamxuat> luu = from luu1 in data.luungays
//                                       join tensp in data.Sanphams on luu1.IDsp equals tensp.IDsp
//                                       where luu1.IDngay == idngay
//                                       select new sanphamxuat(luu1.IDsp, luu1.IDngay, tensp.Tensp, luu1.Nhap, luu1.Xuat, luu1.Ton, luu1.Ghichu);
//            return luu;
//        }

//        public bool KTcapnhat(string idngay)
//        {
//            int ngay = (from day in data.luungays
//                        where day.IDngay == idngay
//                        select day).Count();
//            if (ngay >= 1)
//                return true;
//            else
//                return false;
//        }

//        public void Capnhatngay(int idsp, string idngay, int nhap, int xuat, string ghichu)
//        {
//            luungay sanpham = (from sp in data.luungays
//                               where sp.IDsp == idsp && sp.IDngay == idngay
//                               select sp).Single();
//            sanpham.Nhap = nhap;
//            sanpham.Xuat = xuat;
//            sanpham.Ton = sanpham.Ton + nhap - xuat;
//            sanpham.Ghichu = ghichu;
//            data.SubmitChanges();
//        }

//        public void Huybongay(int idsp, string idngaymoi, string idngaycu)
//        {
//            luungay sanpham = (from sp in data.luungays
//                               where sp.IDsp == idsp && sp.IDngay == idngaymoi
//                               select sp).Single();
//            sanpham.Nhap = 0;
//            sanpham.Xuat = 0;
//            sanpham.Ghichu = "";
//            sanpham.Ton = (from luu in data.luungays
//                           where luu.IDsp == idsp && luu.IDngay == idngaycu
//                           select luu.Ton).Single();
//            data.SubmitChanges();
//        }
//        #endregion
//        #region Tra cứu
//        public IEnumerable<Sanpham> Laytensanpham()
//        {
//            IEnumerable<Sanpham> sanpham = from tk in data.Sanphams
//                                           select tk;
//            return sanpham;
//        }
        
//        public List<sanphamxuat> tracuu(string tensanpham, string idngay)
//        {
//            List<sanphamxuat> sanpham = (from sp in data.luungays
//                                         join tensp in data.Sanphams on sp.IDsp equals tensp.IDsp
//                                         join ng in data.Ngays on sp.IDngay equals ng.IDngay
//                                         where tensp.Tensp == tensanpham && sp.IDngay == idngay
//                                         select new sanphamxuat(tensp.Tensp, ng.Ngay1, sp.Nhap, sp.Xuat, sp.Ton, sp.Ghichu)).ToList();
//            return sanpham;
//        }
//        #endregion
//    }
//    #region Class sản phẩm xuất
//    public class sanphamxuat
//    {
//        public string ten { get; set; }
//        public DateTime ngay { get; set; }
//        public int nhap { get; set; }
//        public int xuat { get; set; }
//        public int ton { get; set; }
//        public string ghichu { get; set; }
//        public int idsp { get; set; }
//        public string idngay { get; set; }
//        public sanphamxuat() { }
//        public sanphamxuat(string Ten, DateTime Ngay, int Nhap, int Xuat, int Ton, string Ghichu)
//        {
//            ten = Ten;
//            ngay = Ngay;
//            nhap = Nhap;
//            xuat = Xuat;
//            ton = Ton;
//            ghichu = Ghichu;
//        }

//        public sanphamxuat(int Idsp, string Idngay, string Ten, int Nhap, int Xuat, int Ton, string Ghichu)
//        {
//            idsp = Idsp;
//            idngay = Idngay;
//            ten = Ten;
//            nhap = Nhap;
//            xuat = Xuat;
//            ton = Ton;
//            ghichu = Ghichu;
//        }
//    }
#endregion

        #region Danh mục
         #region KhoaLS
         public List<khoa> Loadkhoa()
         {
             List<khoa> ketqua = (from tk in data.khoas
                                  select tk).ToList();
             return ketqua;
         }

         public void Themkhoa(string tenkhoa)
         {
             int dem = (from tk in data.khoas
                        select tk).ToList().Last().idkhoa;
             khoa themkhoa = new khoa();
             if (dem == 0)
                 themkhoa.idkhoa = 1;
             else
                 themkhoa.idkhoa = short.Parse((dem + 1).ToString());
             themkhoa.ten = tenkhoa;

             data.khoas.InsertOnSubmit(themkhoa);
             data.SubmitChanges();
         }
         public void Xoakhoa(string tenkhoa)
         {
             khoa xoakhoa = (from tk in data.khoas
                                      where tk.ten == tenkhoa
                                      select tk).Single();

             data.khoas.DeleteOnSubmit(xoakhoa);
             data.SubmitChanges();
         }

         public void Capnhatkhoa(string tenkhoacu, string tenkhoamoi)
         {
             khoa xoakhoa = (from tk in data.khoas
                                      where tk.ten == tenkhoacu
                                      select tk).Single();
             xoakhoa.ten = tenkhoamoi;
             data.SubmitChanges();
         }
         #endregion
         #region Phòng ban
         public List<phongban> Loadphongban()
         {
             List<phongban> ketqua = (from tk in data.phongbans
                                  select tk).ToList();
             return ketqua;
         }

         public void Themphongban(string tenphongban)
         {
             int dem = (from tk in data.phongbans
                        select tk).ToList().Last().idphongban;
             phongban themphongban = new phongban();
             if (dem == 0)
                 themphongban.idphongban = 1;
             else
                 themphongban.idphongban = short.Parse((dem + 1).ToString());
             themphongban.ten = tenphongban;

             data.phongbans.InsertOnSubmit(themphongban);
             data.SubmitChanges();
         }
         public void Xoaphongban(string tenphongban)
         {
             phongban xoaphongban = (from tk in data.phongbans
                             where tk.ten == tenphongban
                             select tk).Single();

             data.phongbans.DeleteOnSubmit(xoaphongban);
             data.SubmitChanges();
         }

         public void Capnhatphongban(string tenphongbancu, string tenphongbanmoi)
         {
             phongban capnhat = (from tk in data.phongbans
                             where tk.ten == tenphongbancu
                             select tk).Single();
             capnhat.ten = tenphongbanmoi;
             data.SubmitChanges();
         }
         #endregion
         #region Nhân sự
         public List<nhansu> Loadnhansu()
         {
             List<nhansu> ketqua = (from tk in data.nhansus
                                    select tk).ToList();
             return ketqua;
         }
         public List<string> Loadnghe()
         {
             List<string> ketqua = (from tk in data.nhansus
                                    select tk.nghenghiep).ToList();
             return ketqua;
         }

         public List<string> Loadchucvu()
         {
             List<string> ketqua = (from tk in data.nhansus
                                    select tk.chucvu).ToList();
             return ketqua;
         }

         public string Layphongban(short? idpb)
         {
             string ketqua = (from tk in data.phongbans
                              where tk.idphongban == idpb
                              select tk.ten).Single();
             return ketqua;
         }

         public string Laykhoa(short? id)
         {
             string ketqua = (from tk in data.khoas
                              where tk.idkhoa == id
                              select tk.ten).Single();
             return ketqua;
         }
         public void Themnhansu(string hoten, string manv, short idkhoa, short idphongban, string nghenghiep,
             string chucvu, string email, string sdt, string account)
         {
             int dem = (from tk in data.nhansus
                        select tk).ToList().Last().iduser;
             nhansu themnhansu = new nhansu();
             if (dem == 0)
                 themnhansu.iduser = 1;
             else
                 themnhansu.iduser = dem + 1;

             themnhansu.hoten = hoten;
             themnhansu.manv = manv;
             if (idkhoa != 0)
                 themnhansu.idkhoa = idkhoa;
             if (idphongban != 0)
                 themnhansu.idphongban = idphongban;

             themnhansu.nghenghiep = nghenghiep;
             themnhansu.chucvu = chucvu;
             themnhansu.email = email;
             themnhansu.sdt = sdt;
             themnhansu.acc = account;
             themnhansu.pw = "1";

             data.nhansus.InsertOnSubmit(themnhansu);
             data.SubmitChanges();
         }

         public void Capnhatnhansu(int iduser, string hoten, string manv, short idkhoa, short idphongban, string nghenghiep,
             string chucvu, string email, string sdt, string account)
         {
             nhansu themnhansu = (from tk in data.nhansus
                                  where tk.iduser == iduser
                                  select tk).Single();

             themnhansu.hoten = hoten;
             themnhansu.manv = manv;
             if (idkhoa != 0)
                 themnhansu.idkhoa = idkhoa;
             if (idphongban != 0)
                 themnhansu.idphongban = idphongban;
             themnhansu.nghenghiep = nghenghiep;
             themnhansu.chucvu = chucvu;
             themnhansu.email = email;
             themnhansu.sdt = sdt;
             themnhansu.acc = account;
             themnhansu.pw = "1";

             data.SubmitChanges();
         }

         public void Xoanhansu(int iduser)
         {
             nhansu xoanhansu = (from tk in data.nhansus
                                 where tk.iduser == iduser
                                 select tk).Single();

             data.nhansus.DeleteOnSubmit(xoanhansu);
             data.SubmitChanges();
         }

         public nhansu Laynhansu(int iduser)
         {
             nhansu ketqua = (from tk in data.nhansus
                                 where tk.iduser == iduser
                                 select tk).Single();

             return ketqua;
         }
         #endregion
         #region Chủ đề
         public List<bantin_chude> Loadchude()
         {
             List<bantin_chude> ketqua = (from tk in data.bantin_chudes
                                          select tk).ToList();
             return ketqua;
         }

         public void Themchude(string tenchude)
         {
             int dem = (from tk in data.bantin_chudes
                        select tk).ToList().Last().idchude;
             bantin_chude themchude = new bantin_chude();
             if (dem == 0)
                 themchude.idchude = 1;
             else
                 themchude.idchude = short.Parse((dem + 1).ToString());
             themchude.tenchude = tenchude;

             data.bantin_chudes.InsertOnSubmit(themchude);
             data.SubmitChanges();
         }
         public void Xoachude(string tenchude)
         {
             bantin_chude xoachude = (from tk in data.bantin_chudes
                                       where tk.tenchude == tenchude
                                       select tk).Single();

             data.bantin_chudes.DeleteOnSubmit(xoachude);
             data.SubmitChanges();
         }

         public void Capnhatchude(string tenchudecu, string tenchudemoi)
         {
             bantin_chude xoachude = (from tk in data.bantin_chudes
                                      where tk.tenchude == tenchudecu
                                      select tk).Single();
             xoachude.tenchude = tenchudemoi;
             data.SubmitChanges();
         }
         #endregion
         #region Nhóm bản tin
         public void Themnhombantin(string tennhombantin, string mota, List<int> iduser)
         {
             int dem = (from tk in data.bantin_nhoms
                        select tk).ToList().Last().idnhombantin;
             bantin_nhom themnhombantin = new bantin_nhom();
             if (dem == 0)
                 themnhombantin.idnhombantin = 1;
             else
                 themnhombantin.idnhombantin = dem + 1;
             themnhombantin.tennhom = tennhombantin;
             themnhombantin.mota = mota;
             data.bantin_nhoms.InsertOnSubmit(themnhombantin);
             data.SubmitChanges();

             foreach (int item in iduser)
             {
                 int dem2 = (from tk in data.bantin_kqnhoms
                                 select tk).ToList().Last().idkqnhom;
                 bantin_kqnhom themkq = new bantin_kqnhom();
                 if (dem2 == 0)
                     themkq.idkqnhom = 1;
                 else
                     themkq.idkqnhom = dem2 + 1;
                 themkq.idnhombantin = themnhombantin.idnhombantin;
                 themkq.iduser = item;
                 data.bantin_kqnhoms.InsertOnSubmit(themkq);
                 data.SubmitChanges();
             }
         }
         public void Xoanhombantin(int idnhom)
         {
             List<bantin_kqnhom> dskqxoa = (from tk in data.bantin_kqnhoms
                                            where tk.idnhombantin == idnhom
                                            select tk).ToList();
             data.bantin_kqnhoms.DeleteAllOnSubmit(dskqxoa);             

             bantin_nhom xoanhombantin = (from tk in data.bantin_nhoms
                                          where tk.idnhombantin == idnhom
                                          select tk).Single();
             data.bantin_nhoms.DeleteOnSubmit(xoanhombantin);

             data.SubmitChanges();
         }

         public void Capnhatnhombantin(int idnhom, string tenmoi, string motamoi, List<int> usermoi)
         {
             bantin_nhom capnhat = (from tk in data.bantin_nhoms
                                     where tk.idnhombantin == idnhom
                                     select tk).Single();
             capnhat.tennhom = tenmoi;
             capnhat.mota = motamoi;
             data.SubmitChanges();

             List<bantin_kqnhom> dskqxoa = (from tk in data.bantin_kqnhoms
                                            where tk.idnhombantin == idnhom
                                            select tk).ToList();
             data.bantin_kqnhoms.DeleteAllOnSubmit(dskqxoa);

             foreach (int item in usermoi)
             {
                 int dem2 = (from tk in data.bantin_kqnhoms
                             select tk).ToList().Last().idkqnhom;
                 bantin_kqnhom themkq = new bantin_kqnhom();
                 if (dem2 == 0)
                     themkq.idkqnhom = 1;
                 else
                     themkq.idkqnhom = dem2 + 1;
                 themkq.idnhombantin = idnhom;
                 themkq.iduser = item;
                 data.bantin_kqnhoms.InsertOnSubmit(themkq);
                 data.SubmitChanges();
             }
         }

         public List<nhansu> Laykqnhombantin(int idnhom)
         {
             List<nhansu> dsnhansu = (from tk in data.nhansus
                                      join cd in data.bantin_kqnhoms on tk.iduser equals cd.iduser
                                      where cd.idnhombantin == idnhom
                                      select tk).ToList();
             return dsnhansu;
         }

         public List<nhansu> Laykqbtconlai(List<nhansu> dsguitin)
         {
             List<nhansu> dsnhansu = (from tk in data.nhansus
                                      select tk).ToList();
             List<nhansu> conlai = dsnhansu.Except(dsguitin).ToList();
             return conlai;
         }
         #endregion
         #region Tên bệnh phẩm
         public List<tenbenhpham> Loadtenbenhpham()
         {
             List<tenbenhpham> ketqua = (from tk in data.tenbenhphams
                                  select tk).ToList();
             return ketqua;
         }

         public void Themtenbenhpham(string tentenbenhpham)
         {
             int dem = (from tk in data.tenbenhphams
                        select tk).ToList().Last().idtenbenhpham;
             tenbenhpham themtenbenhpham = new tenbenhpham();
             if (dem == 0)
                 themtenbenhpham.idtenbenhpham = 1;
             else
                 themtenbenhpham.idtenbenhpham = short.Parse((dem + 1).ToString());
             themtenbenhpham.tenbp = tentenbenhpham;

             data.tenbenhphams.InsertOnSubmit(themtenbenhpham);
             data.SubmitChanges();
         }
         public void Xoatenbenhpham(string tentenbenhpham)
         {
             tenbenhpham xoatenbenhpham = (from tk in data.tenbenhphams
                                           where tk.tenbp == tentenbenhpham
                                           select tk).Single();

             data.tenbenhphams.DeleteOnSubmit(xoatenbenhpham);
             data.SubmitChanges();
         }

         public void Capnhattenbenhpham(string tentenbenhphamcu, string tentenbenhphammoi)
         {
             tenbenhpham xoatenbenhpham = (from tk in data.tenbenhphams
                                           where tk.tenbp == tentenbenhphamcu
                                           select tk).Single();
             xoatenbenhpham.tenbp = tentenbenhphammoi;
             data.SubmitChanges();
         }
         #endregion
         #region Hoạt chất gốc
         public List<hoatchatgoc> Loadhoatchatgoc()
         {
             List<hoatchatgoc> ketqua = (from tk in data.hoatchatgocs
                                  select tk).ToList();
             return ketqua;
         }

         public void Themhoatchatgoc(string tenhoatchatgoc)
         {
             int dem = (from tk in data.hoatchatgocs
                        select tk).ToList().Last().idhcgoc;
             hoatchatgoc themhoatchatgoc = new hoatchatgoc();
             if (dem == 0)
                 themhoatchatgoc.idhcgoc = 1;
             else
                 themhoatchatgoc.idhcgoc = short.Parse((dem + 1).ToString());
             themhoatchatgoc.ten = tenhoatchatgoc;

             data.hoatchatgocs.InsertOnSubmit(themhoatchatgoc);
             data.SubmitChanges();
         }
         public void Xoahoatchatgoc(string tenhoatchatgoc)
         {
             hoatchatgoc xoahoatchatgoc = (from tk in data.hoatchatgocs
                             where tk.ten == tenhoatchatgoc
                             select tk).Single();

             data.hoatchatgocs.DeleteOnSubmit(xoahoatchatgoc);
             data.SubmitChanges();
         }

         public void Capnhathoatchatgoc(string tenhoatchatgoccu, string tenhoatchatgocmoi)
         {
             hoatchatgoc xoahoatchatgoc = (from tk in data.hoatchatgocs
                             where tk.ten == tenhoatchatgoccu
                             select tk).Single();
             xoahoatchatgoc.ten = tenhoatchatgocmoi;
             data.SubmitChanges();
         }
         #endregion
        #endregion

         #region Bản tin
         public bantin Laybantin(int idbantin)
         {
             bantin bantin = (from bt in data.bantins
                              where bt.idbantin == idbantin
                              select bt).Single();
             return bantin;
         }
         public List<bantin> Laybantinduyet()
         {
             List<bantin> bantin = (from bt in data.bantins
                                    where bt.tinhtrangduyet != "DD"
                                    select bt).ToList();
             return bantin;
         }

         public List<bantin> Laybantindaduyet()
         {
             List<bantin> bantin = (from bt in data.bantins
                                    where bt.tinhtrangduyet == "DD"
                                    select bt).ToList();
             return bantin;
         }

         public List<bantin> Laybantinsoan(int iduser)
         {
             List<bantin> bantin = (from bt in data.bantins
                                    where bt.iduser == iduser
                                    select bt).ToList();
             return bantin;
         }

         public bantin Laybantincuoi()
         {
             int dem = (from bt in data.bantins
                              select bt).Count();
             bantin bantin = (from bt in data.bantins
                              where bt.idbantin == dem
                              select bt).Single();
             return bantin;
         }
         public List<bantin> Laybantinxem(int iduser)
         {
             List<bantin> bantin = (from bt in data.bantins
                                    join gui in data.bantin_guis on bt.idbantin equals gui.idbantin
                                    where gui.iduser == iduser
                                    select bt).ToList();
             return bantin;
         }
         public List<bantin_chude> Laychude()
         {
             List<bantin_chude> chude = (from cd in data.bantin_chudes
                                         select cd).ToList();
             return chude;
         }

         public List<string> Laytennhom()
         {
             List<string> nhombt = (from cd in data.bantin_nhoms
                                    select cd.tennhom).ToList();
             return nhombt;
         }

         public bantin_nhom Laynhom(int idnhom)
         {
             bantin_nhom nhombt = (from cd in data.bantin_nhoms
                                   where cd.idnhombantin == idnhom
                                   select cd).Single();
             return nhombt;
         }

         public List<bantin_nhom> Laynhomall()
         {
             List<bantin_nhom> nhombt = (from cd in data.bantin_nhoms
                                         select cd).ToList();
             return nhombt;
         }
         public List<bantin> Locbantin1(int idchude, string tukhoa, int iduser)
         {
             List<bantin> ketqua = new List<bantin>();
             if (idchude == 0)
             {
                 ketqua = (from cd in data.bantins
                           join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                           where cd.tieude.Contains(tukhoa) == true && gui.iduser == iduser
                           select cd).ToList();
             }
             else
             {
                 ketqua = (from cd in data.bantins
                           join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                           where cd.idchude == idchude && cd.tieude.Contains(tukhoa) == true
                           && gui.iduser == iduser
                           select cd).ToList();
             }
             return ketqua;
         }
         public List<bantin> Locbantin2(int idchude, string tukhoa, bool doc, bool phanhoi, int iduser)
         {
             List<bantin> ketqua = new List<bantin>();
             if (idchude == 0)
             {
                 ketqua = (from cd in data.bantins
                                        join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                                        where cd.tieude.Contains(tukhoa) == true
                                        && gui.iduser == iduser && gui.daxem == doc
                                        && gui.daphanhoi == phanhoi
                                        select cd).ToList();
             }
             else
             {
                 ketqua = (from cd in data.bantins
                                        join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                                        where cd.idchude == idchude && cd.tieude.Contains(tukhoa) == true
                                        && gui.iduser == iduser && gui.daxem == doc
                                        && gui.daphanhoi == phanhoi
                                        select cd).ToList();
             }
             return ketqua;
         }

         public List<bantin> Locbantinduyet1(int idchude, string tukhoa, char mucdo)
         {
             List<bantin> ketqua = new List<bantin>();
             if (idchude == 0)
             {
                 ketqua = (from cd in data.bantins
                           where cd.tieude.Contains(tukhoa) == true && cd.mucdo == mucdo
                           select cd).ToList();
             }
             else
             {
                 ketqua = (from cd in data.bantins
                           join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                           where cd.idchude == idchude && cd.tieude.Contains(tukhoa) == true && cd.mucdo == mucdo
                           select cd).ToList();
             }
             return ketqua;
         }

         public List<bantin> Locbantinduyet2(int idchude, string tukhoa)
         {
             List<bantin> ketqua = new List<bantin>();
             if (idchude == 0)
             {
                 ketqua = (from cd in data.bantins
                           where cd.tieude.Contains(tukhoa) == true
                           select cd).ToList();
             }
             else
             {
                 ketqua = (from cd in data.bantins
                           join gui in data.bantin_guis on cd.idbantin equals gui.idbantin
                           where cd.idchude == idchude && cd.tieude.Contains(tukhoa) == true
                           select cd).ToList();
             }
             return ketqua;
         }

         public List<bantin_phanhoi_doc> Layphanhoi(int idbantin)
         {
             List<bantin_phanhoi_doc> ketqua = (from cd in data.bantin_phanhoi_docs
                                                where cd.idbantin == idbantin
                                                select cd).ToList();
             return ketqua;

         }

         public void Xembantin(int idbantin, int iduser)
         {
             bantin_gui xembt = (from tk in data.bantin_guis
                                 where tk.idbantin == idbantin && tk.iduser == iduser
                                 select tk).Single();

             xembt.daxem = true;
             data.SubmitChanges();
         }
         public void Themphanhoi(int idbantin, int iduser, string noidung, DateTime thoigian)
         {
             bantin_phanhoi_doc themphanhoi = new bantin_phanhoi_doc();
             int idsp = (from tk in data.bantin_phanhoi_docs
                         select tk).ToList().Last().idphanhoi;
             if (idsp == 0)
                 themphanhoi.idphanhoi = 1;
             else
                 themphanhoi.idphanhoi = idsp + 1;

             themphanhoi.idbantin = idbantin;
             themphanhoi.iduser = iduser;
             themphanhoi.noidung = noidung;
             themphanhoi.ngaygio = thoigian;
             themphanhoi.xoa = false;
             data.bantin_phanhoi_docs.InsertOnSubmit(themphanhoi);

             bantin_gui users = (from tk in data.bantin_guis
                                 where tk.idbantin == idbantin && tk.iduser == iduser
                                 select tk).Single();

             users.daphanhoi = true;

             data.SubmitChanges();
         }

         public void Xoaphanhoi(int idbantin, int iduser, string noidung)
         {
             bantin_phanhoi_doc xoaph = (from tk in data.bantin_phanhoi_docs
                                         where tk.idbantin == idbantin && tk.iduser == iduser && tk.noidung == noidung
                                         select tk).Single();

             data.bantin_phanhoi_docs.DeleteOnSubmit(xoaph);
             data.SubmitChanges();

             bantin_gui users = (from tk in data.bantin_guis
                                  where tk.idbantin == idbantin && tk.iduser == iduser
                                  select tk).Single();
             users.daphanhoi = false;
             data.SubmitChanges();
         }

         public void Luuykienduyet(int idbantin, int iduser, string noidung, DateTime ngaygui)
         {
             int slykien = (from tk in data.bantin_ykien_duyets
                            select tk).ToList().Last().idykienbt;

             bantin_ykien_duyet ykienmoi = new bantin_ykien_duyet();
             if (slykien == 0)
                 ykienmoi.idykienbt = 1;
             else
                 ykienmoi.idykienbt = slykien + 1;

             ykienmoi.idbantin = idbantin;
             ykienmoi.iduser = iduser;
             ykienmoi.noidung = noidung;
             ykienmoi.ngay = ngaygui;
             data.bantin_ykien_duyets.InsertOnSubmit(ykienmoi);
             data.SubmitChanges();

             bantin capnhatbt = (from tk in data.bantins
                                     where tk.idbantin == idbantin
                                     select tk).Single();

             capnhatbt.tinhtrangduyet = "YK";
             data.SubmitChanges();
         }

         public void Luuykienduyet2(int idbantin, int iduser, string noidung, DateTime ngaygui, string duongdanDuyet)
         {
             int slykien = (from tk in data.bantin_ykien_duyets
                            select tk).ToList().Last().idykienbt;
             bantin_ykien_duyet ykienmoi = new bantin_ykien_duyet();
             if (slykien == 0)
                 ykienmoi.idykienbt = 1;
             else
                 ykienmoi.idykienbt = slykien + 1;

             ykienmoi.idbantin = idbantin;
             ykienmoi.iduser = iduser;
             ykienmoi.noidung = noidung;
             ykienmoi.ngay = ngaygui;
             
             bantin capnhatbt = (from tk in data.bantins
                                     where tk.idbantin == idbantin
                                     select tk).Single();

             capnhatbt.tinhtrangduyet = "YK";
             capnhatbt.duongdanDuyet = duongdanDuyet;

             data.bantin_ykien_duyets.InsertOnSubmit(ykienmoi);
             data.SubmitChanges();
         }

         public void Duyetbantin(int idbantin)
         {
             bantin capnhatbt = (from tk in data.bantins
                                 where tk.idbantin == idbantin
                                 select tk).Single();

             capnhatbt.tinhtrangduyet = "DD";
             data.SubmitChanges();

             List<bantin_gui> capnhatgui = (from tk in data.bantin_guis
                                      where tk.idbantin == idbantin
                                      select tk).ToList();
             foreach (bantin_gui users in capnhatgui)
             {
                 users.dagui = true;
                 data.SubmitChanges();
             }
             
         }

         public void Thembantin(int idbantin, short idchude, int iduser, string tukhoa, string tieude, string hinhthuc,
             char mucdo, string duongdanCT, string duongdanNhap, string nhomnhan, DateTime ngaysoan)
         {
             bantin thembt = new bantin();
             int idsp = (from tk in data.bantins
                         select tk.idbantin).ToList().Last();
             if (idsp == 0)
                 thembt.idbantin = 1;
             else
                 thembt.idbantin = idbantin;

             thembt.idchude = idchude;
             thembt.iduser = iduser;
             thembt.tukhoa = tukhoa;
             thembt.tieude = tieude;
             thembt.hinhthuc = hinhthuc;
             thembt.mucdo = mucdo;
             thembt.duongdanCT = duongdanCT;
             thembt.duongdanNhap = duongdanNhap;
             thembt.tinhtrangduyet = "CD";
             thembt.xem = 0;
             thembt.nhomnhan = nhomnhan;
             thembt.ngaysoan = ngaysoan;
             data.bantins.InsertOnSubmit(thembt);
             data.SubmitChanges();
         }

         public void Capnhatbt(int idbantin, short idchude, int iduser, string tukhoa, string tieude, string hinhthuc,
             char mucdo, string duongdanCT, string duongdanNhap, string nhomnhan, DateTime ngaysoan)
         {
             bantin thembt = (from tk in data.bantins
                              where tk.idbantin == idbantin
                              select tk).Single();

             thembt.idbantin = idbantin;
             thembt.idchude = idchude;
             thembt.iduser = iduser;
             thembt.tukhoa = tukhoa;
             thembt.tieude = tieude;
             thembt.hinhthuc = hinhthuc;
             thembt.mucdo = mucdo;
             thembt.duongdanCT = duongdanCT;
             thembt.duongdanNhap = duongdanNhap;
             thembt.tinhtrangduyet = "CD";
             thembt.xem = 0;
             thembt.nhomnhan = nhomnhan;
             thembt.ngaysoan = ngaysoan;
             data.SubmitChanges();
         }


         public void Themnguoinhan(int idbantin, List<int> iduser)
         {
             foreach (int id in iduser)
             {
                 bantin_gui users = new bantin_gui();
                 int dem = (from tk in data.bantin_guis
                                  select tk).ToList().Last().idguibantin;
                 if (dem == 0)
                     users.idguibantin = 1;
                 else
                     users.idguibantin = dem + 1;

                 users.idbantin = idbantin;
                 users.iduser = id;
                 users.dagui = false;
                 users.daxem = false;
                 users.daphanhoi = false;
                 data.bantin_guis.InsertOnSubmit(users);
                 data.SubmitChanges();
             }

         }

         public void Capnhatnguoinhan(int idbantin, List<int> iduser)
         {
             List<bantin_gui> xoa = (from tk in data.bantin_guis
                                     where tk.idbantin == idbantin
                                     select tk).ToList();
             data.bantin_guis.DeleteAllOnSubmit(xoa);
             data.SubmitChanges();

             foreach (int id in iduser)
             {
                 bantin_gui users = new bantin_gui();
                 int dem = (from tk in data.bantin_guis
                            select tk).ToList().Last().idguibantin;
                 if (dem == 0)
                     users.idguibantin = 1;
                 else
                     users.idguibantin = dem + 1;

                 users.idbantin = idbantin;
                 users.iduser = id;
                 users.dagui = false;
                 users.daxem = false;
                 users.daphanhoi = false;
                 data.bantin_guis.InsertOnSubmit(users);
                 data.SubmitChanges();
             }

         }

         public List<int> Laynguoinhan(List<int> idnhomnhan)
         {
             List<int> ketqua = new List<int>();
             foreach (int id in idnhomnhan)
             {
                 bantin_kqnhom ketquanhom = new bantin_kqnhom();
                 List<int> nguoidung = (from tk in data.bantin_kqnhoms
                                        where tk.idnhombantin == id
                                        select tk.iduser).ToList();
                 foreach (int item in nguoidung)
                 {
                     if (!ketqua.Contains(item))
                         ketqua.Add(item);
                 }
             }
             return ketqua;
         }
        #endregion
    }
}
