using System;
using System.Text;

namespace TinhLuongNhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("MSSV: 6551071020");
            Console.WriteLine("BÀI TẬP: TÍNH LƯƠNG NHÂN VIÊN\n");

            NhanVien nv1 = new NhanVien();
            nv1.MaNV = "NV001";
            nv1.HoTen = "Nguyễn Văn An";
            nv1.LuongCoBan = 10_000_000m;
            nv1.SoNgayLam = 26;

            NhanVien nv2 = new NhanVien(
                maNV: "NV002",
                hoTen: "Trần Thị Bình",
                soNgayLam: 22
            );

            NhanVien nv3 = new NhanVien("NV003", "Lê Hoàng Cường", 15_000_000m, 25, 1);

            Console.WriteLine("=== DANH SÁCH NHÂN VIÊN ===");
            nv1.InThongTin();
            nv2.InThongTin();
            nv3.InThongTin();

            Console.WriteLine("\n=== SO SÁNH CÁC OVERLOAD TINH THƯỞNG (NV3) ===");
            decimal heSo = 1.5m;

            decimal thuong1 = nv3.TinhThuong();
            decimal thuong2 = nv3.TinhThuong(heSo);
            decimal thuong3 = nv3.TinhThuong(heSo, coPhucLoi: true);

            Console.WriteLine($"1. TinhThuong(): {thuong1,12:N0} VNĐ");
            Console.WriteLine($"2. TinhThuong({heSo}): {thuong2,12:N0} VNĐ");
            Console.WriteLine($"3. TinhThuong({heSo}, true): {thuong3,12:N0} VNĐ");

            Console.ReadKey();
        }
    }
}