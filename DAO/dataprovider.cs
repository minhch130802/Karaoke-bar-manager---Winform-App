using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dataprovider
    {
        //declare
        public static dataprovider instance;

        public static dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new dataprovider();
                return instance;
            }
        }

        private dataprovider() { }

        private String connectstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=DatabaseKaraoke;Integrated Security=True";

        //1. Update, Delete, Insert
        public bool ExecuteNonQuery( String query, Object[] parameter = null)
        {
            DataTable data = new DataTable();

            bool value = false;

            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if ( parameter != null )
                {
                    String[] listpara = query.Split(' ');

                    int i = 0;

                    foreach (String item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                if (cmd.ExecuteNonQuery() >= 1 )
                    value = true;

                conn.Close();
            }

            return value;
        }

        //2. Select
        public DataTable ExecuteQuery ( String query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using ( SqlConnection conn = new SqlConnection(connectstring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if ( parameter != null )
                {
                    String[] listpara = query.Split(' ');

                    int i = 0;

                    foreach (String item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(data);

                conn.Close();
            }

            return data;
        }

        //3. Check data
        public bool ExecuteReader (String query, object[] parameter = null)
        {
            bool access = false;

            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if ( parameter != null )
                {
                    String[] listpara = query.Split(' ');

                    int i = 0;

                    foreach (String item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read() == true)
                    access = true;

                conn.Close();

            }

            return access;
        }
    }
}
