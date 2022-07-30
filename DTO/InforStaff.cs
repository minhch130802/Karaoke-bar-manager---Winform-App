using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InforStaff
    {
        private String _manhanvien;
        public String manhanvien
        {
            get { return _manhanvien; }
            set { _manhanvien = value; }
        }

        private String _sdt;
        public String sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private String _hovaten;
        public String hovaten
        {
            get { return _hovaten; }
            set { _hovaten = value; }
        }

        private bool _gioitinh;
        public bool gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
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

        private byte[] _img;
        public byte[] img
        {
            get { return _img; }
            set { _img = value; }
        }

        public InforStaff() { }

        public InforStaff(String mnv, String hvt, String sdt, bool gt, String pl, String dc, byte[] img)
        {
            this._manhanvien = mnv;
            this._sdt = sdt;
            this._hovaten = hvt;
            this._gioitinh = gt;
            this._phanloai = pl;
            this._diachi = dc;
            this._img = img;
        }
    }
}
