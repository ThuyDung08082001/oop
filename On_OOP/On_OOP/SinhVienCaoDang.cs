using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    class SinhVienCaoDang : SinhVien
    {
        private int _soTinChiLyThuyet;
        private int _donGiaMonHocLyThuyet;
        private int _soTinChiThucHanh;
        private int _donGiaMonThucHanh;
        private static int _dem;

        public int SoTinChiLyThuyet
        {
            get
            {
                return _soTinChiLyThuyet;
            }

            set
            {
                _soTinChiLyThuyet = value;
            }
        }

        public int DonGiaMonHocLyThuyet
        {
            get
            {
                return _donGiaMonHocLyThuyet;
            }

            set
            {
                _donGiaMonHocLyThuyet = value;
            }
        }

        public int SoTinChiThucHanh
        {
            get
            {
                return _soTinChiThucHanh;
            }

            set
            {
                _soTinChiThucHanh = value;
            }
        }

        public int DonGiaMonThucHanh
        {
            get
            {
                return _donGiaMonThucHanh;
            }

            set
            {
                _donGiaMonThucHanh = value;
            }
        }

        public static int Dem
        {
            get
            {
                return _dem;
            }

        }

        public SinhVienCaoDang() : base()
        {
            this._soTinChiLyThuyet = 0;
            this._donGiaMonHocLyThuyet = 0;
            this._soTinChiThucHanh = 0;
            this._donGiaMonThucHanh = 0;
            _dem++;
        }
        public SinhVienCaoDang(int tinChiLyThuyet, int donGiaLyThuyet, int tinChiThucHanh, int donGiaThucHanh) : base()
        {
            this._soTinChiLyThuyet = tinChiLyThuyet;
            this._donGiaMonHocLyThuyet = donGiaLyThuyet;
            this._soTinChiThucHanh = tinChiThucHanh;
            this._donGiaMonThucHanh = donGiaThucHanh;
            _dem++;
        }
        public SinhVienCaoDang(int tinChiLyThuyet, int donGiaLyThuyet, int tinChiThucHanh, int donGiaThucHanh, string maSV, string tenSV, string gioiTinh, NgaySinh ngaySinh, string queQuan, int BHYT, int thuPhu) : base(maSV, tenSV, gioiTinh, ngaySinh, queQuan, BHYT, thuPhu)
        {
            this._soTinChiLyThuyet = tinChiLyThuyet;
            this._donGiaMonHocLyThuyet = donGiaLyThuyet;
            this._soTinChiThucHanh = tinChiThucHanh;
            this._donGiaMonThucHanh = donGiaThucHanh;
            _dem++;
        }

        public override int GetHocPhi()
        {
            int hocPhi = this._soTinChiLyThuyet * this._donGiaMonHocLyThuyet + this._soTinChiThucHanh * this._donGiaMonThucHanh + this.BaoHiemYTe + this.ThuPhu;
            return hocPhi;
        }
        public override string toString()
        {
            string str = $"Sinh Vien Cao Dang:\n\t{base.toString()}\n\tSo Tin Chi Ly Thuyet:{this._soTinChiLyThuyet}\n\tDon Gia Mon Hoc Ly Thuyet:{this._donGiaMonHocLyThuyet}\n\tSo Tin Chi Thuc Hanh:{this._soTinChiThucHanh}\n\tDon Gia Mon Thuc Hanh{this._donGiaMonThucHanh}\n\tTong Hoc Phi:{this.GetHocPhi()}";
            return str;
        }
    }
}
