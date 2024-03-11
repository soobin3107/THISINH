using System;

namespace ThiSinh
{
    public class PhongThi
    {
        public string MaPhong { get; set; }
        public ThiSinh[] DanhSachThiSinh { get; set; }
        public int SoLuongThiSinh { get; set; }

        public PhongThi(string maPhong, int maxSoLuongThiSinh)
        {
            MaPhong = maPhong;
            DanhSachThiSinh = new ThiSinh[maxSoLuongThiSinh];
            SoLuongThiSinh = 0;
        }

        public void ThemThiSinh(ThiSinh thiSinh)
        {
            if (SoLuongThiSinh < DanhSachThiSinh.Length)
            {
                DanhSachThiSinh[SoLuongThiSinh] = thiSinh;
                SoLuongThiSinh++;
            }
            else
            {
                Console.WriteLine("Phòng thi đã đầy, không thể thêm thí sinh.");
            }
        }

        public void XuatDanhSachThiSinh()
        {
            Console.WriteLine($"\nDanh sách thí sinh trong phòng {MaPhong}");
            for (int i = 0; i < SoLuongThiSinh; i++)
            {
                Console.WriteLine($"---Thí sinh {i + 1}---");
                NhapXuatThiSinh.XuatThiSinh(DanhSachThiSinh[i]);
                Console.WriteLine();
            }
        }
    }
}
