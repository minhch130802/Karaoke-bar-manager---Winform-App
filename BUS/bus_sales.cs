using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_sales
    {
        //declare
        public static bus_sales instance;

        public static bus_sales Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_sales();
                return instance;
            }
        }

        private bus_sales() { }

        //check data
        private String CheckQuery = @"EXEC SelectIdSales @makhuyenmai";
        public bool CheckIdSales( String mkm)
        {
            return dataprovider.Instance.ExecuteReader(CheckQuery, new object[] { mkm });
        }

        //Fill data
        private String FillQuery = @"EXEC Fillsales ";
        public DataTable FillSales()
        {
            return dataprovider.Instance.ExecuteQuery(FillQuery);
        }

        //Add data
        private String InsertQuery = @"EXEC InsertSales @makhuyenmai , @timestar , @timeend , @tilegiamgia , @soluong ";
        public bool InsertSales( String mkm, DateTime ts, DateTime te, int tlgg, int sl)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertQuery, new object[] { mkm, ts, te, tlgg, sl });
        }

        //Update data
        private String UpdateQuery = @"EXEC UpdateSales @makhuyenmai , @timestar , @timeend , @tilegiamgia , @soluong ";
        public bool UpdatetSales(String mkm, DateTime ts, DateTime te, int tlgg, int sl)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateQuery, new object[] { mkm, ts, te, tlgg, sl });
        }

        //Delete
        private String DeleteQuery = @"EXEC DeleteSales @makhuyenmai";
        public bool DeleteSales(String mkm)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteQuery, new object[] { mkm });
        }
    }
}
