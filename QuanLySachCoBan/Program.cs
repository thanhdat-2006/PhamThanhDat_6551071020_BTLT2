using System;
using System.Text;

namespace QuanLySachCoBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("MSSV: 6551071020");
            Console.WriteLine("BÀI TẬP: QUẢN LÝ SÁCH CƠ BẢN\n");

            Console.WriteLine("=== KHỞI TẠO ĐỐI TƯỢNG VỚI 3 CÁCH KHÁC NHAU ===");

            Sach sach1 = new Sach("MS001", "Lập trình C# căn bản", "Phạm Văn A", 2022, 120000);

            Sach sach2 = new Sach();
            sach2.TenSach = "Cấu trúc dữ liệu và giải thuật";
            sach2.TacGia = "Trần Thị B";
            sach2.NamXuatBan = 2020;

            Sach sach3 = new Sach
            {
                TenSach = "Nhập môn Hệ điều hành",
                TacGia = "Lê Văn C",
                NamXuatBan = 2024
            };

            Console.WriteLine("\n[Cách 1 - Constructor đầy đủ]");
            sach1.HienThiThongTin();

            Console.WriteLine("\n[Cách 2 - Constructor mặc định + gán Property]");
            sach2.HienThiThongTin();

            Console.WriteLine("\n[Cách 3 - Object Initializer]");
            sach3.HienThiThongTin();

            Console.WriteLine("\n=== KIỂM THỰC PHƯƠNG THỨC ToString() ===");
            Console.WriteLine(sach1.ToString());
            Console.WriteLine(sach2.ToString());
            Console.WriteLine(sach3.ToString());

            Console.WriteLine("\n=== KIỂM THỬ NGOẠI LỆ (NĂM XUẤT BẢN KHÔNG HỢP LỆ) ===");

            try
            {
                Console.WriteLine("Thử gán NamXuatBan = 1800 (< 1900)...");
                sach2.NamXuatBan = 1800;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bắt ngoại lệ thành công: {ex.Message}");
            }

            try
            {
                int namTuongLai = DateTime.Now.Year + 5;
                Console.WriteLine($"\nThử gán NamXuatBan = {namTuongLai} (> năm hiện tại)...");
                sach3.NamXuatBan = namTuongLai;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bắt ngoại lệ thành công: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}