using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Receipt
    {
        private String _mahoadon;
        public String mahoadon
        {
            get { return _mahoadon; }
            set { _mahoadon = value; }
        }

        private String _maphong;
        public String maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }

        private String _tenphong;
        public String tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }

        private DateTime _thoigiansudung;
        public DateTime thoigiansudung
        {
            get { return _thoigiansudung; }
            set { _thoigiansudung = value; }
        }

        private int _tienphong;
        public int tienphong
        {
            get { return _tienphong; }
            set { _tienphong = value; }
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

        private int _soluongmathang;
        public int soluongmathang
        {
            get { return _soluongmathang; }
            set { _soluongmathang = value; }
        }

        private int _tienhang;
        public int tienhang
        {
            get { return _tienhang; }
            set { _tienhang = value; }
        }

        public Receipt () { }

        public Receipt ( String mhd, String mp, String tenp, DateTime tgsd, int tp, String mmh, String tmh, int slmh,  int th)
        {
            this.mahoadon = mhd;
            this.maphong = mp;
            this.thoigiansudung = tgsd;
            this.tienphong = tp;
            this.mamathang = mmh;
            this.tenmathang = tmh;
            this.soluongmathang = slmh;
            this.tienhang = th;
            this.tenphong = tenp;
        }
    }
}
