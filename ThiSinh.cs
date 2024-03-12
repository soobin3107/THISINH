using System;

namespace ThiSinh
{
    // Class ThiSinh để định nghĩa thông tin của một thí sinh
    public class ThiSinh
    {
        public string MaThiSinh { get; set; }
        public float DiemToan { get; set; }
        public float DiemLy { get; set; }
        public float DiemHoa { get; set; }
        public float DiemTong { get; set; }
        public string TenThiSinh { get; set; }
        public string MaPhong { get; set; }
    }

    // Class Nhập/Xuất để quản lý việc nhập và xuất thông tin thí sinh
    public class NhapXuatThiSinh
    {
        // Hàm nhập thông tin của một thí sinh
        public static void NhapThiSinh(ref ThiSinh thiSinh)
        {
            Console.Write("Nhập mã thí sinh: ");
            thiSinh.MaThiSinh = Console.ReadLine();
            Console.Write("Nhập tên thí sinh: ");
            thiSinh.TenThiSinh = Console.ReadLine();
            Console.Write("Nhập phòng thi: ");
            thiSinh.MaPhong = Console.ReadLine(); // Nhập thông tin về phòng thi
            Console.Write("Nhập Điểm Toán: ");
            thiSinh.DiemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Lý: ");
            thiSinh.DiemLy = float.Parse(Console.ReadLine());
            Console.Write("Nhập Điểm Hóa: ");
            thiSinh.DiemHoa = float.Parse(Console.ReadLine());

            thiSinh.DiemTong = thiSinh.DiemToan + thiSinh.DiemLy + thiSinh.DiemHoa;
        }

        // Hàm xuất thông tin của một thí sinh
        public static void XuatThiSinh(ThiSinh thiSinh)
        {
            Console.WriteLine($"Mã Thí Sinh: {thiSinh.MaThiSinh}");
            Console.WriteLine($"Họ Tên: {thiSinh.TenThiSinh}");
            Console.WriteLine($"Phòng thi: {thiSinh.MaPhong}");
            Console.WriteLine($"Điểm Toán: {thiSinh.DiemToan}");
            Console.WriteLine($"Điểm Lý: {thiSinh.DiemLy}");
            Console.WriteLine($"Điểm Hóa: {thiSinh.DiemHoa}");
            Console.WriteLine($"Điểm Tổng: {thiSinh.DiemTong}");
        }
    }
}
