﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BookEntity : DbContext
    {
        public BookEntity()
            : base("name=BookEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CTPN> CTPNs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
    
        public virtual int MAKH_AUTO(ObjectParameter mAKH)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MAKH_AUTO", mAKH);
        }
    
        public virtual int MALOAI_AUTO(ObjectParameter mALOAI)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MALOAI_AUTO", mALOAI);
        }
    
        public virtual int MANXB_AUTO(ObjectParameter mASACH)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MANXB_AUTO", mASACH);
        }
    
        public virtual int MASACH_AUTO(ObjectParameter mASACH)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MASACH_AUTO", mASACH);
        }
    
        public virtual int MATG_AUTO(ObjectParameter mATG)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MATG_AUTO", mATG);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int THEMCTHD(Nullable<int> mahd, string masach, Nullable<int> giatien, Nullable<int> soluong, Nullable<int> tongtien)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var giatienParameter = giatien.HasValue ?
                new ObjectParameter("giatien", giatien) :
                new ObjectParameter("giatien", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMCTHD", mahdParameter, masachParameter, giatienParameter, soluongParameter, tongtienParameter);
        }
    
        public virtual int THEMCTPN(Nullable<int> sOPN, string masach, Nullable<int> gianhap, Nullable<int> soluong)
        {
            var sOPNParameter = sOPN.HasValue ?
                new ObjectParameter("SOPN", sOPN) :
                new ObjectParameter("SOPN", typeof(int));
    
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var gianhapParameter = gianhap.HasValue ?
                new ObjectParameter("gianhap", gianhap) :
                new ObjectParameter("gianhap", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMCTPN", sOPNParameter, masachParameter, gianhapParameter, soluongParameter);
        }
    
        public virtual int THEMHOADON(Nullable<int> mAHD, string makh, Nullable<System.DateTime> ngaylap, Nullable<int> tongtien)
        {
            var mAHDParameter = mAHD.HasValue ?
                new ObjectParameter("MAHD", mAHD) :
                new ObjectParameter("MAHD", typeof(int));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMHOADON", mAHDParameter, makhParameter, ngaylapParameter, tongtienParameter);
        }
    
        public virtual int THEMKH(string tenkh, string sdt, string diachi)
        {
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMKH", tenkhParameter, sdtParameter, diachiParameter);
        }
    
        public virtual int THEMNXB(string tennxb, string diachi)
        {
            var tennxbParameter = tennxb != null ?
                new ObjectParameter("tennxb", tennxb) :
                new ObjectParameter("tennxb", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMNXB", tennxbParameter, diachiParameter);
        }
    
        public virtual int THEMPHIEUNHAP(Nullable<int> sOPN, string manxb, Nullable<System.DateTime> ngaylap, Nullable<int> tongtien)
        {
            var sOPNParameter = sOPN.HasValue ?
                new ObjectParameter("SOPN", sOPN) :
                new ObjectParameter("SOPN", typeof(int));
    
            var manxbParameter = manxb != null ?
                new ObjectParameter("manxb", manxb) :
                new ObjectParameter("manxb", typeof(string));
    
            var ngaylapParameter = ngaylap.HasValue ?
                new ObjectParameter("ngaylap", ngaylap) :
                new ObjectParameter("ngaylap", typeof(System.DateTime));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMPHIEUNHAP", sOPNParameter, manxbParameter, ngaylapParameter, tongtienParameter);
        }
    
        public virtual int THEMSACH(string tensach, string matg, string matl, string nxb, Nullable<int> gia, Nullable<int> soluong)
        {
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var matgParameter = matg != null ?
                new ObjectParameter("matg", matg) :
                new ObjectParameter("matg", typeof(string));
    
            var matlParameter = matl != null ?
                new ObjectParameter("matl", matl) :
                new ObjectParameter("matl", typeof(string));
    
            var nxbParameter = nxb != null ?
                new ObjectParameter("nxb", nxb) :
                new ObjectParameter("nxb", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("gia", gia) :
                new ObjectParameter("gia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMSACH", tensachParameter, matgParameter, matlParameter, nxbParameter, giaParameter, soluongParameter);
        }
    
        public virtual int THEMTACGIA(string tentacgia, string sdt, string diachi)
        {
            var tentacgiaParameter = tentacgia != null ?
                new ObjectParameter("tentacgia", tentacgia) :
                new ObjectParameter("tentacgia", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMTACGIA", tentacgiaParameter, sdtParameter, diachiParameter);
        }
    
        public virtual int THEMTHELOAI(string tentheloai, string motatl)
        {
            var tentheloaiParameter = tentheloai != null ?
                new ObjectParameter("tentheloai", tentheloai) :
                new ObjectParameter("tentheloai", typeof(string));
    
            var motatlParameter = motatl != null ?
                new ObjectParameter("motatl", motatl) :
                new ObjectParameter("motatl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("THEMTHELOAI", tentheloaiParameter, motatlParameter);
        }
    
        public virtual int update_khachhang(string makh, string tenkh, string sDT, string diachi)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("Tenkh", tenkh) :
                new ObjectParameter("Tenkh", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("Diachi", diachi) :
                new ObjectParameter("Diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_khachhang", makhParameter, tenkhParameter, sDTParameter, diachiParameter);
        }
    
        public virtual int update_nhaxuatban(string manxb, string tennxb, string diachi)
        {
            var manxbParameter = manxb != null ?
                new ObjectParameter("manxb", manxb) :
                new ObjectParameter("manxb", typeof(string));
    
            var tennxbParameter = tennxb != null ?
                new ObjectParameter("Tennxb", tennxb) :
                new ObjectParameter("Tennxb", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_nhaxuatban", manxbParameter, tennxbParameter, diachiParameter);
        }
    
        public virtual int update_sach(string masach, string tensach, string matg, string matheloai, string manxb, Nullable<int> gia)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var matgParameter = matg != null ?
                new ObjectParameter("matg", matg) :
                new ObjectParameter("matg", typeof(string));
    
            var matheloaiParameter = matheloai != null ?
                new ObjectParameter("matheloai", matheloai) :
                new ObjectParameter("matheloai", typeof(string));
    
            var manxbParameter = manxb != null ?
                new ObjectParameter("manxb", manxb) :
                new ObjectParameter("manxb", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("gia", gia) :
                new ObjectParameter("gia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_sach", masachParameter, tensachParameter, matgParameter, matheloaiParameter, manxbParameter, giaParameter);
        }
    
        public virtual int update_tacgia(string matg, string tentg, string sDT, string diachi)
        {
            var matgParameter = matg != null ?
                new ObjectParameter("matg", matg) :
                new ObjectParameter("matg", typeof(string));
    
            var tentgParameter = tentg != null ?
                new ObjectParameter("Tentg", tentg) :
                new ObjectParameter("Tentg", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("Diachi", diachi) :
                new ObjectParameter("Diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_tacgia", matgParameter, tentgParameter, sDTParameter, diachiParameter);
        }
    
        public virtual int update_theloai(string maloai, string tentl, string mota)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var tentlParameter = tentl != null ?
                new ObjectParameter("Tentl", tentl) :
                new ObjectParameter("Tentl", typeof(string));
    
            var motaParameter = mota != null ?
                new ObjectParameter("mota", mota) :
                new ObjectParameter("mota", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_theloai", maloaiParameter, tentlParameter, motaParameter);
        }
    }
}