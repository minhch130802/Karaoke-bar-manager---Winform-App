using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class listbookroom
    {
        private String _maphong;

        public String maphong
        {
            get { return _maphong; }
            set { _maphong = value;  }
        }
        private String _tenphong;

        public String tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }

        private String _trangthai;

        public String trangthai
        {
            get { return _trangthai; }
            set { _trangthai = value; }
        }

        public listbookroom() { }

        public listbookroom(String mp, String tp, String tt)
        {
            this.maphong = mp;
            this.tenphong = tp;
            this.trangthai= tt;
        }

        public listbookroom( DataRow row)
        {
            this.maphong = (String)row["maphong"];
            this.tenphong = (String)row["tenphong"];
            this.trangthai = (String)row["trangthai"];
        }
    }
}
