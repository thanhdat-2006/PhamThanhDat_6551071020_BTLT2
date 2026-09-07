using System;

namespace TinhLuongNhanVien
{
    public class NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private decimal _luongCoBan;
        private int _soNgayLam;
        private int _soNgayNghiPhep;

        public string MaNV
        {
            get => _maNV;
            set => _maNV = value;
        }

        public string HoTen
        {
            get => _hoTen;
            set => _hoTen = value;
        }

        public decimal LuongCoBan
        {
            get => _luongCoBan;
            set
            {
                if (value >= 0)
                    _luongCoBan = value;
                else
                    _luongCoBan = 0;
            }
        }

        public int SoNgayLam
        {
            get => _soNgayLam;
            set
            {
                if (value >= 0 && value <= 31)
                    _soNgayLam = value;
                else
                    _soNgayLam = 0;
            }
        }

        public int SoNgayNghiPhep
        {
            get => _soNgayNghiPhep;
            set => _soNgayNghiPhep = value >= 0 ? value : 0;
        }

        public decimal LuongThucNhan
        {
            get
            {
                decimal khauTruBHXH = LuongCoBan * 0.08m;
                decimal luongTheoNgay = (LuongCoBan / 26m) * SoNgayLam;
                return luongTheoNgay - khauTruBHXH;
            }
        }

        public NhanVien()
        {
            _maNV = "ChuaDat";
            _hoTen = "ChuaDat";
            _luongCoBan = 0;
            _soNgayLam = 0;
            _soNgayNghiPhep = 0;
        }

        public NhanVien(string maNV, string hoTen, decimal luongCoBan, int soNgayLam, int soNgayNghiPhep)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luongCoBan;
            SoNgayLam = soNgayLam;
            SoNgayNghiPhep = soNgayNghiPhep;
        }

        public NhanVien(string maNV, string hoTen, decimal luong = 5_000_000m, int soNgayLam = 26)
        {
            MaNV = maNV;
            HoTen = hoTen;
            LuongCoBan = luong;
            SoNgayLam = soNgayLam;
            _soNgayNghiPhep = 0;
        }

        public decimal TinhThuong() => 0m;

        public decimal TinhThuong(decimal heSo) => LuongCoBan * heSo;

        public decimal TinhThuong(decimal heSo, bool coPhucLoi)
        {
            decimal thuong = LuongCoBan * heSo;
            if (coPhucLoi)
            {
                thuong += 500_000m;
            }
            return thuong;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Mã NV: {MaNV} | Họ Tên: {HoTen} | Lương CB: {LuongCoBan:N0} VNĐ | Ngày công: {SoNgayLam} | Thực nhận: {LuongThucNhan:N0} VNĐ");
        }
    }
}