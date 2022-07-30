using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_inforitems
    {
        public static bus_inforitems instance;

        public static bus_inforitems Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_inforitems();
                return instance;
            }
        }

        private bus_inforitems() { }

        private String SelectIdItems = @"EXEC SelectIdItems @mamathang ";
        public bool checkid(String mnv)
        {
            return dataprovider.Instance.ExecuteReader(SelectIdItems, new object[] { mnv });
        }

        //Fill data
        private String FillQuery = @"EXEC FillItems";
        public DataTable FillItems()
        {
            return dataprovider.Instance.ExecuteQuery(FillQuery);
        }

        //Insert no data
        private String InsertNoQuery = @"EXEC InsertNoItems @mamathang , @tenmathang , @soluong , @gia , @loai  ";
        public bool InsertNoItems(String mmt, String tmh, int sl, int gia, String pl)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertNoQuery, new object[] { mmt, tmh, sl, gia, pl });
        }

        //Insert data
        private String InsertQuery = @"EXEC InsertItems @mamathang , @tenmathang , @soluong , @gia , @loai , @img ";
        public bool InsertItems( String mmt, String tmh, int sl, int gia, String pl, byte[] img )
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertQuery, new object[] { mmt, tmh, sl, gia, pl, img });
        }

        //Update no data
        private String UpdateNoQuery = @"EXEC UpdateNoItems @mamathang , @tenmathang , @soluong , @gia , @loai ";
        public bool UpdateNoItems(String mmt, String tmh, int sl, int gia, String pl)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateNoQuery, new object[] { mmt, tmh, sl, gia, pl});
        }

        //Update data
        private String UpdateQuery = @"EXEC UpdateItems @mamathang , @tenmathang , @soluong , @gia , @loai , @img ";
        public bool UpdateItems(String mmt, String tmh, int sl, int gia, String pl, byte[] img)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateQuery, new object[] { mmt, tmh, sl, gia, pl, img });
        }

        //Delete data
        private String DeleteQuery = @"EXEC DeleteItems @mamathang ";
        public bool DeleteItems(String mmt)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteQuery, new object[] { mmt });
        }
    }
}
