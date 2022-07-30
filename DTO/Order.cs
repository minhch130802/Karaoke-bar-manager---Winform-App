using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Order
    {
        private String _mahoadon;
        public String mahoadon
        {
            get { return _mahanghoa; }
            set { _mahanghoa = value; }
        }

        private String _maphong;
        public String maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }

        private DateTime _timestart;
        public DateTime timestart
        {
            get { return _timestart; }
            set { _timestart = value; }
        }

        private DateTime _timeend;
        public DateTime timeend
        {
            get { return _timeend; }
            set { _timeend = value; }
        }

        private String _mahanghoa;
        public String mahanghoa
        {
            get { return _mahanghoa; }
            set { _mahanghoa = value; }
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

        public Order(String mhd, String mp, DateTime times, DateTime timee, String mhh, int sl, int gia)
        {
            this._mahoadon = mhd;
            this._maphong = mp;
            this._timestart = times;
            this._timeend = timee;
            this._soluong = sl;
            this._gia = gia;
        }
    }
}
