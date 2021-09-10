using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    class SinhVienTrungCap : SinhVien
    {
        private int _hocPhiHocKy;
        private static int _dem;
        public int HocPhiHocKy
        {
            get
            {
                return _hocPhiHocKy;
            }

            set
            {
                _hocPhiHocKy = value;
            }
        }

        public static int Dem
        {
            get
            {
                return _dem;
            }

        }

        public SinhVienTrungCap() : base()
        {
            this._hocPhiHocKy = 0;
            _dem++;
        }
        public SinhVienTrungCap(int hocPhi) : base()
        {
            this._hocPhiHocKy = hocPhi;
            _dem++;
        }
        public SinhVienTrungCap(int hocPhi, string maSV, string tenSV, string gioiTinh, NgaySinh ngaySinh, string queQuan, int BHYT, int thuPhu) : base(maSV, tenSV, gioiTinh, ngaySinh, queQuan, BHYT, thuPhu)
        {
            this._hocPhiHocKy = hocPhi;
            _dem++;
        }
        public override int GetHocPhi()
        {
            int hocPhi = this._hocPhiHocKy + this.BaoHiemYTe + this.ThuPhu;
            return hocPhi;
        }
        public override string toString()
        {
            string str = $"Sinh Vien Trung Cap.\n\t{base.toString()}\n\tHoc Phi Hoc Ky:{this._hocPhiHocKy}\n\tTong Hoc Phi:{this.GetHocPhi()}";
            return str;
        }
    }
}
