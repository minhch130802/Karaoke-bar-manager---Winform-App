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
    public class bus_importitem
    {
        public static bus_importitem instance;

        public static bus_importitem Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_importitem();
                return instance;
            }
        }

        private String FillImportItmesQuery = @"EXEC FillImportItmes ";
        public DataTable FillImportItmes()
        {
            return dataprovider.Instance.ExecuteQuery(FillImportItmesQuery);
        }

        private String DeleteImportItemsQuery = @"EXEC DeleteImportItems @mahoadon ";
        public bool DeleteImportItems( String mhd)
        {
            return dataprovider.Instance.ExecuteNonQuery(DeleteImportItemsQuery, new object[] { mhd });
        }

        private String InsertImportItemQuery = @"EXEC InsertImportItem @mahoadon , @tenhoadon , @mamathang , @tenmathang , @soluong , @gia , @ngaynhap , @congty , @diachi ";
        public bool InsertImportItem(String mahoadon, String tenhoadon, String mamathang, String tenmathang, int soluong, int gia, DateTime ngaynhap, String congty, String diachi)
        {
            return dataprovider.Instance.ExecuteNonQuery(InsertImportItemQuery, new object[] { mahoadon, tenhoadon, mamathang, tenmathang, soluong, gia, ngaynhap, congty, diachi });
        }

        private String UpdateImportItemsQuery = @"EXEC UpdateImportItems @mahoadon , @tenhoadon , @mamathang , @tenmathang , @soluong , @gia , @ngaynhap , @congty , @diachi ";
        public bool UpdateImportItems(String mahoadon, String tenhoadon, String mamathang, String tenmathang, int soluong, int gia, DateTime ngaynhap, String congty, String diachi)
        {
            return dataprovider.Instance.ExecuteNonQuery(UpdateImportItemsQuery, new object[] { mahoadon, tenhoadon, mamathang, tenmathang, soluong, gia, ngaynhap, congty, diachi });
        }
    }
}
