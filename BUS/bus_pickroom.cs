using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class bus_pickroom
    {
        public static bus_pickroom instance;

        public static bus_pickroom Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_pickroom();
                return instance;
            }
        }

        private bus_pickroom() { }

        private String query = "EXEC FillBookRoom @loaiphong";

        public int TableWidth = 220;

        public int TableHeight = 255;

        public List<listbookroom> loadroom ( String loaiphong )
        {
            List<listbookroom> listbookroom = new List<listbookroom>();

            DataTable data = new DataTable();

            data = dataprovider.Instance.ExecuteQuery(query, new object[] { loaiphong });

            foreach (DataRow item in data.Rows)
            {
                listbookroom broom = new listbookroom(item);
                listbookroom.Add(broom);
            }

            return listbookroom;
        }

        private String SelectItemQuery = "EXEC SelectMenuItems @loai";

        public int ItemsWith = 320;

        public int ItemsHeight = 250;

        public List<Items> loaditems ( String loai )
        {
            List<Items> listitems = new List<Items>();

            DataTable data = new DataTable();

            data = dataprovider.Instance.ExecuteQuery(SelectItemQuery, new object[] { loai });

            foreach ( DataRow item in data.Rows)
            {
                Items list = new Items(item);
                listitems.Add(list);
            }

            return listitems;
        }

        private String checkroomQuery = @"EXEC CheckRoom @idroom ";
        public bool CheckRoom(String id)
        {
            return dataprovider.Instance.ExecuteReader(checkroomQuery, new object[] { id });
        }

        private String checkEmtyroomQuery = @"EXEC CheckEmtyRoom @idroom ";
        public bool CheckEmtyRoom(String id)
        {
            return dataprovider.Instance.ExecuteReader(checkEmtyroomQuery, new object[] { id });
        }

        private String FillPickRoomQuery = @"EXEC FillPickRoom @maphong ";
        public DataTable FillPickRoom(String id)
        {
            return dataprovider.Instance.ExecuteQuery(FillPickRoomQuery, new object[] { id });
        }

        private String InsertNewOrderQuery = @"EXEC InserNewOrder @maphong , @timestar , @mahanghoa , @soluong ";
        public bool InsertNewOrder(String mp, DateTime time, String mhh, int sl)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertNewOrderQuery, new object[] { mp, time, mhh, sl });
        }

        private String UpdateNewTimeendOrderQuery = @"EXEC UpdateNewTimeendOrder @maphong , @timeend ";
        public bool UpdateNewTimeendOrder(String mp, DateTime time)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateNewTimeendOrderQuery, new object[] { mp, time });
        }

        private String DeletRoomOrderQuery = @"EXEC DeletRoomOrder @maphong ";
        public bool DeletRoomOrder(String mp)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeletRoomOrderQuery, new object[] { mp });
        }
    }
}
