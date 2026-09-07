using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamThucPham : SanPham
    {
        private DateTime _ngayHetHan;
        private int _nhietDoBaoQuan;

        public DateTime NgayHetHan
        {
            get => _ngayHetHan;
            set => _ngayHetHan = value;
        }

        public int NhietDoBaoQuan
        {
            get => _nhietDoBaoQuan;
            set => _nhietDoBaoQuan = value;
        }

        public SanPhamThucPham() : base()
        {
        }

        public SanPhamThucPham(string maSP, string tenSP, decimal gia, int soLuongTon, DateTime ngayHetHan, int nhietDoBaoQuan)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _ngayHetHan = ngayHetHan;
            _nhietDoBaoQuan = nhietDoBaoQuan;
        }

        public override decimal TinhGiaBan()
        {
            TimeSpan soNgayConLai = _ngayHetHan.Date - DateTime.Now.Date;
            if (soNgayConLai.TotalDays <= 3 && soNgayConLai.TotalDays >= 0)
            {
                return Gia * 0.7m;
            }
            return Gia;
        }

        public override string MoTa()
        {
            return $"[Thực phẩm] Mã: {MaSP} | Tên: {TenSP} | HSD: {_ngayHetHan:dd/MM/yyyy} | BQ: {_nhietDoBaoQuan}°C | Giá gốc: {Gia:N0} VNĐ | Lượng tồn: {SoLuongTon}";
        }
    }
}