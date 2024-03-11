using System;

namespace ThiSinh
{
    public class Program
    {
        // Hàm nhập danh sách thí sinh vào phòng thi
        static void NhapDSTS(PhongThi phongThi)
        {
            Console.Write("\nNhập số lượng Thí Sinh: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ThiSinh thiSinh = new ThiSinh();
                Console.WriteLine("---------------------------");
                Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                NhapXuatThiSinh.NhapThiSinh(ref thiSinh);
                phongThi.ThemThiSinh(thiSinh); // Thêm thí sinh vào phòng thi
            }
        }

        // Hàm xuất danh sách thí sinh trong phòng thi
        static void XuatDSTS(PhongThi phongThi)
        {
            phongThi.XuatDanhSachThiSinh(); // Xuất danh sách thí sinh trong phòng thi
        }

        // Hàm Chỉnh sửa Danh sách thí sinh trong phòng thi
        static void ChinhSuaDSTS(PhongThi phongThi)
        {
            Console.Write("\nNhập mã thí sinh cần chỉnh sửa: ");
            string maThiSinh = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < phongThi.SoLuongThiSinh; i++)
            {
                if (phongThi.DanhSachThiSinh[i].MaThiSinh == maThiSinh)
                {
                    Console.WriteLine("--Nhập thông tin mới--");
                    NhapXuatThiSinh.NhapThiSinh(ref phongThi.DanhSachThiSinh[i]);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã số đã nhập.");
            }
        }

        // Hàm xóa thông tin của một thí sinh trong phòng thi
        static void XoaDSTS(PhongThi phongThi)
        {
            Console.Write("\nNhập mã thí sinh cần xóa: ");
            string maThiSinh = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < phongThi.SoLuongThiSinh; i++)
            {
                if (phongThi.DanhSachThiSinh[i].MaThiSinh == maThiSinh)
                {
                    for (int j = i; j < phongThi.SoLuongThiSinh - 1; j++)
                    {
                        phongThi.DanhSachThiSinh[j] = phongThi.DanhSachThiSinh[j + 1];
                    }
                    phongThi.SoLuongThiSinh--;
                    found = true;
                    Console.WriteLine("Xóa thành công.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã số đã nhập.");
            }
        }


        // Hàm Main để chạy chương trình
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PhongThi phongA = new PhongThi("A", 50); // Tạo một phòng thi có tên A với sức chứa 50 thí sinh

            int luaChon;
            do
            {
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Xuất dữ liệu");
                Console.WriteLine("3. Chỉnh sửa dữ liệu");
                Console.WriteLine("4. Xóa dữ liệu");
                Console.WriteLine("5. Thoát chương trình");
                Console.Write("Nhập lựa chọn của bạn: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        NhapDSTS(phongA);
                        break;
                    case 2:
                        XuatDSTS(phongA);
                        break;
                    case 3:
                        ChinhSuaDSTS(phongA);
                        break;
                    case 4:
                        XoaDSTS(phongA);
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (luaChon != 5);
        }
    }
}
