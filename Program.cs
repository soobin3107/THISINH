using System;

namespace ThiSinh
{
    public class Program
    {
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

        // Hàm xuất thông tin của thí sinh
        static void XuatDSTS(PhongThi phongThi)
        {
            if (phongThi.DanhSachThiSinh != null && phongThi.DanhSachThiSinh.Count > 0)
            {
                phongThi.XuatDanhSachThiSinh();
            }
            else
            {
                Console.WriteLine("Không có thí sinh nào trong phòng thi.");
            }
        }


        // Hàm Chỉnh sửa danh sách thí sinh trong phòng thi
        static void ChinhSuaDSTS(PhongThi phongThi)
        {
            Console.Write("\nNhập mã thí sinh cần chỉnh sửa: ");
            string maThiSinh = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < phongThi.DanhSachThiSinh.Count; i++)
            {
                if (phongThi.DanhSachThiSinh[i].MaThiSinh == maThiSinh)
                {
                    Console.WriteLine("--Nhập thông tin mới--");
                    ThiSinh thiSinh = phongThi.DanhSachThiSinh[i];
                    NhapXuatThiSinh.NhapThiSinh(ref thiSinh);
                    phongThi.DanhSachThiSinh[i] = thiSinh;
                    found = true;
                    Console.WriteLine("Chỉnh sửa thành công.");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã số đã nhập.");
            }
        }

        // Hàm thay đổi phòng thi của thí sinh
        static void ThayDoiPhongThi(PhongThi phongThi)
        {
            Console.Write("\nNhập mã thí sinh cần thay đổi phòng thi: ");
            string maThiSinh = Console.ReadLine();
            Console.Write("Nhập phòng thi mới: ");
            string phongThiMoi = Console.ReadLine();
            foreach (ThiSinh thiSinh in phongThi.DanhSachThiSinh)
            {
                if (thiSinh.MaThiSinh == maThiSinh)
                {
                    thiSinh.MaPhong = phongThiMoi;
                    Console.WriteLine("Thay đổi phòng thi thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy Thí Sinh có mã số đã nhập.");
        }

        // Hàm xóa thông tin của một thí sinh trong phòng thi
        static void XoaDSTS(PhongThi phongThi)
        {
            Console.Write("\nNhập mã thí sinh cần xóa: ");
            string maThiSinh = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < phongThi.DanhSachThiSinh.Count; i++)
            {
                if (phongThi.DanhSachThiSinh[i].MaThiSinh == maThiSinh)
                {
                    phongThi.DanhSachThiSinh.RemoveAt(i); // Xóa thí sinh khỏi danh sách
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

            int soLuongToiDa;

            // Nhập số lượng thí sinh tối đa
            Console.Write("Nhập số lượng thí sinh tối đa: ");
            soLuongToiDa = int.Parse(Console.ReadLine());

            PhongThi phongA = new PhongThi(" ", soLuongToiDa);

            int luaChon;
            do
            {
                Console.WriteLine("\n---MENU---");
                Console.WriteLine("1. Nhập Thông Tin Thí Sinh");
                Console.WriteLine("2. Xuất Thông Tin Thí Sinh");
                Console.WriteLine("3. Chỉnh Sửa Thông Tin Thí Sinh Trong Phòng Thi");
                Console.WriteLine("4. Thay đổi Phòng Thi của Thí Sinh");
                Console.WriteLine("5. Xóa Dữ Liệu của Thí Sinh");
                Console.WriteLine("6. Thoát Chương Trình");
                Console.Write("Nhập Lựa Chọn của Bạn: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("\n===============================");
                        NhapDSTS(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 2:
                        Console.WriteLine("\n===============================");
                        XuatDSTS(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 3:
                        Console.WriteLine("\n===============================");
                        ChinhSuaDSTS(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 4:
                        Console.WriteLine("\n===============================");
                        ThayDoiPhongThi(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 5:
                        Console.WriteLine("\n===============================");
                        XoaDSTS(phongA);
                        Console.WriteLine("\n===============================");
                        break;
                    case 6:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (luaChon != 6);
        }

    }
}
