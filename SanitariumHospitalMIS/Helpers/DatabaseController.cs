// Author: Bill-Lawrence T. Samar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SanitariumHospitalMIS.Helpers
{
    public class DatabaseController
    {
        private String _MySQLConnectionString = "";
        private MySqlConnection _MySQLConnection;

        public DatabaseController(String hostname,String username,String password)
        {
            _MySQLConnectionString = "";
        }

        public bool PerformQuery()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public bool PerformNonQuery()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        private bool OpenConnection()
        {
            try
            {
                _MySQLConnection.ConnectionString = _MySQLConnectionString;
                _MySQLConnection.Open();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
    }
}
