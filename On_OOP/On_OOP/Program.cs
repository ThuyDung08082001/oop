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

            SinhVien[] sinhVien = QuanLyHocPhi.NhapDanhSachSinhVien();
            Console.WriteLine(QuanLyHocPhi.XuatDanhSachSinhVien(sinhVien));

            SinhVien[] maSV = QuanLyHocPhi.TimTheoMaSinhVien(sinhVien, "001");
            Console.WriteLine("sinh vien co ma 001:");

            foreach (var item in maSV)
            {
                Console.WriteLine(item.toString());
            }
            

        }
    }
}
