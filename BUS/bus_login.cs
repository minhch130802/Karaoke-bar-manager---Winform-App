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
    public class bus_login
    {
        public static bus_login instance;

        public static bus_login Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_login();
                return instance;
            }
        }

        private bus_login() { }

        public bool login(String username, String password)
        { 
            String query = "EXEC Login @username , @password";

            bool access = dataprovider.Instance.ExecuteReader(query, new object[] { username, password });

            bool type = false;

            DataTable data = new DataTable();

            data = dataprovider.Instance.ExecuteQuery(query, new object[] { username, password });

            String name = "";

            foreach (DataRow item in data.Rows)
            {
                name = item["tentaikhoan"].ToString();
                if (item["phanloai"].ToString().Equals("Quản lý"))
                {
                    type = true;
                }
                else
                    type = false;
            }

            Login value = new Login (access, type, name);

            return access;
        }
    }
}



