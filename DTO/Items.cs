using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Items
    {
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

        private String _loai;
        public String loai
        {
            get { return _loai; }
            set { _loai = value; }
        }

        private byte[] _img;
        public byte[] img
        {
            get { return _img; }
            set { _img = value; }
        }

        public Items() { }

        public Items( String mmh, String tmh, int sl, int gia, String loai, byte[] img)
        {
            this.mamathang = mmh;
            this.tenmathang = tmh;
            this.soluong = sl;
            this.gia = gia;
            this.loai = loai;
            this.img = img;
        }
        public Items(DataRow row)
        {
            this.mamathang = (String)row["mamathang"];
            this.tenmathang = (String)row["tenmathang"];
            this.soluong = (int)row["soluong"];
            this.gia = (int)row["gia"];
            this.loai = (String)row["loai"];
            if (!Convert.IsDBNull(row["img"]))
            {
                this.img = (byte[])row["img"];
            }
            else
                this.img = null;
        }
    }
}
