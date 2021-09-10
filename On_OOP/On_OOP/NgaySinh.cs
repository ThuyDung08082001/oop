using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_OOP
{
    class NgaySinh
    {
        private int _ngay;
        private int _thang;
        private int _nam;

        public int Ngay
        {
            get
            {
                return _ngay;
            }

            set
            {
                _ngay = value;
            }
        }

        public int Thang
        {
            get
            {
                return _thang;
            }

            set
            {
                _thang = value;
            }
        }

        public int Nam
        {
            get
            {
                return _nam;
            }

            set
            {
                _nam = value;
            }
        }
        public NgaySinh()
        {
            this._ngay = 0;
            this._thang = 0;
            this._nam = 0;
        }
        public NgaySinh(int ngay, int thang, int nam)
        {
            this._ngay = ngay;
            this._thang = thang;
            this._nam = nam;
        }
        public string toString()
        {
            return $"Ngay Sinh:{this._ngay}-{this._thang}-{this._nam}";
        }
    }
}
