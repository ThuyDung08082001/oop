using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    class QuanLyHocPhi
    {
        public static NgaySinh NhapNgaySinh()
        {

            NgaySinh ns = new NgaySinh();
            Console.WriteLine("nhap ngay sinh");
            ns.Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap thang sinh");
            ns.Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nam sinh");
            ns.Nam = int.Parse(Console.ReadLine());
            return ns;

        }
        public static SinhVienTrungCap NhapSinhVienTrungCap()
        {
            SinhVienTrungCap sv = new SinhVienTrungCap();
            Console.WriteLine("nhap ma sinh vien:");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine("nhap ten sinh vien:");
            sv.TenSV = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh:");
            sv.GioiTinh = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh:");
            sv.NgaySinh = NhapNgaySinh();
            Console.WriteLine("nhap que quan:");
            sv.QueQuan = Console.ReadLine();
            Console.WriteLine("nhap bao hiem y te:");
            sv.BaoHiemYTe = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap phi thu phu");
            sv.ThuPhu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap hoc phi hoc ky:");
            sv.HocPhiHocKy = int.Parse(Console.ReadLine());
            return sv;
        }
        public static SinhVienCaoDang NhapSinhVienCaoDang()
        {
            SinhVienCaoDang sv = new SinhVienCaoDang();
            Console.WriteLine("nhap ma sinh vien:");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine("nhap ten sinh vien:");
            sv.TenSV = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh:");
            sv.GioiTinh = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh:");
            sv.NgaySinh = NhapNgaySinh();
            Console.WriteLine("nhap que quan:");
            sv.QueQuan = Console.ReadLine();
            Console.WriteLine("nhap bao hiem y te:");
            sv.BaoHiemYTe = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap phi thu phu");
            sv.ThuPhu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so tin chi ly thuyet:");
            sv.SoTinChiLyThuyet = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia mon hoc ly thuyet:");
            sv.DonGiaMonHocLyThuyet = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so tin chi thuc hanh:");
            sv.SoTinChiThucHanh = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia mon hoc thuc hanh:");
            sv.DonGiaMonThucHanh = int.Parse(Console.ReadLine());
            return sv;
        }
        public static SinhVien[] NhapDanhSachSinhVien()
        {
            SinhVien[] arr = new SinhVien[0];
            bool check = true;
            while (check)
            {
                SinhVien sv;
                Console.Write("1. Sinh Vien Trung Cap\n2.Sinh Vien Cao Dang \nesc. Thoat\n");
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1':
                        sv = NhapSinhVienTrungCap();
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = sv;
                        break;
                    case '2':
                        sv = NhapSinhVienCaoDang();
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = sv;
                        break;
                    case (char)ConsoleKey.Escape:
                        check = false;
                        break;
                    default:

                        break;
                }
            }
            return arr;
        }
        public static string XuatDanhSachSinhVien(SinhVien[] sinhVien)
        {

            foreach (var item in sinhVien)
            {
                Console.WriteLine(item.toString());
                Console.WriteLine("*******************************");
            }
            return "";
        }
        public static SinhVien[] TimTheoMaSinhVien(SinhVien[] arr, string maSV)
        {
            SinhVien[] arrMaSV = new SinhVien[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].MaSV.Equals(maSV))
                {
                    Array.Resize(ref arrMaSV, arrMaSV.Length + 1);
                    arrMaSV[arrMaSV.Length - 1] = arr[i];
                }
            }
            return arrMaSV;
        }
    }

}
