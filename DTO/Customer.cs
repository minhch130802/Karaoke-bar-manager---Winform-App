using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Customer
    {
        private String _makhachhang;
        public String makhachhang
        {
            get { return _makhachhang; }
            set { _makhachhang = value; }
        }

        private String _hovaten;
        public String hovaten
        {
            get { return _hovaten; }
            set { _hovaten = value; }
        }

        private String _email;
        public String email
        {
            get { return _email; }
            set { _email = value; }
        }

        private String _phanloai;
        public String phanloai
        {
            get { return _phanloai; }
            set { _phanloai = value; }
        }

        private String _diachi;
        public String diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        private DateTime _ngaytao;
        public DateTime ngaytao
        {
            get { return _ngaytao; }
            set { _ngaytao = value; }
        }

        private bool _trangthai;
        public bool trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }

        private int _sdt;
        public int sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public Customer ( String mkh, String hvt, String email, String pl, String dc, DateTime nt, bool tt, int sdt)
        {
            this._makhachhang = mkh;
            this._hovaten = hvt;
            this._email = email;
            this._phanloai = pl;
            this._diachi = dc;
            this._ngaytao = nt;
            this._trangthai = tt;
            this._sdt = sdt;
        }
    }
}
