using System;

namespace QuanLySachCoBan
{
    public class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _tacGia;
        private int _namXuatBan;
        private double _giaBan;

        public string MaSach
        {
            get => _maSach;
        }

        public string TenSach
        {
            get => _tenSach;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên sách không được để trống.");
                }
                _tenSach = value;
            }
        }

        public string TacGia
        {
            get => _tacGia;
            set => _tacGia = value;
        }

        public int NamXuatBan
        {
            get => _namXuatBan;
            set
            {
                int namHienTai = DateTime.Now.Year;
                if (value < 1900 || value > namHienTai)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Năm xuất bản phải nằm trong khoảng từ 1900 đến {namHienTai}.");
                }
                _namXuatBan = value;
            }
        }

        public double GiaBan
        {
            get => _giaBan;
            private set => _giaBan = value >= 0 ? value : 0;
        }

        public Sach()
        {
            _maSach = "CHUA_DAT";
            _tenSach = "Chưa có tên";
            _tacGia = "Chưa rõ";
            _namXuatBan = DateTime.Now.Year;
            _giaBan = 0;
        }

        public Sach(string maSach, string tenSach, string tacGia, int namXuatBan, double giaBan)
        {
            _maSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NamXuatBan = namXuatBan;
            GiaBan = giaBan;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Mã sách      : {MaSach}");
            Console.WriteLine($"Tên sách     : {TenSach}");
            Console.WriteLine($"Tác giả      : {TacGia}");
            Console.WriteLine($"Năm xuất bản : {NamXuatBan}");
            Console.WriteLine($"Giá bán      : {GiaBan:N0} VNĐ");
            Console.WriteLine("--------------------------------------------------");
        }

        public override string ToString()
        {
            return $"[{MaSach}] {TenSach} - {TacGia} ({NamXuatBan}) - {GiaBan:N0} VNĐ";
        }
    }
}