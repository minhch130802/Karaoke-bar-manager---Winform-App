using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Sales
    {
        private String _makhuyenmai;
        public String makhuyenmai
        {
            get { return _makhuyenmai; }
            set { _makhuyenmai = value; }
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

        private int _tilegiamgia;
        public int tilegiamgia
        {
            get { return _tilegiamgia; }
            set { _tilegiamgia = value; }
        }

        private int _soluong;
        public int soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }

        public Sales ( String mkm, DateTime times, DateTime timee, int tlgt, int sl)
        {
            this._makhuyenmai = mkm;
            this._timestart = times;
            this._timeend = timee;
            this._tilegiamgia = tlgt;
            this._soluong = sl;
        }
    }
}
