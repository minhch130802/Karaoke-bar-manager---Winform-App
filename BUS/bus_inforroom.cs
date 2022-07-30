using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_inforroom
    {
        public static bus_inforroom instance;

        public static bus_inforroom Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_inforroom();
                return instance;
            }
        }

        private bus_inforroom() { }

        //Check data
        private String CheckQuery = @"EXEC SelectIdInforroom @maphong";
        public bool CheckIdInforRoom( String mp)
        {
            return dataprovider.Instance.ExecuteReader(CheckQuery, new object[] { mp });
        }

        //Fill data
        private String FillQuery = @"EXEC FillRoom";
        public DataTable FillRoom()
        {
            return dataprovider.Instance.ExecuteQuery(FillQuery);
        }

        //Add data
        private String InsertQuery = @"EXEC InsertRoom @maphong , @tenphong , @loaiphong , @trangthai , @giaphong , @suachua , @ngaybatdau , @ngayketthuc ";
        public bool InsertRoom( String mp, String tp, String lp, String tl, int gp, String sc, DateTime ts, DateTime te)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertQuery, new object[] { mp, tp, lp, tl, gp, ts, te });
        }

        //Update data
        private String UpdateQuery = @"EXEC UpdateRoom @maphong , @tenphong , @loaiphong , @trangthai , @giaphong , @suachua , @ngaybatdau , @ngayketthuc ";
        public bool UpdateRoom(String mp, String tp, String lp, String tl, int gp, String sc, DateTime ts, DateTime te)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateQuery, new object[] { mp, tp, lp, tl, gp, ts, te });
        }

        //Delete data
        private String DeleteQuery = @"EXEC DeleteRoom @maphong";
        public bool DeleteRoom(String mp)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteQuery, new object[] { mp });
        }
    }
}
