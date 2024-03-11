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
}
