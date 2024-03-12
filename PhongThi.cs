using System;
using System.Collections.Generic;

namespace ThiSinh
{
    public class PhongThi
    {
        public string MaPhong { get; set; }
        public List<ThiSinh> DanhSachThiSinh { get; set; }
        public int SoLuongThiSinh { get; set; }

        public PhongThi(string maPhong, int maxSoLuongThiSinh)
        {
            MaPhong = maPhong;
            DanhSachThiSinh = new List<ThiSinh>(maxSoLuongThiSinh);
            // Khởi tạo List với số lượng tối đa được chỉ định
        }

        // Cập nhật hàm tạo để chấp nhận mã phòng và số lượng tối đa từ người dùng
        public PhongThi()
        {
            Console.WriteLine("Nhập mã phòng thi: ");
            MaPhong = Console.ReadLine();
            Console.WriteLine("Nhập số lượng tối đa của phòng thi: ");
            int maxSoLuongThiSinh = int.Parse(Console.ReadLine());
            DanhSachThiSinh = new List<ThiSinh>(maxSoLuongThiSinh);
            // Khởi tạo List với số lượng tối đa được chỉ định
        }

        public void ThemThiSinh(ThiSinh thiSinh)
        {
            if (SoLuongThiSinh < DanhSachThiSinh.Capacity) // Kiểm tra xem danh sách đã đầy chưa
            {
                DanhSachThiSinh.Add(thiSinh); // Thêm thí sinh vào danh sách
            }
            else
            {
                Console.WriteLine("Phòng thi đã đầy, không thể thêm thí sinh.");
            }
        }

        public void XuatDanhSachThiSinh()
        {
            int i = 0;
            foreach (ThiSinh thiSinh in DanhSachThiSinh)
            {
                Console.WriteLine($"\n---Thí sinh {i + 1}---");
                NhapXuatThiSinh.XuatThiSinh(thiSinh);
                i++;
            }
        }
    }
}
