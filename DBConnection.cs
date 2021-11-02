using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AptekaKursovoy
{
    class DBConnection
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=temuhadmin1;database=apteka");

        public bool isAvailible()
        {
            try
            {
                connect.Open();
                connect.Close();
            }
            catch (MySqlException)
            {
                return false;
            }
            return true;
        }

        public void openConection()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                }
                catch (MySqlException)
                {
                    return;
                }
            }
        }


        public void closeConection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }
        }
        public MySqlConnection getConnect()
        {
            return connect;
        }
    }
}
