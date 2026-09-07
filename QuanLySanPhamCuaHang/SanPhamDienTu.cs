using System;

namespace QuanLySanPhamCuaHang
{
    public class SanPhamDienTu : SanPham
    {
        private int _baoHanhThang;
        private string _hangSanXuat;

        public int BaoHanhThang
        {
            get => _baoHanhThang;
            set => _baoHanhThang = value >= 0 ? value : 0;
        }

        public string HangSanXuat
        {
            get => _hangSanXuat;
            set => _hangSanXuat = value;
        }

        public SanPhamDienTu() : base()
        {
        }

        public SanPhamDienTu(string maSP, string tenSP, decimal gia, int soLuongTon, int baoHanhThang, string hangSanXuat)
            : base(maSP, tenSP, gia, soLuongTon)
        {
            _baoHanhThang = baoHanhThang >= 0 ? baoHanhThang : 0;
            _hangSanXuat = hangSanXuat;
        }

        public override decimal TinhGiaBan()
        {
            if (_baoHanhThang > 12)
            {
                return Gia * 1.1m;
            }
            return Gia;
        }

        public override string MoTa()
        {
            return $"[Điện tử] Mã: {MaSP} | Tên: {TenSP} | Hãng: {_hangSanXuat} | BH: {_baoHanhThang} tháng | Giá gốc: {Gia:N0} VNĐ | Lượng tồn: {SoLuongTon}";
        }
    }
}