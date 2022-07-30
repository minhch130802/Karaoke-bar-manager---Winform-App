using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_menu
    {
        public static bus_menu instance;

        public static bus_menu Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_menu();
                return instance;
            }
        }

        private String FillReceiptQuery = @"EXEC FillReceipt ";
        public DataTable FillReceipt()
        {
            return dataprovider.Instance.ExecuteQuery(FillReceiptQuery);
        }

        private String DeleteReceiptQuery = @"EXEC DeleteReceipt @mahoadon ";
        public bool DeleteReceipt(String mp )
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteReceiptQuery, new object[] { mp });
        }

        private String FillInserReceiptQuery = @"EXEC FillInserReceiptQuery mahoadon ";
        public bool FillInserReceipt(String mp)
        {
            return dataprovider.Instance.ExecuteNonQuery(FillInserReceiptQuery, new object[] { mp });
        }
    }
}
