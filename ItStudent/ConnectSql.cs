using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStudent
{
    class ConnectSql
    {
        public SqlConnection kn = new SqlConnection();
        public void Connect()
        {
            string conString = "Data Source=.;Initial Catalog=QLSinhVien;Persist Security Info=True;User ID=sa;Password=123";
            kn.ConnectionString = conString;
            kn.Open();
        }
    }
}
