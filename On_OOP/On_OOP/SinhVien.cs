using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    abstract class SinhVien
    {
        private string _maSV;
        private string _tenSV;
        private string _gioiTinh;
        private NgaySinh _ngaySinh;
        private string _queQuan;
        private static int _count;
        private int _baoHiemYTe;
        private int _thuPhu;

        public string MaSV
        {
            get
            {
                return _maSV;
            }

            set
            {
                _maSV = value;
            }
        }

        public string TenSV
        {
            get
            {
                return _tenSV;
            }

            set
            {
                _tenSV = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _gioiTinh;
            }

            set
            {
                _gioiTinh = value;
            }
        }

        public static int Count
        {
            get
            {
                return _count;
            }

        }

        internal NgaySinh NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

        public string QueQuan
        {
            get
            {
                return _queQuan;
            }

            set
            {
                _queQuan = value;
            }
        }

        public int BaoHiemYTe
        {
            get
            {
                return _baoHiemYTe;
            }

            set
            {
                _baoHiemYTe = value;
            }
        }

        public int ThuPhu
        {
            get
            {
                return _thuPhu;
            }

            set
            {
                _thuPhu = value;
            }
        }

        public SinhVien()
        {
            this._maSV = "";
            this._tenSV = "";
            this._gioiTinh = "";
            this._ngaySinh = new NgaySinh(0, 0, 0);
            this._queQuan = "";
            this._baoHiemYTe = 0;
            this._thuPhu = 0;
            _count++;
        }
        public SinhVien(string maSV, string tenSV, string gioiTinh, NgaySinh ngaySinh, string queQuan, int BHYT, int thuPhu)
        {
            this._maSV = maSV;
            this._tenSV = tenSV;
            this._gioiTinh = gioiTinh;
            this._ngaySinh = ngaySinh;
            this._queQuan = queQuan;
            this._baoHiemYTe = BHYT;
            this._thuPhu = thuPhu;
            _count++;
        }
        public virtual string toString()
        {
            string str = $"Ma Sinh Vien: {this._maSV}\n\tTen Sinh Vien: {this._tenSV}\n\tGioi Tinh: {this._gioiTinh}\n\tNgay Sinh: {NgaySinh.toString()}\n\tKhoa: {this._queQuan}\n\tBao Hiem Y Te: {this._baoHiemYTe}\n\tThu Phu{this._thuPhu}";
            return str;
        }
        public abstract int GetHocPhi();
    }
}
