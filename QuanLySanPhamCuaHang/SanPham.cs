using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPham
    {
        private string _maSP;
        private string _tenSP;
        private decimal _gia;
        private int _soLuongTon;

        public string MaSP
        {
            get => _maSP;
            set => _maSP = value;
        }

        public string TenSP
        {
            get => _tenSP;
            set => _tenSP = value;
        }

        public decimal Gia
        {
            get => _gia;
            set => _gia = value >= 0 ? value : 0;
        }

        public int SoLuongTon
        {
            get => _soLuongTon;
            set => _soLuongTon = value >= 0 ? value : 0;
        }

        public SanPham()
        {
        }

        public SanPham(string maSP, string tenSP, decimal gia, int soLuongTon)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _gia = gia >= 0 ? gia : 0;
            _soLuongTon = soLuongTon >= 0 ? soLuongTon : 0;
        }

        public virtual decimal TinhGiaBan()
        {
            return _gia;
        }

        public virtual string MoTa()
        {
            return $"[Sản phẩm thông thường] Mã: {MaSP} | Tên: {TenSP} | Lượng tồn: {SoLuongTon} | Giá niêm yết: {Gia:N0} VNĐ";
        }
    }
}