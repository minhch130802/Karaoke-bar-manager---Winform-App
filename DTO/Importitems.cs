using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Importitems
    {
        private String _mahoadon;
        public String mahoadon
        {
            get { return _mahoadon; }
            set { _mahoadon = value; }
        }

        private String _tenhoadon;
        public String tenhoadon
        {
            get { return _tenhoadon; }
            set { _tenhoadon = value; }
        }

        private String _mamathang;
        public String mamathang
        {
            get { return _mamathang; }
            set { _mamathang = value; }
        }

        private String _tenmathang;
        public String tenmathang
        {
            get { return _tenmathang; }
            set { _tenmathang = value; }
        }

        private int _soluong;
        public int soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        private int _gia;
        public int gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        private DateTime _ngaynhap;
        public DateTime ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }

        private String _congty;
        public String congty
        {
            get { return _congty; }
            set { _congty = value; }
        }

        private String _diachi;
        public String diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        public Importitems ( String mhd, String thd, String mmh, String tmh, int sl, int gia, DateTime nn, String ct, String dc)
        {
            this._mahoadon = mhd;
            this._tenhoadon = thd;
            this._mamathang = mmh;
            this._tenmathang = tmh;
            this._soluong = sl;
            this._gia = gia;
            this._ngaynhap = nn;
            this._congty = ct;
            this._diachi = dc;
        }
    }
}
