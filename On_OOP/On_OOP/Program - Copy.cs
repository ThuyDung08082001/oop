using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> sv = new List<SinhVien>(0);
            QuanLyHocPhi.NhapDanhSachSinhVien(ref sv);
            QuanLyHocPhi.XuatDanhSachSinhVien(sv);
            SinhVien[] sinhVien = new SinhVien[0];
            SinhVien[] maSV = QuanLyHocPhi.TimTheoMaSinhVien(sinhVien, "001");
            Console.WriteLine("phuong tien co ma 001:");
            foreach (var item in maSV)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
