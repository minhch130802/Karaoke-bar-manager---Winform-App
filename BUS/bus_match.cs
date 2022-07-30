using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_match
    {
        public static bus_match instance;

        public static bus_match Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_match();
                return instance;
            }
        }

        private bus_match() { }

        private String InsertNewOrderQuery = @"EXEC InserNewOrder @maphong , @timestar , @mahanghoa , @soluong ";
        public bool InsertNewOrder( String mp, DateTime time, String mhh, int sl)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertNewOrderQuery, new object[] { mp, time, mhh, sl });
        }

        private String UpdateNewItemsOrderQuery = @"EXEC UpdateNewItemsOrder @maphong  , @mahanghoa , @soluong ";
        public bool UpdateNewItemsOrder( String mp, String mhh, int sl)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateNewItemsOrderQuery, new object[] { mp, mhh, sl }); 
        }

        private String UpdateNewTimeendOrderQuery = @"EXEC UpdateNewTimeendOrder @maphong , @timeend ";
        public bool UpdateNewTimeendOrder( String mp, DateTime time)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateNewTimeendOrderQuery, new object[] { mp, time });
        }
    }
}
