using System;

namespace ThiSinh
{
    // Class ThiSinh để định nghĩa thông tin của một thí sinh
    public class ThiSinh
    {
        public string MaThiSinh { get; set; }
        public string HoTen { get; set; }
        public float DiemToan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float DiemTong { get; set; }
    }

    // Class Nhập/Xuất để quản lý việc nhập và xuất thông tin thí sinh
    public class NhapXuatThiSinh
    {
        // Hàm nhập thông tin của một thí sinh
        public static void NhapThiSinh(ref ThiSinh a)
        {
            Console.Write("Nhập Mã Thí Sinh: ");
            a.MaThiSinh = Console.ReadLine();

            Console.Write("Nhập Họ Tên Thí Sinh: ");
            a.HoTen = Console.ReadLine();

            Console.Write("Nhập Điểm Toán: ");
            a.DiemToan = float.Parse(Console.ReadLine());

            Console.Write("Nhập Điểm Lý: ");
            a.DiemLy = float.Parse(Console.ReadLine());

            Console.Write("Nhập Điểm Hóa: ");
            a.DiemHoa = float.Parse(Console.ReadLine());

            a.DiemTong = a.DiemToan + a.DiemLy + a.DiemHoa;
        }

        // Hàm xuất thông tin của một thí sinh
        public static void XuatThiSinh(ThiSinh a)
        {
            Console.WriteLine($"Mã Thí Sinh: {a.MaThiSinh}");
            Console.WriteLine($"Họ Tên: {a.HoTen}");
            Console.WriteLine($"Điểm Toán: {a.DiemToan}");
            Console.WriteLine($"Điểm Lý: {a.DiemLy}");
            Console.WriteLine($"Điểm Hóa: {a.DiemHoa}");
            Console.WriteLine($"Điểm Tổng: {a.DiemTong}");
        }
    }

    // Class Program để chứa phương thức Main và các thực thi khác
    public class Program
    {
        const int N = 100;

        // Hàm nhập danh sách thí sinh
        static void NhapDSTS(ThiSinh[] ts, ref int n)
        {
            Console.Write("\nNhập số lượng Thí Sinh: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ts[i] = new ThiSinh();
                Console.WriteLine("---------------------------");
                Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                NhapXuatThiSinh.NhapThiSinh(ref ts[i]);
            }
        }

        // Hàm xuất danh sách thí sinh
        static void XuatDSTS(ThiSinh[] ts, int n)
        {
            Console.WriteLine("\n=-=DANH SÁCH CÁC THÍ SINH=-=");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                NhapXuatThiSinh.XuatThiSinh(ts[i]);
                Console.WriteLine("---------------------------");
            }
        }

        // Hàm chỉnh sửa thông tin của một thí sinh
        static void ChinhSuaDSTS(ThiSinh[] ts, int n)
        {
            Console.Write("Nhập mã thí sinh cần chỉnh sửa: ");
            string maThiSinh = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (ts[i].MaThiSinh == maThiSinh)
                {
                    Console.WriteLine("Nhập thông tin mới:");
                    NhapXuatThiSinh.NhapThiSinh(ref ts[i]);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy thí sinh có mã số đã nhập.");
            }
        }

        // Hàm xóa thông tin của một thí sinh
        static void XoaDSTS(ThiSinh[] ts, ref int n)
        {
            Console.Write("Nhập mã thí sinh cần xóa: ");
            string maThiSinh = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (ts[i].MaThiSinh == maThiSinh)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        ts[j] = ts[j + 1];
                    }
                    n--;
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

            ThiSinh[] ts = new ThiSinh[N];
            int n = 0;

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
                        NhapDSTS(ts, ref n);
                        break;
                    case 2:
                        XuatDSTS(ts, n);
                        break;
                    case 3:
                        ChinhSuaDSTS(ts, n);
                        break;
                    case 4:
                        XoaDSTS(ts, ref n);
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
