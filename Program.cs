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

        // Hàm Main để chạy chương trình
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ThiSinh[] ts = new ThiSinh[N];
            int n = 0;

            // Gọi hàm nhập danh sách thí sinh từ bên ngoài class
            NhapDSTS(ts, ref n);
            // Gọi hàm xuất danh sách thí sinh từ bên ngoài class
            XuatDSTS(ts, n);
            Console.ReadLine();
        }

        // Hàm nhập danh sách thí sinh
        static void NhapDSTS(ThiSinh[] ts, ref int n)
        {
            Console.Write("Nhập số lượng Thí Sinh: ");
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
            Console.WriteLine("=-=DANH SÁCH CÁC THÍ SINH=-=");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"---Thí Sinh thứ {i + 1}---");
                NhapXuatThiSinh.XuatThiSinh(ts[i]);
                Console.WriteLine("---------------------------");
            }
        }
    }
}
