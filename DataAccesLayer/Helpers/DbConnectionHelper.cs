using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Helpers
{
    class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();
        private SqlConnection GetConnection()
        {
            return new SqlConnection("server=DESKTOP-5N8R6K8; database=KolayIK; integrated security=true;");// herkes kendi connection string'ini kontrol etsin
        }

    }
}
