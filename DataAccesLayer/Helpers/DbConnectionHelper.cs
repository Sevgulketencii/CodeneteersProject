using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Helpers
{
    public class DbConnectionHelper
    {
        public SqlConnection Connection => GetConnection();

        public SqlConnection GetConnection()
        {
            //return new SqlConnection("server=DESKTOP-5N8R6K8; database=KolayIK; integrated security=true;");// herkes kendi connection string'ini kontrol etsin
            //for Şükriye
            //return new SqlConnection("server=.\\SQLExpress; database=KolayIK; integrated security=true;");
            //For Ayberk 
            return new SqlConnection("server=DESKTOP-KDK27UT\\SQLEXPRESS02; database=KolayIK; integrated security=true;");
        }
    }
}
