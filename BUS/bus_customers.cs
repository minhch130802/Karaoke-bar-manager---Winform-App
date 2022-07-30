    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class bus_customers
    {
        public static bus_customers instance;

        public static bus_customers Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_customers();
                return instance;
            }
        }

        private bus_customers() { }

        //Check data
        private String CheckQuery = @"EXEC SelectIdCustomers @makhachhang ";
        public bool CheckIdCustomer( String mkh)
        {
            return dataprovider.Instance.ExecuteReader(CheckQuery, new object[] { mkh });
        }

        //Fill data
        private String FillQuery = @"EXEC FillCustomers";
        public DataTable FillCustomer()
        {
            return dataprovider.Instance.ExecuteQuery(FillQuery);
        }

        //Insert Data
        private String InsertQuery = @"EXEC InsertCustomers @makhachhang , @hovaten , @email , @diachi , @sdt , @tilegiamgia ";
        public bool InsertCustomer( String mkh, String hvt, String email, String dc, String sdt, int tlgt )
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertQuery, new object[] { mkh, hvt, email, dc, sdt, tlgt});
        }

        //Update Data
        private String UpdateQuery = @"EXEC UpdateCustomers @makhachhang , @hovaten , @email , @diachi , @sdt , @tilegiamgia ";
        public bool UpdateCustomer(String mkh, String hvt, String email, String dc, String sdt, int tlgt)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateQuery, new object[] { mkh, hvt, email, dc, sdt, tlgt });
        }

        //Delete Data
        private String DeleteQuery = @"EXEC DeleteCustomers @makhachhang ";
        public bool DeleteCustomer(String mkh)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteQuery, new object[] { mkh });
        }
    }
}
