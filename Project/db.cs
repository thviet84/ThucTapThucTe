using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    internal class db
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Data Source = LAPTOP-O4NAKIGN; Database =qrcode; Integrated Security = true");
                con.Open();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        } 

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
