using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bus_inforstaff
    {
        //declare
        public static bus_inforstaff instance;

        public static bus_inforstaff Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_inforstaff();
                return instance;
            }
        }

        private bus_inforstaff() { }

        //check id
        private String SelectIdInforStaff = @"EXEC SelectIdInforStaff @manhanvien ";
        public bool checkid(String mnv)
        {
            return dataprovider.Instance.ExecuteReader(SelectIdInforStaff, new object[] { mnv });
        }

        //Fill data
        private String FillQuery = @"EXEC FillInfoStaff";

        public DataTable FillInfoStaff()
        {
            DataTable data = new DataTable();

            data = dataprovider.Instance.ExecuteQuery(FillQuery);

            return data;
        }

        //Add without img
        private String AddNoQuery = @"EXEC InsertNoInforStaff @manhanvien , @tentaikhoan , @matkhau , @email , @sdt , @hovaten , @gioitinh , @phanloai , @diachi ";
        public bool AddNoInforStaff(String mvn, String ttk, String mk, String email, String sdt, String hvt, bool gt, String pl, String dc)
        {
            return dataprovider.Instance.ExecuteNonQuery(AddNoQuery, new object[] { mvn, ttk, mk, email, sdt, hvt, gt, pl, dc});
        }

        //Add with img
        private String AddQuery = @"EXEC InsertInforStaff @manhanvien , @tentaikhoan , @matkhau , @email , @sdt , @hovaten , @gioitinh , @phanloai , @diachi , @img ";
        public bool AddInforStaff(String mvn, String ttk, String mk, String email, String sdt, String hvt, bool gt, String pl, String dc, byte[] img)
        {
            return dataprovider.Instance.ExecuteNonQuery(AddQuery, new object[] { mvn, ttk, mk, email, sdt, hvt, gt, pl, dc, img } );
        }


        //Update without img
        private String UpdateNoQuery = @"EXEC UpdateNoInforStaff @manhanvien , @tentaikhoan , @matkhau , @email , @sdt , @hovaten , @gioitinh , @phanloai , @diachi ";
        public bool UpdateNoInforStaff(String mvn, String ttk, String mk, String email, String sdt, String hvt, bool gt, String pl, String dc)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateNoQuery, new object[] { mvn, ttk, mk, email, sdt, hvt, gt, pl, dc });
        }

        //Update with img
        private String UpdateQuery = @"EXEC UpdateInforStaff @manhanvien , @tentaikhoan , @matkhau , @email , @sdt , @hovaten , @gioitinh , @phanloai , @diachi , @img";
        public bool UpdateInforStaff(String mvn, String ttk, String mk, String email, String sdt, String hvt, bool gt, String pl, String dc, byte[] img)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateQuery, new object[] { mvn, ttk, mk, email, sdt, hvt, gt, pl, dc, img });
        }

        //Delete
        private String DeleteQuery = @"EXEC DeleteInforStaff @manhanvien ";
        public bool DeleteInforStaff (String mnv)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteQuery, new object[] { mnv });
        }
    }
}
