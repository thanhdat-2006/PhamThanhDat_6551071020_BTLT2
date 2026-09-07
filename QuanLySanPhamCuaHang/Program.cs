using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPhamCuaHang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("MSSV: 6551071020");
            Console.WriteLine("BÀI TẬP: QUẢN LÝ SẢN PHẨM CỬA HÀNG\n");

            List<SanPham> danhSachSanPham = new List<SanPham>
            {
                new SanPham
                {
                    MaSP = "SP001",
                    TenSP = "Sổ tay da ghi chép",
                    Gia = 80_000m,
                    SoLuongTon = 50
                },
                new SanPhamThucPham
                {
                    MaSP = "TP001",
                    TenSP = "Sữa tươi thanh trùng",
                    Gia = 35_000m,
                    SoLuongTon = 20,
                    NgayHetHan = DateTime.Now.AddDays(2),
                    NhietDoBaoQuan = 4
                },
                new SanPhamThucPham
                {
                    MaSP = "TP002",
                    TenSP = "Phô mai lát",
                    Gia = 60_000m,
                    SoLuongTon = 15,
                    NgayHetHan = DateTime.Now.AddDays(15),
                    NhietDoBaoQuan = 5
                },
                new SanPhamDienTu
                {
                    MaSP = "DT001",
                    TenSP = "Tai nghe Gaming không dây",
                    Gia = 1_500_000m,
                    SoLuongTon = 8,
                    BaoHanhThang = 24,
                    HangSanXuat = "Logitech"
                },
                new SanPhamDienTu
                {
                    MaSP = "DT002",
                    TenSP = "Cáp sạc nhanh Type-C",
                    Gia = 150_000m,
                    SoLuongTon = 30,
                    BaoHanhThang = 6,
                    HangSanXuat = "Anker"
                }
            };

            Console.WriteLine("=== DANH SÁCH SẢN PHẨM & TÍNH GIÁ BÁN (RUNTIME POLYMORPHISM) ===\n");

            decimal tongGiaTriKhoHang = 0;

            foreach (SanPham sp in danhSachSanPham)
            {
                Console.WriteLine(sp.MoTa());
                Console.WriteLine($"-> Giá bán thực tế: {sp.TinhGiaBan():N0} VNĐ\n");

                tongGiaTriKhoHang += sp.Gia * sp.SoLuongTon;
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"TỔNG GIÁ TRỊ KHO HÀNG (Giá gốc x Tồn kho): {tongGiaTriKhoHang:N0} VNĐ");
            Console.WriteLine("--------------------------------------------------");

            Console.ReadKey();
        }
    }
}