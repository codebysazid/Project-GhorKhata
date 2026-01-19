using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GhorKhata.Data
{
    public static class DatabaseConfig
    {
        public static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GhorKhataDB;Integrated Security=True";
    }
}
