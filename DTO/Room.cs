using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Room
    {
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

        private String _loaiphong;
        public String loaiphong
        {
            get { return _loaiphong; }
            set { _loaiphong = value; }
        }

        private String _trangthai;
        public String trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }

        private int _giaphong;
        public int giaphong
        {
            get { return _giaphong; }
            set { _giaphong = value; }
        }

        public Room( String mp, String tp, String lp, String tt, int gp)
        {
            this._maphong = mp;
            this._tenphong = tp;
            this._loaiphong = lp;
            this._trangthai = tt;
            this._giaphong = gp;
        }
    }
}
