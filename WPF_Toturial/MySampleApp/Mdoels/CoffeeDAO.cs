using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MySampleApp.Mdoels
{
    public class CoffeeDAO : IDisposable, ICoffeeDAO
    {
        SqlConnection conn;

        public CoffeeDAO()
        {
            string connStr = "";
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open) 
            {
                conn.Close();
            }
        }

        public bool Delete(string name)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Coffee> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(Coffee coffee)
        {
            throw new NotImplementedException();
        }
    }
}
